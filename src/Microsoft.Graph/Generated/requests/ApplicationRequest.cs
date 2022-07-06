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
    /// The type ApplicationRequest.
    /// </summary>
    public partial class ApplicationRequest : BaseRequest, IApplicationRequest
    {
        /// <summary>
        /// Constructs a new ApplicationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ApplicationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Application using POST.
        /// </summary>
        /// <param name="applicationToCreate">The Application to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Application.</returns>
        public async System.Threading.Tasks.Task<Application> CreateAsync(Application applicationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<Application>(applicationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Application using POST and returns a <see cref="GraphResponse{Application}"/> object.
        /// </summary>
        /// <param name="applicationToCreate">The Application to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Application}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Application>> CreateResponseAsync(Application applicationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Application>(applicationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Application.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<Application>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Application and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Application.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Application.</returns>
        public async System.Threading.Tasks.Task<Application> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<Application>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Application and returns a <see cref="GraphResponse{Application}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Application}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Application>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<Application>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Application using PATCH.
        /// </summary>
        /// <param name="applicationToUpdate">The Application to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Application.</returns>
        public async System.Threading.Tasks.Task<Application> UpdateAsync(Application applicationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<Application>(applicationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Application using PATCH and returns a <see cref="GraphResponse{Application}"/> object.
        /// </summary>
        /// <param name="applicationToUpdate">The Application to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Application}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Application>> UpdateResponseAsync(Application applicationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<Application>(applicationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Application using PUT.
        /// </summary>
        /// <param name="applicationToUpdate">The Application object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<Application> PutAsync(Application applicationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<Application>(applicationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Application using PUT and returns a <see cref="GraphResponse{Application}"/> object.
        /// </summary>
        /// <param name="applicationToUpdate">The Application object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{Application}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Application>> PutResponseAsync(Application applicationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<Application>(applicationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IApplicationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IApplicationRequest Expand(Expression<Func<Application, object>> expandExpression)
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
        public IApplicationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IApplicationRequest Select(Expression<Func<Application, object>> selectExpression)
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
        /// <param name="applicationToInitialize">The <see cref="Application"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Application applicationToInitialize)
        {

            if (applicationToInitialize != null)
            {
                if (applicationToInitialize.ExtensionProperties != null && applicationToInitialize.ExtensionProperties.CurrentPage != null)
                {
                    applicationToInitialize.ExtensionProperties.InitializeNextPageRequest(this.Client, applicationToInitialize.ExtensionPropertiesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    applicationToInitialize.ExtensionProperties.AdditionalData = applicationToInitialize.AdditionalData;
                }
                if (applicationToInitialize.FederatedIdentityCredentials != null && applicationToInitialize.FederatedIdentityCredentials.CurrentPage != null)
                {
                    applicationToInitialize.FederatedIdentityCredentials.InitializeNextPageRequest(this.Client, applicationToInitialize.FederatedIdentityCredentialsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    applicationToInitialize.FederatedIdentityCredentials.AdditionalData = applicationToInitialize.AdditionalData;
                }
                if (applicationToInitialize.HomeRealmDiscoveryPolicies != null && applicationToInitialize.HomeRealmDiscoveryPolicies.CurrentPage != null)
                {
                    applicationToInitialize.HomeRealmDiscoveryPolicies.InitializeNextPageRequest(this.Client, applicationToInitialize.HomeRealmDiscoveryPoliciesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    applicationToInitialize.HomeRealmDiscoveryPolicies.AdditionalData = applicationToInitialize.AdditionalData;
                }
                if (applicationToInitialize.Owners != null && applicationToInitialize.Owners.CurrentPage != null)
                {
                    applicationToInitialize.Owners.InitializeNextPageRequest(this.Client, applicationToInitialize.OwnersNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    applicationToInitialize.Owners.AdditionalData = applicationToInitialize.AdditionalData;
                }
                if (applicationToInitialize.TokenIssuancePolicies != null && applicationToInitialize.TokenIssuancePolicies.CurrentPage != null)
                {
                    applicationToInitialize.TokenIssuancePolicies.InitializeNextPageRequest(this.Client, applicationToInitialize.TokenIssuancePoliciesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    applicationToInitialize.TokenIssuancePolicies.AdditionalData = applicationToInitialize.AdditionalData;
                }
                if (applicationToInitialize.TokenLifetimePolicies != null && applicationToInitialize.TokenLifetimePolicies.CurrentPage != null)
                {
                    applicationToInitialize.TokenLifetimePolicies.InitializeNextPageRequest(this.Client, applicationToInitialize.TokenLifetimePoliciesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    applicationToInitialize.TokenLifetimePolicies.AdditionalData = applicationToInitialize.AdditionalData;
                }

            }


        }
    }
}
