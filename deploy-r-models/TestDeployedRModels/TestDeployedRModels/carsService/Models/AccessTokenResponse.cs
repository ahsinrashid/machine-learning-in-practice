﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestDeployedRModels.Models
{
    using Newtonsoft.Json;

    public partial class AccessTokenResponse
    {
        /// <summary>
        /// Initializes a new instance of the AccessTokenResponse class.
        /// </summary>
        public AccessTokenResponse() { }

        /// <summary>
        /// Initializes a new instance of the AccessTokenResponse class.
        /// </summary>
        public AccessTokenResponse(string tokenType = default(string), string accessToken = default(string), string expiresOn = default(string), string refreshToken = default(string))
        {
            TokenType = tokenType;
            AccessToken = accessToken;
            ExpiresOn = expiresOn;
            RefreshToken = refreshToken;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expires_on")]
        public string ExpiresOn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

    }
}
