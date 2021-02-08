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
    /// The interface IWorkbookChartSeriesRequest.
    /// </summary>
    public partial interface IWorkbookChartSeriesRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartSeries using POST.
        /// </summary>
        /// <param name="workbookChartSeriesToCreate">The WorkbookChartSeries to create.</param>
        /// <returns>The created WorkbookChartSeries.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeries> CreateAsync(WorkbookChartSeries workbookChartSeriesToCreate);

        /// <summary>
        /// Creates the specified WorkbookChartSeries using POST.
        /// </summary>
        /// <param name="workbookChartSeriesToCreate">The WorkbookChartSeries to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartSeries.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeries> CreateAsync(WorkbookChartSeries workbookChartSeriesToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Creates the specified WorkbookChartSeries using POST and returns a <see cref="GraphResponse{WorkbookChartSeries}"/> object.
        /// </summary>
        /// <param name="workbookChartSeriesToCreate">The WorkbookChartSeries to create.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartSeries}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartSeries>> CreateResponseAsync(WorkbookChartSeries workbookChartSeriesToCreate);

        /// <summary>
        /// Creates the specified WorkbookChartSeries using POST and returns a <see cref="GraphResponse{WorkbookChartSeries}"/> object.
        /// </summary>
        /// <param name="workbookChartSeriesToCreate">The WorkbookChartSeries to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartSeries}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartSeries>> CreateResponseAsync(WorkbookChartSeries workbookChartSeriesToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartSeries.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartSeries.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartSeries and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartSeries and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartSeries.
        /// </summary>
        /// <returns>The WorkbookChartSeries.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeries> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartSeries.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartSeries.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeries> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartSeries using PATCH.
        /// </summary>
        /// <param name="workbookChartSeriesToUpdate">The WorkbookChartSeries to update.</param>
        /// <returns>The updated WorkbookChartSeries.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeries> UpdateAsync(WorkbookChartSeries workbookChartSeriesToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartSeries using PATCH.
        /// </summary>
        /// <param name="workbookChartSeriesToUpdate">The WorkbookChartSeries to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartSeries.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeries> UpdateAsync(WorkbookChartSeries workbookChartSeriesToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartSeries using PATCH and returns a <see cref="GraphResponse{WorkbookChartSeries}"/> object.
        /// </summary>
        /// <param name="workbookChartSeriesToUpdate">The WorkbookChartSeries to update.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartSeries}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartSeries>> UpdateResponseAsync(WorkbookChartSeries workbookChartSeriesToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartSeries using PATCH and returns a <see cref="GraphResponse{WorkbookChartSeries}"/> object.
        /// </summary>
        /// <param name="workbookChartSeriesToUpdate">The WorkbookChartSeries to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookChartSeries}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartSeries>> UpdateResponseAsync(WorkbookChartSeries workbookChartSeriesToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesRequest Expand(Expression<Func<WorkbookChartSeries, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesRequest Select(Expression<Func<WorkbookChartSeries, object>> selectExpression);

    }
}
