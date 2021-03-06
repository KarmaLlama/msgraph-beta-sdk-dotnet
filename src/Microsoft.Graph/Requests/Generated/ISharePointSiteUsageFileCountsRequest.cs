// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISharePointSiteUsageFileCountsRequest.
    /// </summary>
    public partial interface ISharePointSiteUsageFileCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SharePointSiteUsageFileCounts using POST.
        /// </summary>
        /// <param name="sharePointSiteUsageFileCountsToCreate">The SharePointSiteUsageFileCounts to create.</param>
        /// <returns>The created SharePointSiteUsageFileCounts.</returns>
        System.Threading.Tasks.Task<SharePointSiteUsageFileCounts> CreateAsync(SharePointSiteUsageFileCounts sharePointSiteUsageFileCountsToCreate);        /// <summary>
        /// Creates the specified SharePointSiteUsageFileCounts using POST.
        /// </summary>
        /// <param name="sharePointSiteUsageFileCountsToCreate">The SharePointSiteUsageFileCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SharePointSiteUsageFileCounts.</returns>
        System.Threading.Tasks.Task<SharePointSiteUsageFileCounts> CreateAsync(SharePointSiteUsageFileCounts sharePointSiteUsageFileCountsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SharePointSiteUsageFileCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SharePointSiteUsageFileCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SharePointSiteUsageFileCounts.
        /// </summary>
        /// <returns>The SharePointSiteUsageFileCounts.</returns>
        System.Threading.Tasks.Task<SharePointSiteUsageFileCounts> GetAsync();

        /// <summary>
        /// Gets the specified SharePointSiteUsageFileCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SharePointSiteUsageFileCounts.</returns>
        System.Threading.Tasks.Task<SharePointSiteUsageFileCounts> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SharePointSiteUsageFileCounts using PATCH.
        /// </summary>
        /// <param name="sharePointSiteUsageFileCountsToUpdate">The SharePointSiteUsageFileCounts to update.</param>
        /// <returns>The updated SharePointSiteUsageFileCounts.</returns>
        System.Threading.Tasks.Task<SharePointSiteUsageFileCounts> UpdateAsync(SharePointSiteUsageFileCounts sharePointSiteUsageFileCountsToUpdate);

        /// <summary>
        /// Updates the specified SharePointSiteUsageFileCounts using PATCH.
        /// </summary>
        /// <param name="sharePointSiteUsageFileCountsToUpdate">The SharePointSiteUsageFileCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SharePointSiteUsageFileCounts.</returns>
        System.Threading.Tasks.Task<SharePointSiteUsageFileCounts> UpdateAsync(SharePointSiteUsageFileCounts sharePointSiteUsageFileCountsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointSiteUsageFileCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointSiteUsageFileCountsRequest Expand(Expression<Func<SharePointSiteUsageFileCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointSiteUsageFileCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointSiteUsageFileCountsRequest Select(Expression<Func<SharePointSiteUsageFileCounts, object>> selectExpression);

    }
}
