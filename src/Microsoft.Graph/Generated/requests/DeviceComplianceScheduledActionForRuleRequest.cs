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
    /// The type DeviceComplianceScheduledActionForRuleRequest.
    /// </summary>
    public partial class DeviceComplianceScheduledActionForRuleRequest : BaseRequest, IDeviceComplianceScheduledActionForRuleRequest
    {
        /// <summary>
        /// Constructs a new DeviceComplianceScheduledActionForRuleRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceComplianceScheduledActionForRuleRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceComplianceScheduledActionForRule using POST.
        /// </summary>
        /// <param name="deviceComplianceScheduledActionForRuleToCreate">The DeviceComplianceScheduledActionForRule to create.</param>
        /// <returns>The created DeviceComplianceScheduledActionForRule.</returns>
        public System.Threading.Tasks.Task<DeviceComplianceScheduledActionForRule> CreateAsync(DeviceComplianceScheduledActionForRule deviceComplianceScheduledActionForRuleToCreate)
        {
            return this.CreateAsync(deviceComplianceScheduledActionForRuleToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceComplianceScheduledActionForRule using POST.
        /// </summary>
        /// <param name="deviceComplianceScheduledActionForRuleToCreate">The DeviceComplianceScheduledActionForRule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceComplianceScheduledActionForRule.</returns>
        public async System.Threading.Tasks.Task<DeviceComplianceScheduledActionForRule> CreateAsync(DeviceComplianceScheduledActionForRule deviceComplianceScheduledActionForRuleToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceComplianceScheduledActionForRule>(deviceComplianceScheduledActionForRuleToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceComplianceScheduledActionForRule using POST and returns a <see cref="GraphResponse{DeviceComplianceScheduledActionForRule}"/> object.
        /// </summary>
        /// <param name="deviceComplianceScheduledActionForRuleToCreate">The DeviceComplianceScheduledActionForRule to create.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceScheduledActionForRule}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceComplianceScheduledActionForRule>> CreateResponseAsync(DeviceComplianceScheduledActionForRule deviceComplianceScheduledActionForRuleToCreate)
        {
            return this.CreateResponseAsync(deviceComplianceScheduledActionForRuleToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceComplianceScheduledActionForRule using POST and returns a <see cref="GraphResponse{DeviceComplianceScheduledActionForRule}"/> object.
        /// </summary>
        /// <param name="deviceComplianceScheduledActionForRuleToCreate">The DeviceComplianceScheduledActionForRule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceScheduledActionForRule}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceComplianceScheduledActionForRule>> CreateResponseAsync(DeviceComplianceScheduledActionForRule deviceComplianceScheduledActionForRuleToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<DeviceComplianceScheduledActionForRule>(deviceComplianceScheduledActionForRuleToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceComplianceScheduledActionForRule.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceComplianceScheduledActionForRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceComplianceScheduledActionForRule>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceComplianceScheduledActionForRule and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceComplianceScheduledActionForRule and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceComplianceScheduledActionForRule.
        /// </summary>
        /// <returns>The DeviceComplianceScheduledActionForRule.</returns>
        public System.Threading.Tasks.Task<DeviceComplianceScheduledActionForRule> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceComplianceScheduledActionForRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceComplianceScheduledActionForRule.</returns>
        public async System.Threading.Tasks.Task<DeviceComplianceScheduledActionForRule> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceComplianceScheduledActionForRule>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceComplianceScheduledActionForRule using PATCH.
        /// </summary>
        /// <param name="deviceComplianceScheduledActionForRuleToUpdate">The DeviceComplianceScheduledActionForRule to update.</param>
        /// <returns>The updated DeviceComplianceScheduledActionForRule.</returns>
        public System.Threading.Tasks.Task<DeviceComplianceScheduledActionForRule> UpdateAsync(DeviceComplianceScheduledActionForRule deviceComplianceScheduledActionForRuleToUpdate)
        {
            return this.UpdateAsync(deviceComplianceScheduledActionForRuleToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceComplianceScheduledActionForRule using PATCH.
        /// </summary>
        /// <param name="deviceComplianceScheduledActionForRuleToUpdate">The DeviceComplianceScheduledActionForRule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceComplianceScheduledActionForRule.</returns>
        public async System.Threading.Tasks.Task<DeviceComplianceScheduledActionForRule> UpdateAsync(DeviceComplianceScheduledActionForRule deviceComplianceScheduledActionForRuleToUpdate, CancellationToken cancellationToken)
        {
			if (deviceComplianceScheduledActionForRuleToUpdate.AdditionalData != null)
			{
				if (deviceComplianceScheduledActionForRuleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceComplianceScheduledActionForRuleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceComplianceScheduledActionForRuleToUpdate.GetType().Name)
						});
				}
			}
            if (deviceComplianceScheduledActionForRuleToUpdate.AdditionalData != null)
            {
                if (deviceComplianceScheduledActionForRuleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceComplianceScheduledActionForRuleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceComplianceScheduledActionForRuleToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceComplianceScheduledActionForRule>(deviceComplianceScheduledActionForRuleToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceComplianceScheduledActionForRule using PATCH and returns a <see cref="GraphResponse{DeviceComplianceScheduledActionForRule}"/> object.
        /// </summary>
        /// <param name="deviceComplianceScheduledActionForRuleToUpdate">The DeviceComplianceScheduledActionForRule to update.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceScheduledActionForRule}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceComplianceScheduledActionForRule>> UpdateResponseAsync(DeviceComplianceScheduledActionForRule deviceComplianceScheduledActionForRuleToUpdate)
        {
            return this.UpdateResponseAsync(deviceComplianceScheduledActionForRuleToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceComplianceScheduledActionForRule using PATCH and returns a <see cref="GraphResponse{DeviceComplianceScheduledActionForRule}"/> object.
        /// </summary>
        /// <param name="deviceComplianceScheduledActionForRuleToUpdate">The DeviceComplianceScheduledActionForRule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceComplianceScheduledActionForRule}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceComplianceScheduledActionForRule>> UpdateResponseAsync(DeviceComplianceScheduledActionForRule deviceComplianceScheduledActionForRuleToUpdate, CancellationToken cancellationToken)
        {
			if (deviceComplianceScheduledActionForRuleToUpdate.AdditionalData != null)
			{
				if (deviceComplianceScheduledActionForRuleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceComplianceScheduledActionForRuleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceComplianceScheduledActionForRuleToUpdate.GetType().Name)
						});
				}
			}
            if (deviceComplianceScheduledActionForRuleToUpdate.AdditionalData != null)
            {
                if (deviceComplianceScheduledActionForRuleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceComplianceScheduledActionForRuleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceComplianceScheduledActionForRuleToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<DeviceComplianceScheduledActionForRule>(deviceComplianceScheduledActionForRuleToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceComplianceScheduledActionForRuleRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceComplianceScheduledActionForRuleRequest Expand(Expression<Func<DeviceComplianceScheduledActionForRule, object>> expandExpression)
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
        public IDeviceComplianceScheduledActionForRuleRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceComplianceScheduledActionForRuleRequest Select(Expression<Func<DeviceComplianceScheduledActionForRule, object>> selectExpression)
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
        /// <param name="deviceComplianceScheduledActionForRuleToInitialize">The <see cref="DeviceComplianceScheduledActionForRule"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceComplianceScheduledActionForRule deviceComplianceScheduledActionForRuleToInitialize)
        {

            if (deviceComplianceScheduledActionForRuleToInitialize != null && deviceComplianceScheduledActionForRuleToInitialize.AdditionalData != null)
            {

                if (deviceComplianceScheduledActionForRuleToInitialize.ScheduledActionConfigurations != null && deviceComplianceScheduledActionForRuleToInitialize.ScheduledActionConfigurations.CurrentPage != null)
                {
                    deviceComplianceScheduledActionForRuleToInitialize.ScheduledActionConfigurations.AdditionalData = deviceComplianceScheduledActionForRuleToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceComplianceScheduledActionForRuleToInitialize.AdditionalData.TryGetValue("scheduledActionConfigurations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceComplianceScheduledActionForRuleToInitialize.ScheduledActionConfigurations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
