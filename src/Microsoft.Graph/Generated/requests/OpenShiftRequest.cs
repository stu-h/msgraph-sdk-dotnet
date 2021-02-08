// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type OpenShiftRequest.
    /// </summary>
    public partial class OpenShiftRequest : BaseRequest, IOpenShiftRequest
    {
        /// <summary>
        /// Constructs a new OpenShiftRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OpenShiftRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OpenShift using POST.
        /// </summary>
        /// <param name="openShiftToCreate">The OpenShift to create.</param>
        /// <returns>The created OpenShift.</returns>
        public System.Threading.Tasks.Task<OpenShift> CreateAsync(OpenShift openShiftToCreate)
        {
            return this.CreateAsync(openShiftToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OpenShift using POST.
        /// </summary>
        /// <param name="openShiftToCreate">The OpenShift to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OpenShift.</returns>
        public async System.Threading.Tasks.Task<OpenShift> CreateAsync(OpenShift openShiftToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<OpenShift>(openShiftToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified OpenShift using POST and returns a <see cref="GraphResponse{OpenShift}"/> object.
        /// </summary>
        /// <param name="openShiftToCreate">The OpenShift to create.</param>
        /// <returns>The <see cref="GraphResponse{OpenShift}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OpenShift>> CreateResponseAsync(OpenShift openShiftToCreate)
        {
            return this.CreateResponseAsync(openShiftToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified OpenShift using POST and returns a <see cref="GraphResponse{OpenShift}"/> object.
        /// </summary>
        /// <param name="openShiftToCreate">The OpenShift to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OpenShift}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<OpenShift>> CreateResponseAsync(OpenShift openShiftToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<OpenShift>(openShiftToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OpenShift.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OpenShift.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<OpenShift>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OpenShift and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified OpenShift and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified OpenShift.
        /// </summary>
        /// <returns>The OpenShift.</returns>
        public System.Threading.Tasks.Task<OpenShift> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified OpenShift.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OpenShift.</returns>
        public async System.Threading.Tasks.Task<OpenShift> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<OpenShift>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified OpenShift using PATCH.
        /// </summary>
        /// <param name="openShiftToUpdate">The OpenShift to update.</param>
        /// <returns>The updated OpenShift.</returns>
        public System.Threading.Tasks.Task<OpenShift> UpdateAsync(OpenShift openShiftToUpdate)
        {
            return this.UpdateAsync(openShiftToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified OpenShift using PATCH.
        /// </summary>
        /// <param name="openShiftToUpdate">The OpenShift to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OpenShift.</returns>
        public async System.Threading.Tasks.Task<OpenShift> UpdateAsync(OpenShift openShiftToUpdate, CancellationToken cancellationToken)
        {
			if (openShiftToUpdate.AdditionalData != null)
			{
				if (openShiftToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					openShiftToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, openShiftToUpdate.GetType().Name)
						});
				}
			}
            if (openShiftToUpdate.AdditionalData != null)
            {
                if (openShiftToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    openShiftToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, openShiftToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<OpenShift>(openShiftToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified OpenShift using PATCH and returns a <see cref="GraphResponse{OpenShift}"/> object.
        /// </summary>
        /// <param name="openShiftToUpdate">The OpenShift to update.</param>
        /// <returns>The <see cref="GraphResponse{OpenShift}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OpenShift>> UpdateResponseAsync(OpenShift openShiftToUpdate)
        {
            return this.UpdateResponseAsync(openShiftToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified OpenShift using PATCH and returns a <see cref="GraphResponse{OpenShift}"/> object.
        /// </summary>
        /// <param name="openShiftToUpdate">The OpenShift to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OpenShift}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<OpenShift>> UpdateResponseAsync(OpenShift openShiftToUpdate, CancellationToken cancellationToken)
        {
			if (openShiftToUpdate.AdditionalData != null)
			{
				if (openShiftToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					openShiftToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, openShiftToUpdate.GetType().Name)
						});
				}
			}
            if (openShiftToUpdate.AdditionalData != null)
            {
                if (openShiftToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    openShiftToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, openShiftToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<OpenShift>(openShiftToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOpenShiftRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOpenShiftRequest Expand(Expression<Func<OpenShift, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IOpenShiftRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOpenShiftRequest Select(Expression<Func<OpenShift, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="openShiftToInitialize">The <see cref="OpenShift"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OpenShift openShiftToInitialize)
        {

        }
    }
}
