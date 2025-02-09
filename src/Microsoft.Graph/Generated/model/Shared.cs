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
    /// The type Shared.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Shared>))]
    public partial class Shared
    {

        /// <summary>
        /// Gets or sets owner.
        /// The identity of the owner of the shared item. Read-only.
        /// </summary>
        [JsonPropertyName("owner")]
        public IdentitySet Owner { get; set; }
    
        /// <summary>
        /// Gets or sets scope.
        /// Indicates the scope of how the item is shared: anonymous, organization, or users. Read-only.
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }
    
        /// <summary>
        /// Gets or sets sharedBy.
        /// The identity of the user who shared the item. Read-only.
        /// </summary>
        [JsonPropertyName("sharedBy")]
        public IdentitySet SharedBy { get; set; }
    
        /// <summary>
        /// Gets or sets sharedDateTime.
        /// The UTC date and time when the item was shared. Read-only.
        /// </summary>
        [JsonPropertyName("sharedDateTime")]
        public DateTimeOffset? SharedDateTime { get; set; }
    
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
