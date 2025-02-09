// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsCountIfRequestBody.
    /// </summary>
    public partial class WorkbookFunctionsCountIfRequestBody
    {
    
        /// <summary>
        /// Gets or sets Range.
        /// </summary>
        [JsonPropertyName("range")]
        public System.Text.Json.JsonDocument Range { get; set; }
    
        /// <summary>
        /// Gets or sets Criteria.
        /// </summary>
        [JsonPropertyName("criteria")]
        public System.Text.Json.JsonDocument Criteria { get; set; }
    
    }
}
