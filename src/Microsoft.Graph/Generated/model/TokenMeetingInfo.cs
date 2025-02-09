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
    /// The type TokenMeetingInfo.
    /// </summary>
    public partial class TokenMeetingInfo : MeetingInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenMeetingInfo"/> class.
        /// </summary>
        public TokenMeetingInfo()
        {
            this.ODataType = "microsoft.graph.tokenMeetingInfo";
        }

        /// <summary>
        /// Gets or sets token.
        /// The token used to join the call.
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
    
    }
}
