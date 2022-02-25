/***********************************************************************************************\
 * (C) KAL ATM Software GmbH, 2022
 * KAL ATM Software GmbH licenses this file to you under the MIT license.
 * See the LICENSE file in the project root for more information.
 *
 * This file was created automatically as part of the XFS4IoT CashAcceptor interface.
 * SubCashInEvent_g.cs uses automatically generated parts.
\***********************************************************************************************/

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using XFS4IoT.Events;

namespace XFS4IoT.CashAcceptor.Events
{

    [DataContract]
    [Event(Name = "CashAcceptor.SubCashInEvent")]
    public sealed class SubCashInEvent : Event<SubCashInEvent.PayloadData>
    {

        public SubCashInEvent(int RequestId, PayloadData Payload)
            : base(RequestId, Payload)
        { }


        [DataContract]
        public sealed class PayloadData : MessagePayloadBase
        {

            public PayloadData(int? Unrecognized = null)
                : base()
            {
                this.Unrecognized = Unrecognized;
            }

            /// <summary>
            /// Count of unrecognized items handled by the cash interface.
            /// </summary>
            [DataMember(Name = "unrecognized")]
            public int? Unrecognized { get; init; }

            [System.Text.Json.Serialization.JsonExtensionData]
            public Dictionary<string, System.Text.Json.JsonElement> ExtensionData { get; set; } = new();

            [System.Text.Json.Serialization.JsonIgnore]
            public Dictionary<string, CashManagement.StorageCashCountClass> ExtendedProperties
            {
                get => MessageBase.ParseExtendedProperties<CashManagement.StorageCashCountClass>(ExtensionData);
                set => ExtensionData = MessageBase.CreateExtensionData<CashManagement.StorageCashCountClass>(value);
            }

        }

    }
}
