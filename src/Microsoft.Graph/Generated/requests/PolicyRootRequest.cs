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
    /// The type PolicyRootRequest.
    /// </summary>
    public partial class PolicyRootRequest : BaseRequest, IPolicyRootRequest
    {
        /// <summary>
        /// Constructs a new PolicyRootRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PolicyRootRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified PolicyRoot using POST.
        /// </summary>
        /// <param name="policyRootToCreate">The PolicyRoot to create.</param>
        /// <returns>The created PolicyRoot.</returns>
        public System.Threading.Tasks.Task<PolicyRoot> CreateAsync(PolicyRoot policyRootToCreate)
        {
            return this.CreateAsync(policyRootToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified PolicyRoot using POST.
        /// </summary>
        /// <param name="policyRootToCreate">The PolicyRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PolicyRoot.</returns>
        public async System.Threading.Tasks.Task<PolicyRoot> CreateAsync(PolicyRoot policyRootToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<PolicyRoot>(policyRootToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified PolicyRoot using POST and returns a <see cref="GraphResponse{PolicyRoot}"/> object.
        /// </summary>
        /// <param name="policyRootToCreate">The PolicyRoot to create.</param>
        /// <returns>The <see cref="GraphResponse{PolicyRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PolicyRoot>> CreateResponseAsync(PolicyRoot policyRootToCreate)
        {
            return this.CreateResponseAsync(policyRootToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified PolicyRoot using POST and returns a <see cref="GraphResponse{PolicyRoot}"/> object.
        /// </summary>
        /// <param name="policyRootToCreate">The PolicyRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PolicyRoot}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<PolicyRoot>> CreateResponseAsync(PolicyRoot policyRootToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<PolicyRoot>(policyRootToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PolicyRoot.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified PolicyRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<PolicyRoot>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PolicyRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified PolicyRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified PolicyRoot.
        /// </summary>
        /// <returns>The PolicyRoot.</returns>
        public System.Threading.Tasks.Task<PolicyRoot> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified PolicyRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PolicyRoot.</returns>
        public async System.Threading.Tasks.Task<PolicyRoot> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<PolicyRoot>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified PolicyRoot using PATCH.
        /// </summary>
        /// <param name="policyRootToUpdate">The PolicyRoot to update.</param>
        /// <returns>The updated PolicyRoot.</returns>
        public System.Threading.Tasks.Task<PolicyRoot> UpdateAsync(PolicyRoot policyRootToUpdate)
        {
            return this.UpdateAsync(policyRootToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified PolicyRoot using PATCH.
        /// </summary>
        /// <param name="policyRootToUpdate">The PolicyRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PolicyRoot.</returns>
        public async System.Threading.Tasks.Task<PolicyRoot> UpdateAsync(PolicyRoot policyRootToUpdate, CancellationToken cancellationToken)
        {
			if (policyRootToUpdate.AdditionalData != null)
			{
				if (policyRootToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					policyRootToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, policyRootToUpdate.GetType().Name)
						});
				}
			}
            if (policyRootToUpdate.AdditionalData != null)
            {
                if (policyRootToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    policyRootToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, policyRootToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<PolicyRoot>(policyRootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified PolicyRoot using PATCH and returns a <see cref="GraphResponse{PolicyRoot}"/> object.
        /// </summary>
        /// <param name="policyRootToUpdate">The PolicyRoot to update.</param>
        /// <returns>The <see cref="GraphResponse{PolicyRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PolicyRoot>> UpdateResponseAsync(PolicyRoot policyRootToUpdate)
        {
            return this.UpdateResponseAsync(policyRootToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified PolicyRoot using PATCH and returns a <see cref="GraphResponse{PolicyRoot}"/> object.
        /// </summary>
        /// <param name="policyRootToUpdate">The PolicyRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PolicyRoot}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<PolicyRoot>> UpdateResponseAsync(PolicyRoot policyRootToUpdate, CancellationToken cancellationToken)
        {
			if (policyRootToUpdate.AdditionalData != null)
			{
				if (policyRootToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					policyRootToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, policyRootToUpdate.GetType().Name)
						});
				}
			}
            if (policyRootToUpdate.AdditionalData != null)
            {
                if (policyRootToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    policyRootToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, policyRootToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<PolicyRoot>(policyRootToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPolicyRootRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPolicyRootRequest Expand(Expression<Func<PolicyRoot, object>> expandExpression)
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
        public IPolicyRootRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPolicyRootRequest Select(Expression<Func<PolicyRoot, object>> selectExpression)
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
        /// <param name="policyRootToInitialize">The <see cref="PolicyRoot"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(PolicyRoot policyRootToInitialize)
        {

            if (policyRootToInitialize != null && policyRootToInitialize.AdditionalData != null)
            {

                if (policyRootToInitialize.ActivityBasedTimeoutPolicies != null && policyRootToInitialize.ActivityBasedTimeoutPolicies.CurrentPage != null)
                {
                    policyRootToInitialize.ActivityBasedTimeoutPolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    object nextPageLink;
                    policyRootToInitialize.AdditionalData.TryGetValue("activityBasedTimeoutPolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        policyRootToInitialize.ActivityBasedTimeoutPolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (policyRootToInitialize.ClaimsMappingPolicies != null && policyRootToInitialize.ClaimsMappingPolicies.CurrentPage != null)
                {
                    policyRootToInitialize.ClaimsMappingPolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    object nextPageLink;
                    policyRootToInitialize.AdditionalData.TryGetValue("claimsMappingPolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        policyRootToInitialize.ClaimsMappingPolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (policyRootToInitialize.HomeRealmDiscoveryPolicies != null && policyRootToInitialize.HomeRealmDiscoveryPolicies.CurrentPage != null)
                {
                    policyRootToInitialize.HomeRealmDiscoveryPolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    object nextPageLink;
                    policyRootToInitialize.AdditionalData.TryGetValue("homeRealmDiscoveryPolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        policyRootToInitialize.HomeRealmDiscoveryPolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (policyRootToInitialize.PermissionGrantPolicies != null && policyRootToInitialize.PermissionGrantPolicies.CurrentPage != null)
                {
                    policyRootToInitialize.PermissionGrantPolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    object nextPageLink;
                    policyRootToInitialize.AdditionalData.TryGetValue("permissionGrantPolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        policyRootToInitialize.PermissionGrantPolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (policyRootToInitialize.TokenIssuancePolicies != null && policyRootToInitialize.TokenIssuancePolicies.CurrentPage != null)
                {
                    policyRootToInitialize.TokenIssuancePolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    object nextPageLink;
                    policyRootToInitialize.AdditionalData.TryGetValue("tokenIssuancePolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        policyRootToInitialize.TokenIssuancePolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (policyRootToInitialize.TokenLifetimePolicies != null && policyRootToInitialize.TokenLifetimePolicies.CurrentPage != null)
                {
                    policyRootToInitialize.TokenLifetimePolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    object nextPageLink;
                    policyRootToInitialize.AdditionalData.TryGetValue("tokenLifetimePolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        policyRootToInitialize.TokenLifetimePolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (policyRootToInitialize.ConditionalAccessPolicies != null && policyRootToInitialize.ConditionalAccessPolicies.CurrentPage != null)
                {
                    policyRootToInitialize.ConditionalAccessPolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    object nextPageLink;
                    policyRootToInitialize.AdditionalData.TryGetValue("conditionalAccessPolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        policyRootToInitialize.ConditionalAccessPolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
