// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type TodoTaskRequestBuilder.
    /// </summary>
    public partial class TodoTaskRequestBuilder : EntityRequestBuilder, ITodoTaskRequestBuilder
    {

        /// <summary>
        /// Constructs a new TodoTaskRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public TodoTaskRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ITodoTaskRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ITodoTaskRequest Request(IEnumerable<Option> options)
        {
            return new TodoTaskRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for ChecklistItems.
        /// </summary>
        /// <returns>The <see cref="ITodoTaskChecklistItemsCollectionRequestBuilder"/>.</returns>
        public ITodoTaskChecklistItemsCollectionRequestBuilder ChecklistItems
        {
            get
            {
                return new TodoTaskChecklistItemsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("checklistItems"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Extensions.
        /// </summary>
        /// <returns>The <see cref="ITodoTaskExtensionsCollectionRequestBuilder"/>.</returns>
        public ITodoTaskExtensionsCollectionRequestBuilder Extensions
        {
            get
            {
                return new TodoTaskExtensionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("extensions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for LinkedResources.
        /// </summary>
        /// <returns>The <see cref="ITodoTaskLinkedResourcesCollectionRequestBuilder"/>.</returns>
        public ITodoTaskLinkedResourcesCollectionRequestBuilder LinkedResources
        {
            get
            {
                return new TodoTaskLinkedResourcesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("linkedResources"), this.Client);
            }
        }
    
        
    
    }
}
