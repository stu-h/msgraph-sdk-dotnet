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
    /// The type UserFlowLanguageConfigurationRequest.
    /// </summary>
    public partial class UserFlowLanguageConfigurationRequest : BaseRequest, IUserFlowLanguageConfigurationRequest
    {
        /// <summary>
        /// Constructs a new UserFlowLanguageConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UserFlowLanguageConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UserFlowLanguageConfiguration using POST.
        /// </summary>
        /// <param name="userFlowLanguageConfigurationToCreate">The UserFlowLanguageConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserFlowLanguageConfiguration.</returns>
        public async System.Threading.Tasks.Task<UserFlowLanguageConfiguration> CreateAsync(UserFlowLanguageConfiguration userFlowLanguageConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<UserFlowLanguageConfiguration>(userFlowLanguageConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UserFlowLanguageConfiguration using POST and returns a <see cref="GraphResponse{UserFlowLanguageConfiguration}"/> object.
        /// </summary>
        /// <param name="userFlowLanguageConfigurationToCreate">The UserFlowLanguageConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserFlowLanguageConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserFlowLanguageConfiguration>> CreateResponseAsync(UserFlowLanguageConfiguration userFlowLanguageConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<UserFlowLanguageConfiguration>(userFlowLanguageConfigurationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified UserFlowLanguageConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<UserFlowLanguageConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UserFlowLanguageConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified UserFlowLanguageConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserFlowLanguageConfiguration.</returns>
        public async System.Threading.Tasks.Task<UserFlowLanguageConfiguration> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<UserFlowLanguageConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UserFlowLanguageConfiguration and returns a <see cref="GraphResponse{UserFlowLanguageConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserFlowLanguageConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserFlowLanguageConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<UserFlowLanguageConfiguration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UserFlowLanguageConfiguration using PATCH.
        /// </summary>
        /// <param name="userFlowLanguageConfigurationToUpdate">The UserFlowLanguageConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserFlowLanguageConfiguration.</returns>
        public async System.Threading.Tasks.Task<UserFlowLanguageConfiguration> UpdateAsync(UserFlowLanguageConfiguration userFlowLanguageConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<UserFlowLanguageConfiguration>(userFlowLanguageConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UserFlowLanguageConfiguration using PATCH and returns a <see cref="GraphResponse{UserFlowLanguageConfiguration}"/> object.
        /// </summary>
        /// <param name="userFlowLanguageConfigurationToUpdate">The UserFlowLanguageConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserFlowLanguageConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserFlowLanguageConfiguration>> UpdateResponseAsync(UserFlowLanguageConfiguration userFlowLanguageConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<UserFlowLanguageConfiguration>(userFlowLanguageConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UserFlowLanguageConfiguration using PUT.
        /// </summary>
        /// <param name="userFlowLanguageConfigurationToUpdate">The UserFlowLanguageConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<UserFlowLanguageConfiguration> PutAsync(UserFlowLanguageConfiguration userFlowLanguageConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<UserFlowLanguageConfiguration>(userFlowLanguageConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UserFlowLanguageConfiguration using PUT and returns a <see cref="GraphResponse{UserFlowLanguageConfiguration}"/> object.
        /// </summary>
        /// <param name="userFlowLanguageConfigurationToUpdate">The UserFlowLanguageConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{UserFlowLanguageConfiguration}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserFlowLanguageConfiguration>> PutResponseAsync(UserFlowLanguageConfiguration userFlowLanguageConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<UserFlowLanguageConfiguration>(userFlowLanguageConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserFlowLanguageConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUserFlowLanguageConfigurationRequest Expand(Expression<Func<UserFlowLanguageConfiguration, object>> expandExpression)
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
        public IUserFlowLanguageConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUserFlowLanguageConfigurationRequest Select(Expression<Func<UserFlowLanguageConfiguration, object>> selectExpression)
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
        /// <param name="userFlowLanguageConfigurationToInitialize">The <see cref="UserFlowLanguageConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UserFlowLanguageConfiguration userFlowLanguageConfigurationToInitialize)
        {

            if (userFlowLanguageConfigurationToInitialize != null)
            {
                if (userFlowLanguageConfigurationToInitialize.DefaultPages != null && userFlowLanguageConfigurationToInitialize.DefaultPages.CurrentPage != null)
                {
                    userFlowLanguageConfigurationToInitialize.DefaultPages.InitializeNextPageRequest(this.Client, userFlowLanguageConfigurationToInitialize.DefaultPagesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userFlowLanguageConfigurationToInitialize.DefaultPages.AdditionalData = userFlowLanguageConfigurationToInitialize.AdditionalData;
                }
                if (userFlowLanguageConfigurationToInitialize.OverridesPages != null && userFlowLanguageConfigurationToInitialize.OverridesPages.CurrentPage != null)
                {
                    userFlowLanguageConfigurationToInitialize.OverridesPages.InitializeNextPageRequest(this.Client, userFlowLanguageConfigurationToInitialize.OverridesPagesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    userFlowLanguageConfigurationToInitialize.OverridesPages.AdditionalData = userFlowLanguageConfigurationToInitialize.AdditionalData;
                }

            }


        }
    }
}
