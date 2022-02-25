/***********************************************************************************************\
 * (C) KAL ATM Software GmbH, 2021
 * KAL ATM Software GmbH licenses this file to you under the MIT license.
 * See the LICENSE file in the project root for more information.
 *
 * This file was created automatically as part of the XFS4IoT Biometric interface.
 * SetDataPersistenceHandler.cs uses automatically generated parts.
\***********************************************************************************************/


using System;
using System.Threading.Tasks;
using System.Threading;
using XFS4IoT;
using XFS4IoTServer;
using XFS4IoT.Biometric.Commands;
using XFS4IoT.Biometric.Completions;
using XFS4IoTFramework.Common;

namespace XFS4IoTFramework.Biometric
{
    public partial class SetDataPersistenceHandler
    {

        private async Task<SetDataPersistenceCompletion.PayloadData> HandleSetDataPersistence(ISetDataPersistenceEvents events, SetDataPersistenceCommand setDataPersistence, CancellationToken cancel)
        {
            if (setDataPersistence?.Payload?.PersistenceMode is null)
                return new SetDataPersistenceCompletion.PayloadData(XFS4IoT.Completions.MessagePayload.CompletionCodeEnum.InvalidData, "No PersistenceMode supplied.");

            BiometricCapabilitiesClass.PersistenceModesEnum mode = setDataPersistence.Payload.PersistenceMode switch
            {
                SetDataPersistenceCommand.PayloadData.PersistenceModeEnum.Persist => BiometricCapabilitiesClass.PersistenceModesEnum.Persist,
                SetDataPersistenceCommand.PayloadData.PersistenceModeEnum.Clear => BiometricCapabilitiesClass.PersistenceModesEnum.Clear,
                _ => throw Contracts.Fail<NotImplementedException>("Unexpected PersistenceMode specified.")
            };

            if (!Common.BiometricCapabilities.PersistenceModes.HasFlag(mode))
                return new SetDataPersistenceCompletion.PayloadData(XFS4IoT.Completions.MessagePayload.CompletionCodeEnum.UnsupportedData, "Specified PersistenceMode is not supported.");

            Logger.Log(Constants.DeviceClass, "BiometricDev.SetDataPersistenceAsync()");
            var result = await Device.SetDataPersistenceAsync(mode, cancel);
            Logger.Log(Constants.DeviceClass, $"BiometricDev.SetDataPersistenceAsync() -> {result.CompletionCode}");

            return new SetDataPersistenceCompletion.PayloadData(result.CompletionCode,
                                                                result.ErrorDescription);
        }

    }
}
