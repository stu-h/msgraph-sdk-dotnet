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
    /// The type DeviceRequest.
    /// </summary>
    public partial class DeviceRequest : BaseRequest, IDeviceRequest
    {
        /// <summary>
        /// Constructs a new DeviceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Device using POST.
        /// </summary>
        /// <param name="deviceToCreate">The Device to create.</param>
        /// <returns>The created Device.</returns>
        public System.Threading.Tasks.Task<Device> CreateAsync(Device deviceToCreate)
        {
            return this.CreateAsync(deviceToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Device using POST.
        /// </summary>
        /// <param name="deviceToCreate">The Device to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Device.</returns>
        public async System.Threading.Tasks.Task<Device> CreateAsync(Device deviceToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Device>(deviceToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Device.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Device.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Device>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Device.
        /// </summary>
        /// <returns>The Device.</returns>
        public System.Threading.Tasks.Task<Device> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Device.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Device.</returns>
        public async System.Threading.Tasks.Task<Device> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Device>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Device using PATCH.
        /// </summary>
        /// <param name="deviceToUpdate">The Device to update.</param>
        /// <returns>The updated Device.</returns>
        public System.Threading.Tasks.Task<Device> UpdateAsync(Device deviceToUpdate)
        {
            return this.UpdateAsync(deviceToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Device using PATCH.
        /// </summary>
        /// <param name="deviceToUpdate">The Device to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Device.</returns>
        public async System.Threading.Tasks.Task<Device> UpdateAsync(Device deviceToUpdate, CancellationToken cancellationToken)
        {
			if (deviceToUpdate.AdditionalData != null)
			{
				if (deviceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					deviceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceToUpdate.GetType().Name)
						});
				}
			}
            if (deviceToUpdate.AdditionalData != null)
            {
                if (deviceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Device>(deviceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceRequest Expand(Expression<Func<Device, object>> expandExpression)
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
        public IDeviceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceRequest Select(Expression<Func<Device, object>> selectExpression)
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
        /// <param name="deviceToInitialize">The <see cref="Device"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Device deviceToInitialize)
        {

            if (deviceToInitialize != null && deviceToInitialize.AdditionalData != null)
            {

                if (deviceToInitialize.MemberOf != null && deviceToInitialize.MemberOf.CurrentPage != null)
                {
                    deviceToInitialize.MemberOf.AdditionalData = deviceToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceToInitialize.AdditionalData.TryGetValue("memberOf@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceToInitialize.MemberOf.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceToInitialize.RegisteredOwners != null && deviceToInitialize.RegisteredOwners.CurrentPage != null)
                {
                    deviceToInitialize.RegisteredOwners.AdditionalData = deviceToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceToInitialize.AdditionalData.TryGetValue("registeredOwners@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceToInitialize.RegisteredOwners.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceToInitialize.RegisteredUsers != null && deviceToInitialize.RegisteredUsers.CurrentPage != null)
                {
                    deviceToInitialize.RegisteredUsers.AdditionalData = deviceToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceToInitialize.AdditionalData.TryGetValue("registeredUsers@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceToInitialize.RegisteredUsers.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceToInitialize.TransitiveMemberOf != null && deviceToInitialize.TransitiveMemberOf.CurrentPage != null)
                {
                    deviceToInitialize.TransitiveMemberOf.AdditionalData = deviceToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceToInitialize.AdditionalData.TryGetValue("transitiveMemberOf@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceToInitialize.TransitiveMemberOf.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceToInitialize.Extensions != null && deviceToInitialize.Extensions.CurrentPage != null)
                {
                    deviceToInitialize.Extensions.AdditionalData = deviceToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceToInitialize.AdditionalData.TryGetValue("extensions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceToInitialize.Extensions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
