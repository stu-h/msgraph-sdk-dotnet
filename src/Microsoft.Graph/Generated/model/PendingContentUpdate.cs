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
    /// The type PendingContentUpdate.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PendingContentUpdate>))]
    public partial class PendingContentUpdate
    {

        /// <summary>
        /// Gets or sets queuedDateTime.
        /// Date and time the pending binary operation was queued in UTC time. Read-only.
        /// </summary>
        [JsonPropertyName("queuedDateTime")]
        public DateTimeOffset? QueuedDateTime { get; set; }
    
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
