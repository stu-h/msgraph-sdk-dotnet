// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsGamma_InvRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsGamma_InvRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsGamma_InvRequest>, IWorkbookFunctionsGamma_InvRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsGamma_InvRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="probability">A probability parameter for the OData method call.</param>
        /// <param name="alpha">A alpha parameter for the OData method call.</param>
        /// <param name="beta">A beta parameter for the OData method call.</param>
        public WorkbookFunctionsGamma_InvRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument probability,
            System.Text.Json.JsonDocument alpha,
            System.Text.Json.JsonDocument beta)
            : base(requestUrl, client)
        {
            this.SetParameter("probability", probability, true);
            this.SetParameter("alpha", alpha, true);
            this.SetParameter("beta", beta, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsGamma_InvRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsGamma_InvRequest(functionUrl, this.Client, options);

            if (this.HasParameter("probability"))
            {
                request.RequestBody.Probability = this.GetParameter<System.Text.Json.JsonDocument>("probability");
            }

            if (this.HasParameter("alpha"))
            {
                request.RequestBody.Alpha = this.GetParameter<System.Text.Json.JsonDocument>("alpha");
            }

            if (this.HasParameter("beta"))
            {
                request.RequestBody.Beta = this.GetParameter<System.Text.Json.JsonDocument>("beta");
            }

            return request;
        }
    }
}
