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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Mail Search Folder.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MailSearchFolder : MailFolder
    {
    
		///<summary>
		/// The MailSearchFolder constructor
		///</summary>
        public MailSearchFolder()
        {
            this.ODataType = "microsoft.graph.mailSearchFolder";
        }
	
        /// <summary>
        /// Gets or sets filter query.
        /// The OData query to filter the messages.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "filterQuery", Required = Newtonsoft.Json.Required.Default)]
        public string FilterQuery { get; set; }
    
        /// <summary>
        /// Gets or sets include nested folders.
        /// Indicates how the mailbox folder hierarchy should be traversed in the search. true means that a deep search should be done to include child folders in the hierarchy of each folder explicitly specified in sourceFolderIds. false means a shallow search of only each of the folders explicitly specified in sourceFolderIds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "includeNestedFolders", Required = Newtonsoft.Json.Required.Default)]
        public bool? IncludeNestedFolders { get; set; }
    
        /// <summary>
        /// Gets or sets is supported.
        /// Indicates whether a search folder is editable using REST APIs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isSupported", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsSupported { get; set; }
    
        /// <summary>
        /// Gets or sets source folder ids.
        /// The mailbox folders that should be mined.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceFolderIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> SourceFolderIds { get; set; }
    
    }
}

