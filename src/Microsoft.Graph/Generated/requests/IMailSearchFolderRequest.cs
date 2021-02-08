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
    /// The interface IMailSearchFolderRequest.
    /// </summary>
    public partial interface IMailSearchFolderRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MailSearchFolder using POST.
        /// </summary>
        /// <param name="mailSearchFolderToCreate">The MailSearchFolder to create.</param>
        /// <returns>The created MailSearchFolder.</returns>
        System.Threading.Tasks.Task<MailSearchFolder> CreateAsync(MailSearchFolder mailSearchFolderToCreate);

        /// <summary>
        /// Creates the specified MailSearchFolder using POST.
        /// </summary>
        /// <param name="mailSearchFolderToCreate">The MailSearchFolder to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MailSearchFolder.</returns>
        System.Threading.Tasks.Task<MailSearchFolder> CreateAsync(MailSearchFolder mailSearchFolderToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified MailSearchFolder using POST and returns a <see cref="GraphResponse{MailSearchFolder}"/> object.
        /// </summary>
        /// <param name="mailSearchFolderToCreate">The MailSearchFolder to create.</param>
        /// <returns>The <see cref="GraphResponse{MailSearchFolder}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MailSearchFolder>> CreateResponseAsync(MailSearchFolder mailSearchFolderToCreate);

        /// <summary>
        /// Creates the specified MailSearchFolder using POST and returns a <see cref="GraphResponse{MailSearchFolder}"/> object.
        /// </summary>
        /// <param name="mailSearchFolderToCreate">The MailSearchFolder to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MailSearchFolder}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MailSearchFolder>> CreateResponseAsync(MailSearchFolder mailSearchFolderToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MailSearchFolder.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MailSearchFolder.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MailSearchFolder and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified MailSearchFolder and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MailSearchFolder.
        /// </summary>
        /// <returns>The MailSearchFolder.</returns>
        System.Threading.Tasks.Task<MailSearchFolder> GetAsync();

        /// <summary>
        /// Gets the specified MailSearchFolder.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MailSearchFolder.</returns>
        System.Threading.Tasks.Task<MailSearchFolder> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MailSearchFolder using PATCH.
        /// </summary>
        /// <param name="mailSearchFolderToUpdate">The MailSearchFolder to update.</param>
        /// <returns>The updated MailSearchFolder.</returns>
        System.Threading.Tasks.Task<MailSearchFolder> UpdateAsync(MailSearchFolder mailSearchFolderToUpdate);

        /// <summary>
        /// Updates the specified MailSearchFolder using PATCH.
        /// </summary>
        /// <param name="mailSearchFolderToUpdate">The MailSearchFolder to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MailSearchFolder.</returns>
        System.Threading.Tasks.Task<MailSearchFolder> UpdateAsync(MailSearchFolder mailSearchFolderToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MailSearchFolder using PATCH and returns a <see cref="GraphResponse{MailSearchFolder}"/> object.
        /// </summary>
        /// <param name="mailSearchFolderToUpdate">The MailSearchFolder to update.</param>
        /// <returns>The <see cref="GraphResponse{MailSearchFolder}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MailSearchFolder>> UpdateResponseAsync(MailSearchFolder mailSearchFolderToUpdate);

        /// <summary>
        /// Updates the specified MailSearchFolder using PATCH and returns a <see cref="GraphResponse{MailSearchFolder}"/> object.
        /// </summary>
        /// <param name="mailSearchFolderToUpdate">The MailSearchFolder to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MailSearchFolder}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MailSearchFolder>> UpdateResponseAsync(MailSearchFolder mailSearchFolderToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMailSearchFolderRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMailSearchFolderRequest Expand(Expression<Func<MailSearchFolder, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMailSearchFolderRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMailSearchFolderRequest Select(Expression<Func<MailSearchFolder, object>> selectExpression);

    }
}
