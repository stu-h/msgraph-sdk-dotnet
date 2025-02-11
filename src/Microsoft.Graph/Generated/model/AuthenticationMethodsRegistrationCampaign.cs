// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type AuthenticationMethodsRegistrationCampaign.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AuthenticationMethodsRegistrationCampaign>))]
    public partial class AuthenticationMethodsRegistrationCampaign
    {

        /// <summary>
        /// Gets or sets excludeTargets.
        /// Users and groups of users that are excluded from being prompted to set up the authentication method.
        /// </summary>
        [JsonPropertyName("excludeTargets")]
        public IEnumerable<ExcludeTarget> ExcludeTargets { get; set; }
    
        /// <summary>
        /// Gets or sets includeTargets.
        /// Users and groups of users that are prompted to set up the authentication method.
        /// </summary>
        [JsonPropertyName("includeTargets")]
        public IEnumerable<AuthenticationMethodsRegistrationCampaignIncludeTarget> IncludeTargets { get; set; }
    
        /// <summary>
        /// Gets or sets snoozeDurationInDays.
        /// Specifies the number of days that the user sees a prompt again if they select 'Not now' and snoozes the prompt. Minimum 0 days. Maximum: 14 days. If the value is '0' – The user is prompted during every MFA attempt.
        /// </summary>
        [JsonPropertyName("snoozeDurationInDays")]
        public Int32? SnoozeDurationInDays { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// Enable or disable the feature. Possible values are: default, enabled, disabled, unknownFutureValue. The default value is used when the configuration hasn't been explicitly set and uses the default behavior of Azure AD for the setting. The default value is disabled.
        /// </summary>
        [JsonPropertyName("state")]
        public AdvancedConfigState? State { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
