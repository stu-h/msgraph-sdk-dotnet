// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IMobileAppContentFileRequest.
    /// </summary>
    public partial interface IMobileAppContentFileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MobileAppContentFile using POST.
        /// </summary>
        /// <param name="mobileAppContentFileToCreate">The MobileAppContentFile to create.</param>
        /// <returns>The created MobileAppContentFile.</returns>
        System.Threading.Tasks.Task<MobileAppContentFile> CreateAsync(MobileAppContentFile mobileAppContentFileToCreate);

        /// <summary>
        /// Creates the specified MobileAppContentFile using POST.
        /// </summary>
        /// <param name="mobileAppContentFileToCreate">The MobileAppContentFile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileAppContentFile.</returns>
        System.Threading.Tasks.Task<MobileAppContentFile> CreateAsync(MobileAppContentFile mobileAppContentFileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified MobileAppContentFile using POST and returns a <see cref="GraphResponse{MobileAppContentFile}"/> object.
        /// </summary>
        /// <param name="mobileAppContentFileToCreate">The MobileAppContentFile to create.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppContentFile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileAppContentFile>> CreateResponseAsync(MobileAppContentFile mobileAppContentFileToCreate);

        /// <summary>
        /// Creates the specified MobileAppContentFile using POST and returns a <see cref="GraphResponse{MobileAppContentFile}"/> object.
        /// </summary>
        /// <param name="mobileAppContentFileToCreate">The MobileAppContentFile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppContentFile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileAppContentFile>> CreateResponseAsync(MobileAppContentFile mobileAppContentFileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MobileAppContentFile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MobileAppContentFile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MobileAppContentFile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified MobileAppContentFile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MobileAppContentFile.
        /// </summary>
        /// <returns>The MobileAppContentFile.</returns>
        System.Threading.Tasks.Task<MobileAppContentFile> GetAsync();

        /// <summary>
        /// Gets the specified MobileAppContentFile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MobileAppContentFile.</returns>
        System.Threading.Tasks.Task<MobileAppContentFile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MobileAppContentFile using PATCH.
        /// </summary>
        /// <param name="mobileAppContentFileToUpdate">The MobileAppContentFile to update.</param>
        /// <returns>The updated MobileAppContentFile.</returns>
        System.Threading.Tasks.Task<MobileAppContentFile> UpdateAsync(MobileAppContentFile mobileAppContentFileToUpdate);

        /// <summary>
        /// Updates the specified MobileAppContentFile using PATCH.
        /// </summary>
        /// <param name="mobileAppContentFileToUpdate">The MobileAppContentFile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MobileAppContentFile.</returns>
        System.Threading.Tasks.Task<MobileAppContentFile> UpdateAsync(MobileAppContentFile mobileAppContentFileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MobileAppContentFile using PATCH and returns a <see cref="GraphResponse{MobileAppContentFile}"/> object.
        /// </summary>
        /// <param name="mobileAppContentFileToUpdate">The MobileAppContentFile to update.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppContentFile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileAppContentFile>> UpdateResponseAsync(MobileAppContentFile mobileAppContentFileToUpdate);

        /// <summary>
        /// Updates the specified MobileAppContentFile using PATCH and returns a <see cref="GraphResponse{MobileAppContentFile}"/> object.
        /// </summary>
        /// <param name="mobileAppContentFileToUpdate">The MobileAppContentFile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MobileAppContentFile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileAppContentFile>> UpdateResponseAsync(MobileAppContentFile mobileAppContentFileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppContentFileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppContentFileRequest Expand(Expression<Func<MobileAppContentFile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppContentFileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppContentFileRequest Select(Expression<Func<MobileAppContentFile, object>> selectExpression);

    }
}
