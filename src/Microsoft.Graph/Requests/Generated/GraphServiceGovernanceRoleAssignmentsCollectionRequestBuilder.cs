// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceGovernanceRoleAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceGovernanceRoleAssignmentsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceGovernanceRoleAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceGovernanceRoleAssignmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceGovernanceRoleAssignmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceGovernanceRoleAssignmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceGovernanceRoleAssignmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceGovernanceRoleAssignmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IGovernanceRoleAssignmentRequestBuilder"/> for the specified GraphServiceGovernanceRoleAssignment.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceGovernanceRoleAssignment.</param>
        /// <returns>The <see cref="IGovernanceRoleAssignmentRequestBuilder"/>.</returns>
        public IGovernanceRoleAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new GovernanceRoleAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for GovernanceRoleAssignmentExport.
        /// </summary>
        /// <returns>The <see cref="IGovernanceRoleAssignmentExportRequestBuilder"/>.</returns>
        public IGovernanceRoleAssignmentExportRequestBuilder Export()
        {
            return new GovernanceRoleAssignmentExportRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.export"),
                this.Client);
        }
    }
}
