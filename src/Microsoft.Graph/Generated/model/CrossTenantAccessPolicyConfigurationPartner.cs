// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Cross Tenant Access Policy Configuration Partner.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CrossTenantAccessPolicyConfigurationPartner>))]
    public partial class CrossTenantAccessPolicyConfigurationPartner
    {
    
        /// <summary>
        /// Gets or sets b2b collaboration inbound.
        /// Defines your partner-specific configuration for users from other organizations accessing your resources via Azure AD B2B collaboration.
        /// </summary>
        [JsonPropertyName("b2bCollaborationInbound")]
        public CrossTenantAccessPolicyB2BSetting B2bCollaborationInbound { get; set; }
    
        /// <summary>
        /// Gets or sets b2b collaboration outbound.
        /// Defines your partner-specific configuration for users in your organization going outbound to access resources in another organization via Azure AD B2B collaboration.
        /// </summary>
        [JsonPropertyName("b2bCollaborationOutbound")]
        public CrossTenantAccessPolicyB2BSetting B2bCollaborationOutbound { get; set; }
    
        /// <summary>
        /// Gets or sets b2b direct connect inbound.
        /// Defines your partner-specific configuration for users from other organizations accessing your resources via Azure B2B direct connect.
        /// </summary>
        [JsonPropertyName("b2bDirectConnectInbound")]
        public CrossTenantAccessPolicyB2BSetting B2bDirectConnectInbound { get; set; }
    
        /// <summary>
        /// Gets or sets b2b direct connect outbound.
        /// Defines your partner-specific configuration for users in your organization going outbound to access resources in another organization via Azure AD B2B direct connect.
        /// </summary>
        [JsonPropertyName("b2bDirectConnectOutbound")]
        public CrossTenantAccessPolicyB2BSetting B2bDirectConnectOutbound { get; set; }
    
        /// <summary>
        /// Gets or sets inbound trust.
        /// Determines the partner-specific configuration for trusting other Conditional Access claims from external Azure AD organizations.
        /// </summary>
        [JsonPropertyName("inboundTrust")]
        public CrossTenantAccessPolicyInboundTrust InboundTrust { get; set; }
    
        /// <summary>
        /// Gets or sets is service provider.
        /// Identifies whether the partner-specific configuration is a Cloud Service Provider for your organization.
        /// </summary>
        [JsonPropertyName("isServiceProvider")]
        public bool? IsServiceProvider { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// The tenant identifier for the partner Azure AD organization. Read-only. Key.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

