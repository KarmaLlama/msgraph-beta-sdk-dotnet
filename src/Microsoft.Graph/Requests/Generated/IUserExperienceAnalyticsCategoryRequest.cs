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
    /// The interface IUserExperienceAnalyticsCategoryRequest.
    /// </summary>
    public partial interface IUserExperienceAnalyticsCategoryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserExperienceAnalyticsCategory using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsCategoryToCreate">The UserExperienceAnalyticsCategory to create.</param>
        /// <returns>The created UserExperienceAnalyticsCategory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsCategory> CreateAsync(UserExperienceAnalyticsCategory userExperienceAnalyticsCategoryToCreate);        /// <summary>
        /// Creates the specified UserExperienceAnalyticsCategory using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsCategoryToCreate">The UserExperienceAnalyticsCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsCategory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsCategory> CreateAsync(UserExperienceAnalyticsCategory userExperienceAnalyticsCategoryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsCategory.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsCategory.
        /// </summary>
        /// <returns>The UserExperienceAnalyticsCategory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsCategory> GetAsync();

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsCategory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsCategory> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsCategory using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsCategoryToUpdate">The UserExperienceAnalyticsCategory to update.</param>
        /// <returns>The updated UserExperienceAnalyticsCategory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsCategory> UpdateAsync(UserExperienceAnalyticsCategory userExperienceAnalyticsCategoryToUpdate);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsCategory using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsCategoryToUpdate">The UserExperienceAnalyticsCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsCategory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsCategory> UpdateAsync(UserExperienceAnalyticsCategory userExperienceAnalyticsCategoryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsCategoryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsCategoryRequest Expand(Expression<Func<UserExperienceAnalyticsCategory, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsCategoryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsCategoryRequest Select(Expression<Func<UserExperienceAnalyticsCategory, object>> selectExpression);

    }
}
