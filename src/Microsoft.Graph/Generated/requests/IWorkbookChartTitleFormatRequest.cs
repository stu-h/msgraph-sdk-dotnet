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
    /// The interface IWorkbookChartTitleFormatRequest.
    /// </summary>
    public partial interface IWorkbookChartTitleFormatRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartTitleFormat using POST.
        /// </summary>
        /// <param name="workbookChartTitleFormatToCreate">The WorkbookChartTitleFormat to create.</param>
        /// <returns>The created WorkbookChartTitleFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartTitleFormat> CreateAsync(WorkbookChartTitleFormat workbookChartTitleFormatToCreate);

        /// <summary>
        /// Creates the specified WorkbookChartTitleFormat using POST.
        /// </summary>
        /// <param name="workbookChartTitleFormatToCreate">The WorkbookChartTitleFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartTitleFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartTitleFormat> CreateAsync(WorkbookChartTitleFormat workbookChartTitleFormatToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified WorkbookChartTitleFormat using POST and returns a <see cref="GraphResponse{WorkbookChartTitleFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartTitleFormatToCreate">The WorkbookChartTitleFormat to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartTitleFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartTitleFormat>> CreateResponseAsync(WorkbookChartTitleFormat workbookChartTitleFormatToCreate);

        /// <summary>
        /// Creates the specified WorkbookChartTitleFormat using POST and returns a <see cref="GraphResponse{WorkbookChartTitleFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartTitleFormatToCreate">The WorkbookChartTitleFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartTitleFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartTitleFormat>> CreateResponseAsync(WorkbookChartTitleFormat workbookChartTitleFormatToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartTitleFormat.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartTitleFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartTitleFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartTitleFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartTitleFormat.
        /// </summary>
        /// <returns>The WorkbookChartTitleFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartTitleFormat> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartTitleFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartTitleFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartTitleFormat> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartTitleFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartTitleFormatToUpdate">The WorkbookChartTitleFormat to update.</param>
        /// <returns>The updated WorkbookChartTitleFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartTitleFormat> UpdateAsync(WorkbookChartTitleFormat workbookChartTitleFormatToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartTitleFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartTitleFormatToUpdate">The WorkbookChartTitleFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartTitleFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartTitleFormat> UpdateAsync(WorkbookChartTitleFormat workbookChartTitleFormatToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartTitleFormat using PATCH and returns a <see cref="GraphResponse{WorkbookChartTitleFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartTitleFormatToUpdate">The WorkbookChartTitleFormat to update.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartTitleFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartTitleFormat>> UpdateResponseAsync(WorkbookChartTitleFormat workbookChartTitleFormatToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartTitleFormat using PATCH and returns a <see cref="GraphResponse{WorkbookChartTitleFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartTitleFormatToUpdate">The WorkbookChartTitleFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookChartTitleFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartTitleFormat>> UpdateResponseAsync(WorkbookChartTitleFormat workbookChartTitleFormatToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartTitleFormatRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartTitleFormatRequest Expand(Expression<Func<WorkbookChartTitleFormat, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartTitleFormatRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartTitleFormatRequest Select(Expression<Func<WorkbookChartTitleFormat, object>> selectExpression);

    }
}
