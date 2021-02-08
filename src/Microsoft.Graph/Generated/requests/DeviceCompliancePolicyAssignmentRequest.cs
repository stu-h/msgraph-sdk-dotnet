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
    /// The type DeviceCompliancePolicyAssignmentRequest.
    /// </summary>
    public partial class DeviceCompliancePolicyAssignmentRequest : BaseRequest, IDeviceCompliancePolicyAssignmentRequest
    {
        /// <summary>
        /// Constructs a new DeviceCompliancePolicyAssignmentRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceCompliancePolicyAssignmentRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceCompliancePolicyAssignment using POST.
        /// </summary>
        /// <param name="deviceCompliancePolicyAssignmentToCreate">The DeviceCompliancePolicyAssignment to create.</param>
        /// <returns>The created DeviceCompliancePolicyAssignment.</returns>
        public System.Threading.Tasks.Task<DeviceCompliancePolicyAssignment> CreateAsync(DeviceCompliancePolicyAssignment deviceCompliancePolicyAssignmentToCreate)
        {
            return this.CreateAsync(deviceCompliancePolicyAssignmentToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceCompliancePolicyAssignment using POST.
        /// </summary>
        /// <param name="deviceCompliancePolicyAssignmentToCreate">The DeviceCompliancePolicyAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceCompliancePolicyAssignment.</returns>
        public async System.Threading.Tasks.Task<DeviceCompliancePolicyAssignment> CreateAsync(DeviceCompliancePolicyAssignment deviceCompliancePolicyAssignmentToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceCompliancePolicyAssignment>(deviceCompliancePolicyAssignmentToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceCompliancePolicyAssignment using POST and returns a <see cref="GraphResponse{DeviceCompliancePolicyAssignment}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicyAssignmentToCreate">The DeviceCompliancePolicyAssignment to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicyAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicyAssignment>> CreateResponseAsync(DeviceCompliancePolicyAssignment deviceCompliancePolicyAssignmentToCreate)
        {
            return this.CreateResponseAsync(deviceCompliancePolicyAssignmentToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceCompliancePolicyAssignment using POST and returns a <see cref="GraphResponse{DeviceCompliancePolicyAssignment}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicyAssignmentToCreate">The DeviceCompliancePolicyAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicyAssignment}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicyAssignment>> CreateResponseAsync(DeviceCompliancePolicyAssignment deviceCompliancePolicyAssignmentToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<DeviceCompliancePolicyAssignment>(deviceCompliancePolicyAssignmentToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicyAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicyAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceCompliancePolicyAssignment>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicyAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicyAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceCompliancePolicyAssignment.
        /// </summary>
        /// <returns>The DeviceCompliancePolicyAssignment.</returns>
        public System.Threading.Tasks.Task<DeviceCompliancePolicyAssignment> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceCompliancePolicyAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceCompliancePolicyAssignment.</returns>
        public async System.Threading.Tasks.Task<DeviceCompliancePolicyAssignment> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceCompliancePolicyAssignment>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceCompliancePolicyAssignment using PATCH.
        /// </summary>
        /// <param name="deviceCompliancePolicyAssignmentToUpdate">The DeviceCompliancePolicyAssignment to update.</param>
        /// <returns>The updated DeviceCompliancePolicyAssignment.</returns>
        public System.Threading.Tasks.Task<DeviceCompliancePolicyAssignment> UpdateAsync(DeviceCompliancePolicyAssignment deviceCompliancePolicyAssignmentToUpdate)
        {
            return this.UpdateAsync(deviceCompliancePolicyAssignmentToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceCompliancePolicyAssignment using PATCH.
        /// </summary>
        /// <param name="deviceCompliancePolicyAssignmentToUpdate">The DeviceCompliancePolicyAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceCompliancePolicyAssignment.</returns>
        public async System.Threading.Tasks.Task<DeviceCompliancePolicyAssignment> UpdateAsync(DeviceCompliancePolicyAssignment deviceCompliancePolicyAssignmentToUpdate, CancellationToken cancellationToken)
        {
			if (deviceCompliancePolicyAssignmentToUpdate.AdditionalData != null)
			{
				if (deviceCompliancePolicyAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceCompliancePolicyAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceCompliancePolicyAssignmentToUpdate.GetType().Name)
						});
				}
			}
            if (deviceCompliancePolicyAssignmentToUpdate.AdditionalData != null)
            {
                if (deviceCompliancePolicyAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceCompliancePolicyAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceCompliancePolicyAssignmentToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceCompliancePolicyAssignment>(deviceCompliancePolicyAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceCompliancePolicyAssignment using PATCH and returns a <see cref="GraphResponse{DeviceCompliancePolicyAssignment}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicyAssignmentToUpdate">The DeviceCompliancePolicyAssignment to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicyAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicyAssignment>> UpdateResponseAsync(DeviceCompliancePolicyAssignment deviceCompliancePolicyAssignmentToUpdate)
        {
            return this.UpdateResponseAsync(deviceCompliancePolicyAssignmentToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceCompliancePolicyAssignment using PATCH and returns a <see cref="GraphResponse{DeviceCompliancePolicyAssignment}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicyAssignmentToUpdate">The DeviceCompliancePolicyAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicyAssignment}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicyAssignment>> UpdateResponseAsync(DeviceCompliancePolicyAssignment deviceCompliancePolicyAssignmentToUpdate, CancellationToken cancellationToken)
        {
			if (deviceCompliancePolicyAssignmentToUpdate.AdditionalData != null)
			{
				if (deviceCompliancePolicyAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceCompliancePolicyAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceCompliancePolicyAssignmentToUpdate.GetType().Name)
						});
				}
			}
            if (deviceCompliancePolicyAssignmentToUpdate.AdditionalData != null)
            {
                if (deviceCompliancePolicyAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceCompliancePolicyAssignmentToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceCompliancePolicyAssignmentToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<DeviceCompliancePolicyAssignment>(deviceCompliancePolicyAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCompliancePolicyAssignmentRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCompliancePolicyAssignmentRequest Expand(Expression<Func<DeviceCompliancePolicyAssignment, object>> expandExpression)
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
        public IDeviceCompliancePolicyAssignmentRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCompliancePolicyAssignmentRequest Select(Expression<Func<DeviceCompliancePolicyAssignment, object>> selectExpression)
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
        /// <param name="deviceCompliancePolicyAssignmentToInitialize">The <see cref="DeviceCompliancePolicyAssignment"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceCompliancePolicyAssignment deviceCompliancePolicyAssignmentToInitialize)
        {

        }
    }
}
