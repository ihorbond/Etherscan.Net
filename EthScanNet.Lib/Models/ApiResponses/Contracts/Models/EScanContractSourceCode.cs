﻿using Newtonsoft.Json;

namespace EthScanNet.Lib.Models.ApiResponses.Contracts.Models
{
    public class EScanContractSourceCode
    {
        [JsonProperty("SourceCode")]
        public string SourceCode { get; set; }

        [JsonProperty("ABI")]
        public string ABI { get; set; }

        [JsonProperty("ContractName")]
        public string ContractName { get; set; }
        
        [JsonProperty("CompilerVersion")]
        public string CompilerVersion { get; set; }

        [JsonProperty("OptimizationUsed")]
        public string OptimizationUsed { get; set; }

        [JsonProperty("Runs")]
        public string Runs { get; set; }

        [JsonProperty("ConstructorArguments")]
        public string ConstructorArguments { get; set; }

        [JsonProperty("EVMVersion")]
        public string EVMVersion { get; set; }

        [JsonProperty("Library")]
        public string Library { get; set; }

        [JsonProperty("LicenseType")]
        public string LicenseType { get; set; }

        [JsonProperty("Proxy")]
        public string Proxy { get; set; }

        [JsonProperty("Implementation")]
        public string Implementation { get; set; }

        [JsonProperty("SwarmSource")]
        public string SwarmSource { get; set; }
    }
}
