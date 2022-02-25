/***********************************************************************************************\
 * (C) KAL ATM Software GmbH, 2021
 * KAL ATM Software GmbH licenses this file to you under the MIT license.
 * See the LICENSE file in the project root for more information.
 *
 * This file was created automatically as part of the XFS4IoT CashAcceptor interface.
 * DepleteHandler.cs uses automatically generated parts.
\***********************************************************************************************/


using System;
using System.Threading.Tasks;
using System.Threading;
using XFS4IoT;
using XFS4IoTServer;
using XFS4IoT.CashAcceptor.Commands;
using XFS4IoT.CashAcceptor.Completions;

namespace XFS4IoTFramework.CashAcceptor
{
    public partial class DepleteHandler
    {

        private Task<DepleteCompletion.PayloadData> HandleDeplete(IDepleteEvents events, DepleteCommand deplete, CancellationToken cancel)
        {
            //ToDo: Implement HandleDeplete for CashAcceptor.
            
            #if DEBUG
                throw new NotImplementedException("HandleDeplete for CashAcceptor is not implemented in DepleteHandler.cs");
            #else
                #error HandleDeplete for CashAcceptor is not implemented in DepleteHandler.cs
            #endif
        }

    }
}
