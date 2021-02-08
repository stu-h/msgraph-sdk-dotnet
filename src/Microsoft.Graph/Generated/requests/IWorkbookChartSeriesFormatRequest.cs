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
    /// The interface IWorkbookChartSeriesFormatRequest.
    /// </summary>
    public partial interface IWorkbookChartSeriesFormatRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartSeriesFormat using POST.
        /// </summary>
        /// <param name="workbookChartSeriesFormatToCreate">The WorkbookChartSeriesFormat to create.</param>
        /// <returns>The created WorkbookChartSeriesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeriesFormat> CreateAsync(WorkbookChartSeriesFormat workbookChartSeriesFormatToCreate);

        /// <summary>
        /// Creates the specified WorkbookChartSeriesFormat using POST.
        /// </summary>
        /// <param name="workbookChartSeriesFormatToCreate">The WorkbookChartSeriesFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartSeriesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeriesFormat> CreateAsync(WorkbookChartSeriesFormat workbookChartSeriesFormatToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified WorkbookChartSeriesFormat using POST and returns a <see cref="GraphResponse{WorkbookChartSeriesFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartSeriesFormatToCreate">The WorkbookChartSeriesFormat to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartSeriesFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartSeriesFormat>> CreateResponseAsync(WorkbookChartSeriesFormat workbookChartSeriesFormatToCreate);

        /// <summary>
        /// Creates the specified WorkbookChartSeriesFormat using POST and returns a <see cref="GraphResponse{WorkbookChartSeriesFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartSeriesFormatToCreate">The WorkbookChartSeriesFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartSeriesFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartSeriesFormat>> CreateResponseAsync(WorkbookChartSeriesFormat workbookChartSeriesFormatToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartSeriesFormat.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartSeriesFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartSeriesFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartSeriesFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartSeriesFormat.
        /// </summary>
        /// <returns>The WorkbookChartSeriesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeriesFormat> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartSeriesFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartSeriesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeriesFormat> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartSeriesFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartSeriesFormatToUpdate">The WorkbookChartSeriesFormat to update.</param>
        /// <returns>The updated WorkbookChartSeriesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeriesFormat> UpdateAsync(WorkbookChartSeriesFormat workbookChartSeriesFormatToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartSeriesFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartSeriesFormatToUpdate">The WorkbookChartSeriesFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartSeriesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeriesFormat> UpdateAsync(WorkbookChartSeriesFormat workbookChartSeriesFormatToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartSeriesFormat using PATCH and returns a <see cref="GraphResponse{WorkbookChartSeriesFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartSeriesFormatToUpdate">The WorkbookChartSeriesFormat to update.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartSeriesFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartSeriesFormat>> UpdateResponseAsync(WorkbookChartSeriesFormat workbookChartSeriesFormatToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartSeriesFormat using PATCH and returns a <see cref="GraphResponse{WorkbookChartSeriesFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartSeriesFormatToUpdate">The WorkbookChartSeriesFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookChartSeriesFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartSeriesFormat>> UpdateResponseAsync(WorkbookChartSeriesFormat workbookChartSeriesFormatToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesFormatRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesFormatRequest Expand(Expression<Func<WorkbookChartSeriesFormat, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesFormatRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesFormatRequest Select(Expression<Func<WorkbookChartSeriesFormat, object>> selectExpression);

    }
}
