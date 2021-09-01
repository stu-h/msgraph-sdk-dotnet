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
    /// The type SortProperty.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SortProperty>))]
    public partial class SortProperty
    {

        /// <summary>
        /// Gets or sets isDescending.
        /// True if the sort order is descending. Default is false, with the sort order as ascending. Optional.
        /// </summary>
        [JsonPropertyName("isDescending")]
        public bool? IsDescending { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The name of the property to sort on. Required.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
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
