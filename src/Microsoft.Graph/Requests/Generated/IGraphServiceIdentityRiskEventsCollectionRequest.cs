// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IGraphServiceIdentityRiskEventsCollectionRequest.
    /// </summary>
    public partial interface IGraphServiceIdentityRiskEventsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified IdentityRiskEvent to the collection via POST.
        /// </summary>
        /// <param name="identityRiskEvent">The IdentityRiskEvent to add.</param>
        /// <returns>The created IdentityRiskEvent.</returns>
        System.Threading.Tasks.Task<IdentityRiskEvent> AddAsync(IdentityRiskEvent identityRiskEvent);

        /// <summary>
        /// Adds the specified IdentityRiskEvent to the collection via POST.
        /// </summary>
        /// <param name="identityRiskEvent">The IdentityRiskEvent to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IdentityRiskEvent.</returns>
        System.Threading.Tasks.Task<IdentityRiskEvent> AddAsync(IdentityRiskEvent identityRiskEvent, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IGraphServiceIdentityRiskEventsCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IGraphServiceIdentityRiskEventsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceIdentityRiskEventsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceIdentityRiskEventsCollectionRequest Expand(Expression<Func<IdentityRiskEvent, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceIdentityRiskEventsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceIdentityRiskEventsCollectionRequest Select(Expression<Func<IdentityRiskEvent, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceIdentityRiskEventsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceIdentityRiskEventsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceIdentityRiskEventsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceIdentityRiskEventsCollectionRequest OrderBy(string value);
    }
}
