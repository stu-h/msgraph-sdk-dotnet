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
    /// The type Windows10EndpointProtectionConfigurationRequest.
    /// </summary>
    public partial class Windows10EndpointProtectionConfigurationRequest : BaseRequest, IWindows10EndpointProtectionConfigurationRequest
    {
        /// <summary>
        /// Constructs a new Windows10EndpointProtectionConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public Windows10EndpointProtectionConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Windows10EndpointProtectionConfiguration using POST.
        /// </summary>
        /// <param name="windows10EndpointProtectionConfigurationToCreate">The Windows10EndpointProtectionConfiguration to create.</param>
        /// <returns>The created Windows10EndpointProtectionConfiguration.</returns>
        public System.Threading.Tasks.Task<Windows10EndpointProtectionConfiguration> CreateAsync(Windows10EndpointProtectionConfiguration windows10EndpointProtectionConfigurationToCreate)
        {
            return this.CreateAsync(windows10EndpointProtectionConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Windows10EndpointProtectionConfiguration using POST.
        /// </summary>
        /// <param name="windows10EndpointProtectionConfigurationToCreate">The Windows10EndpointProtectionConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10EndpointProtectionConfiguration.</returns>
        public async System.Threading.Tasks.Task<Windows10EndpointProtectionConfiguration> CreateAsync(Windows10EndpointProtectionConfiguration windows10EndpointProtectionConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Windows10EndpointProtectionConfiguration>(windows10EndpointProtectionConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Windows10EndpointProtectionConfiguration using POST and returns a <see cref="GraphResponse{Windows10EndpointProtectionConfiguration}"/> object.
        /// </summary>
        /// <param name="windows10EndpointProtectionConfigurationToCreate">The Windows10EndpointProtectionConfiguration to create.</param>
        /// <returns>The <see cref="GraphResponse{Windows10EndpointProtectionConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Windows10EndpointProtectionConfiguration>> CreateResponseAsync(Windows10EndpointProtectionConfiguration windows10EndpointProtectionConfigurationToCreate)
        {
            return this.CreateResponseAsync(windows10EndpointProtectionConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Windows10EndpointProtectionConfiguration using POST and returns a <see cref="GraphResponse{Windows10EndpointProtectionConfiguration}"/> object.
        /// </summary>
        /// <param name="windows10EndpointProtectionConfigurationToCreate">The Windows10EndpointProtectionConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows10EndpointProtectionConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Windows10EndpointProtectionConfiguration>> CreateResponseAsync(Windows10EndpointProtectionConfiguration windows10EndpointProtectionConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<Windows10EndpointProtectionConfiguration>(windows10EndpointProtectionConfigurationToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Windows10EndpointProtectionConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Windows10EndpointProtectionConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Windows10EndpointProtectionConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Windows10EndpointProtectionConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Windows10EndpointProtectionConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Windows10EndpointProtectionConfiguration.
        /// </summary>
        /// <returns>The Windows10EndpointProtectionConfiguration.</returns>
        public System.Threading.Tasks.Task<Windows10EndpointProtectionConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Windows10EndpointProtectionConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10EndpointProtectionConfiguration.</returns>
        public async System.Threading.Tasks.Task<Windows10EndpointProtectionConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Windows10EndpointProtectionConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Windows10EndpointProtectionConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10EndpointProtectionConfigurationToUpdate">The Windows10EndpointProtectionConfiguration to update.</param>
        /// <returns>The updated Windows10EndpointProtectionConfiguration.</returns>
        public System.Threading.Tasks.Task<Windows10EndpointProtectionConfiguration> UpdateAsync(Windows10EndpointProtectionConfiguration windows10EndpointProtectionConfigurationToUpdate)
        {
            return this.UpdateAsync(windows10EndpointProtectionConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Windows10EndpointProtectionConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10EndpointProtectionConfigurationToUpdate">The Windows10EndpointProtectionConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10EndpointProtectionConfiguration.</returns>
        public async System.Threading.Tasks.Task<Windows10EndpointProtectionConfiguration> UpdateAsync(Windows10EndpointProtectionConfiguration windows10EndpointProtectionConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (windows10EndpointProtectionConfigurationToUpdate.AdditionalData != null)
			{
				if (windows10EndpointProtectionConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					windows10EndpointProtectionConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windows10EndpointProtectionConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (windows10EndpointProtectionConfigurationToUpdate.AdditionalData != null)
            {
                if (windows10EndpointProtectionConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    windows10EndpointProtectionConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windows10EndpointProtectionConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Windows10EndpointProtectionConfiguration>(windows10EndpointProtectionConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Windows10EndpointProtectionConfiguration using PATCH and returns a <see cref="GraphResponse{Windows10EndpointProtectionConfiguration}"/> object.
        /// </summary>
        /// <param name="windows10EndpointProtectionConfigurationToUpdate">The Windows10EndpointProtectionConfiguration to update.</param>
        /// <returns>The <see cref="GraphResponse{Windows10EndpointProtectionConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Windows10EndpointProtectionConfiguration>> UpdateResponseAsync(Windows10EndpointProtectionConfiguration windows10EndpointProtectionConfigurationToUpdate)
        {
            return this.UpdateResponseAsync(windows10EndpointProtectionConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Windows10EndpointProtectionConfiguration using PATCH and returns a <see cref="GraphResponse{Windows10EndpointProtectionConfiguration}"/> object.
        /// </summary>
        /// <param name="windows10EndpointProtectionConfigurationToUpdate">The Windows10EndpointProtectionConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Windows10EndpointProtectionConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Windows10EndpointProtectionConfiguration>> UpdateResponseAsync(Windows10EndpointProtectionConfiguration windows10EndpointProtectionConfigurationToUpdate, CancellationToken cancellationToken)
        {
			if (windows10EndpointProtectionConfigurationToUpdate.AdditionalData != null)
			{
				if (windows10EndpointProtectionConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					windows10EndpointProtectionConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windows10EndpointProtectionConfigurationToUpdate.GetType().Name)
						});
				}
			}
            if (windows10EndpointProtectionConfigurationToUpdate.AdditionalData != null)
            {
                if (windows10EndpointProtectionConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    windows10EndpointProtectionConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windows10EndpointProtectionConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<Windows10EndpointProtectionConfiguration>(windows10EndpointProtectionConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10EndpointProtectionConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10EndpointProtectionConfigurationRequest Expand(Expression<Func<Windows10EndpointProtectionConfiguration, object>> expandExpression)
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
        public IWindows10EndpointProtectionConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10EndpointProtectionConfigurationRequest Select(Expression<Func<Windows10EndpointProtectionConfiguration, object>> selectExpression)
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
        /// <param name="windows10EndpointProtectionConfigurationToInitialize">The <see cref="Windows10EndpointProtectionConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Windows10EndpointProtectionConfiguration windows10EndpointProtectionConfigurationToInitialize)
        {

        }
    }
}
