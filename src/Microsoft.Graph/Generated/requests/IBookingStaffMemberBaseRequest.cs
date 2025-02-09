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
    /// The interface IBookingStaffMemberBaseRequest.
    /// </summary>
    public partial interface IBookingStaffMemberBaseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified BookingStaffMemberBase using POST.
        /// </summary>
        /// <param name="bookingStaffMemberBaseToCreate">The BookingStaffMemberBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BookingStaffMemberBase.</returns>
        System.Threading.Tasks.Task<BookingStaffMemberBase> CreateAsync(BookingStaffMemberBase bookingStaffMemberBaseToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified BookingStaffMemberBase using POST and returns a <see cref="GraphResponse{BookingStaffMemberBase}"/> object.
        /// </summary>
        /// <param name="bookingStaffMemberBaseToCreate">The BookingStaffMemberBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BookingStaffMemberBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BookingStaffMemberBase>> CreateResponseAsync(BookingStaffMemberBase bookingStaffMemberBaseToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified BookingStaffMemberBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified BookingStaffMemberBase and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified BookingStaffMemberBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BookingStaffMemberBase.</returns>
        System.Threading.Tasks.Task<BookingStaffMemberBase> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified BookingStaffMemberBase and returns a <see cref="GraphResponse{BookingStaffMemberBase}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BookingStaffMemberBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BookingStaffMemberBase>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified BookingStaffMemberBase using PATCH.
        /// </summary>
        /// <param name="bookingStaffMemberBaseToUpdate">The BookingStaffMemberBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated BookingStaffMemberBase.</returns>
        System.Threading.Tasks.Task<BookingStaffMemberBase> UpdateAsync(BookingStaffMemberBase bookingStaffMemberBaseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified BookingStaffMemberBase using PATCH and returns a <see cref="GraphResponse{BookingStaffMemberBase}"/> object.
        /// </summary>
        /// <param name="bookingStaffMemberBaseToUpdate">The BookingStaffMemberBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{BookingStaffMemberBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BookingStaffMemberBase>> UpdateResponseAsync(BookingStaffMemberBase bookingStaffMemberBaseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified BookingStaffMemberBase using PUT.
        /// </summary>
        /// <param name="bookingStaffMemberBaseToUpdate">The BookingStaffMemberBase object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<BookingStaffMemberBase> PutAsync(BookingStaffMemberBase bookingStaffMemberBaseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified BookingStaffMemberBase using PUT and returns a <see cref="GraphResponse{BookingStaffMemberBase}"/> object.
        /// </summary>
        /// <param name="bookingStaffMemberBaseToUpdate">The BookingStaffMemberBase object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{BookingStaffMemberBase}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<BookingStaffMemberBase>> PutResponseAsync(BookingStaffMemberBase bookingStaffMemberBaseToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IBookingStaffMemberBaseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IBookingStaffMemberBaseRequest Expand(Expression<Func<BookingStaffMemberBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IBookingStaffMemberBaseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IBookingStaffMemberBaseRequest Select(Expression<Func<BookingStaffMemberBase, object>> selectExpression);

    }
}
