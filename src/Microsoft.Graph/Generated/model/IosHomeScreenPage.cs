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
    /// The type IosHomeScreenPage.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IosHomeScreenPage>))]
    public partial class IosHomeScreenPage
    {

        /// <summary>
        /// Gets or sets displayName.
        /// Name of the page
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets icons.
        /// A list of apps, folders, and web clips to appear on a page. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("icons")]
        public IEnumerable<IosHomeScreenItem> Icons { get; set; }
    
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
