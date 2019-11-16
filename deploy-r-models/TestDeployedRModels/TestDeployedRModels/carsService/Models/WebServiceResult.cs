﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestDeployedRModels.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class WebServiceResult
    {
        /// <summary>
        /// Initializes a new instance of the WebServiceResult class.
        /// </summary>
        public WebServiceResult() { }

        /// <summary>
        /// Initializes a new instance of the WebServiceResult class.
        /// </summary>
        public WebServiceResult(bool? success = default(bool?), string errorMessage = default(string), string consoleOutput = default(string), IList<string> changedFiles = default(IList<string>), OutputParameters outputParameters = default(OutputParameters))
        {
            Success = success;
            ErrorMessage = errorMessage;
            ConsoleOutput = consoleOutput;
            ChangedFiles = changedFiles;
            OutputParameters = outputParameters;
        }

        /// <summary>
        /// Boolean flag indicating the success status of web service
        /// execution.
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Error messages if any occurred during the web service execution.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Console output from the web service execution.
        /// </summary>
        [JsonProperty(PropertyName = "consoleOutput")]
        public string ConsoleOutput { get; set; }

        /// <summary>
        /// The filenames of the files modified during the web service
        /// execution.
        /// </summary>
        [JsonProperty(PropertyName = "changedFiles")]
        public IList<string> ChangedFiles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outputParameters")]
        public OutputParameters OutputParameters { get; set; }

    }
}
