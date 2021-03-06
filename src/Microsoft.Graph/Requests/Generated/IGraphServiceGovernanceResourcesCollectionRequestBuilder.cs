// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGraphServiceGovernanceResourcesCollectionRequestBuilder.
    /// </summary>
    public partial interface IGraphServiceGovernanceResourcesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGraphServiceGovernanceResourcesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGraphServiceGovernanceResourcesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IGovernanceResourceRequestBuilder"/> for the specified GovernanceResource.
        /// </summary>
        /// <param name="id">The ID for the GovernanceResource.</param>
        /// <returns>The <see cref="IGovernanceResourceRequestBuilder"/>.</returns>
        IGovernanceResourceRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for GovernanceResourceRegister.
        /// </summary>
        /// <returns>The <see cref="IGovernanceResourceRegisterRequestBuilder"/>.</returns>
        IGovernanceResourceRegisterRequestBuilder Register(
            string externalId = null);
    }
}
