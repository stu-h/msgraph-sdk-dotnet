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
    /// The type WindowsDefenderScanActionResult.
    /// </summary>
    public partial class WindowsDefenderScanActionResult : DeviceActionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsDefenderScanActionResult"/> class.
        /// </summary>
        public WindowsDefenderScanActionResult()
        {
            this.ODataType = "microsoft.graph.windowsDefenderScanActionResult";
        }

        /// <summary>
        /// Gets or sets scanType.
        /// Scan type either full scan or quick scan
        /// </summary>
        [JsonPropertyName("scanType")]
        public string ScanType { get; set; }
    
    }
}
