// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IEdiscoveryCaseSettingsRequestBuilder.
    /// </summary>
    public partial interface IEdiscoveryCaseSettingsRequestBuilder : Microsoft.Graph.IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IEdiscoveryCaseSettingsRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IEdiscoveryCaseSettingsRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for EdiscoveryCaseSettingsResetToDefault.
        /// </summary>
        /// <returns>The <see cref="IEdiscoveryCaseSettingsResetToDefaultRequestBuilder"/>.</returns>
        IEdiscoveryCaseSettingsResetToDefaultRequestBuilder ResetToDefault();
    
    }
}
