/***********************************************************************************************\
 * (C) KAL ATM Software GmbH, 2021
 * KAL ATM Software GmbH licenses this file to you under the MIT license.
 * See the LICENSE file in the project root for more information.
 *
 * This file was created automatically as part of the XFS4IoT Camera interface.
 * ResetHandler.cs uses automatically generated parts.
\***********************************************************************************************/


using System;
using System.Threading.Tasks;
using System.Threading;
using XFS4IoT;
using XFS4IoTServer;
using XFS4IoT.Camera.Commands;
using XFS4IoT.Camera.Completions;

namespace XFS4IoTFramework.Camera
{
    public partial class ResetHandler
    {

        private async Task<ResetCompletion.PayloadData> HandleReset(IResetEvents events, ResetCommand reset, CancellationToken cancel)
        {
            Logger.Log(Constants.DeviceClass, "CameraDev.ResetDeviceAsync()");
            var result = await Device.ResetDeviceAsync(cancel);
            Logger.Log(Constants.DeviceClass, $"CameraDev.ResetDeviceAsync() -> {result.CompletionCode}");

            return new ResetCompletion.PayloadData(result.CompletionCode,
                                                   result.ErrorDescription);
        }

    }
}
