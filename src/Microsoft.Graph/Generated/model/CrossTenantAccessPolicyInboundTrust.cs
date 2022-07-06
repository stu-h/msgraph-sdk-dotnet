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
    /// The type CrossTenantAccessPolicyInboundTrust.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CrossTenantAccessPolicyInboundTrust>))]
    public partial class CrossTenantAccessPolicyInboundTrust
    {

        /// <summary>
        /// Gets or sets isCompliantDeviceAccepted.
        /// Specifies whether compliant devices from external Azure AD organizations are trusted.
        /// </summary>
        [JsonPropertyName("isCompliantDeviceAccepted")]
        public bool? IsCompliantDeviceAccepted { get; set; }
    
        /// <summary>
        /// Gets or sets isHybridAzureADJoinedDeviceAccepted.
        /// Specifies whether hybrid Azure AD joined devices from external Azure AD organizations are trusted.
        /// </summary>
        [JsonPropertyName("isHybridAzureADJoinedDeviceAccepted")]
        public bool? IsHybridAzureADJoinedDeviceAccepted { get; set; }
    
        /// <summary>
        /// Gets or sets isMfaAccepted.
        /// Specifies whether MFA from external Azure AD organizations is trusted.
        /// </summary>
        [JsonPropertyName("isMfaAccepted")]
        public bool? IsMfaAccepted { get; set; }
    
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
