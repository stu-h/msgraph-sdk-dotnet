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
    /// The interface IWorkbookRangeFillRequest.
    /// </summary>
    public partial interface IWorkbookRangeFillRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookRangeFill using POST.
        /// </summary>
        /// <param name="workbookRangeFillToCreate">The WorkbookRangeFill to create.</param>
        /// <returns>The created WorkbookRangeFill.</returns>
        System.Threading.Tasks.Task<WorkbookRangeFill> CreateAsync(WorkbookRangeFill workbookRangeFillToCreate);

        /// <summary>
        /// Creates the specified WorkbookRangeFill using POST.
        /// </summary>
        /// <param name="workbookRangeFillToCreate">The WorkbookRangeFill to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookRangeFill.</returns>
        System.Threading.Tasks.Task<WorkbookRangeFill> CreateAsync(WorkbookRangeFill workbookRangeFillToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified WorkbookRangeFill using POST and returns a <see cref="GraphResponse{WorkbookRangeFill}"/> object.
        /// </summary>
        /// <param name="workbookRangeFillToCreate">The WorkbookRangeFill to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFill}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFill>> CreateResponseAsync(WorkbookRangeFill workbookRangeFillToCreate);

        /// <summary>
        /// Creates the specified WorkbookRangeFill using POST and returns a <see cref="GraphResponse{WorkbookRangeFill}"/> object.
        /// </summary>
        /// <param name="workbookRangeFillToCreate">The WorkbookRangeFill to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFill}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFill>> CreateResponseAsync(WorkbookRangeFill workbookRangeFillToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookRangeFill.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookRangeFill.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookRangeFill and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified WorkbookRangeFill and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookRangeFill.
        /// </summary>
        /// <returns>The WorkbookRangeFill.</returns>
        System.Threading.Tasks.Task<WorkbookRangeFill> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookRangeFill.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookRangeFill.</returns>
        System.Threading.Tasks.Task<WorkbookRangeFill> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookRangeFill using PATCH.
        /// </summary>
        /// <param name="workbookRangeFillToUpdate">The WorkbookRangeFill to update.</param>
        /// <returns>The updated WorkbookRangeFill.</returns>
        System.Threading.Tasks.Task<WorkbookRangeFill> UpdateAsync(WorkbookRangeFill workbookRangeFillToUpdate);

        /// <summary>
        /// Updates the specified WorkbookRangeFill using PATCH.
        /// </summary>
        /// <param name="workbookRangeFillToUpdate">The WorkbookRangeFill to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookRangeFill.</returns>
        System.Threading.Tasks.Task<WorkbookRangeFill> UpdateAsync(WorkbookRangeFill workbookRangeFillToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookRangeFill using PATCH and returns a <see cref="GraphResponse{WorkbookRangeFill}"/> object.
        /// </summary>
        /// <param name="workbookRangeFillToUpdate">The WorkbookRangeFill to update.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFill}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFill>> UpdateResponseAsync(WorkbookRangeFill workbookRangeFillToUpdate);

        /// <summary>
        /// Updates the specified WorkbookRangeFill using PATCH and returns a <see cref="GraphResponse{WorkbookRangeFill}"/> object.
        /// </summary>
        /// <param name="workbookRangeFillToUpdate">The WorkbookRangeFill to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookRangeFill}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookRangeFill>> UpdateResponseAsync(WorkbookRangeFill workbookRangeFillToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeFillRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeFillRequest Expand(Expression<Func<WorkbookRangeFill, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeFillRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeFillRequest Select(Expression<Func<WorkbookRangeFill, object>> selectExpression);

    }
}
