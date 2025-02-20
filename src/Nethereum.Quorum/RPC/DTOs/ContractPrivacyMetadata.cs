﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nethereum.Quorum.RPC.DTOs
{
    [DataContract]
    public class ContractPrivacyMetadata
    {
        /// <summary>
        /// affected contract’s original transaction’s encrypted payload hash
        /// </summary>
        [DataMember(Name = "creationTxHash")]
        public string CreationTxHash { get; set; }

        /// <summary>
        /// 0 for SP, 1 for PP, 2 for MPP, and 3 for PSV transactions
        /// </summary>
        [DataMember(Name = "privacyFlag")]
        public int PrivacyFlag { get; set; }

        /// <summary>
        /// an array of the recipients’ base64-encoded public keys
        /// </summary>
        [DataMember(Name = "mandatoryFor")]
        public List<string> MandatoryFor { get; set; }

    }

}
