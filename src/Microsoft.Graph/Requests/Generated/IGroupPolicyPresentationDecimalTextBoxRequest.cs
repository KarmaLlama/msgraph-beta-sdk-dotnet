// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IGroupPolicyPresentationDecimalTextBoxRequest.
    /// </summary>
    public partial interface IGroupPolicyPresentationDecimalTextBoxRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GroupPolicyPresentationDecimalTextBox using PUT.
        /// </summary>
        /// <param name="groupPolicyPresentationDecimalTextBoxToCreate">The GroupPolicyPresentationDecimalTextBox to create.</param>
        /// <returns>The created GroupPolicyPresentationDecimalTextBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationDecimalTextBox> CreateAsync(GroupPolicyPresentationDecimalTextBox groupPolicyPresentationDecimalTextBoxToCreate);        /// <summary>
        /// Creates the specified GroupPolicyPresentationDecimalTextBox using PUT.
        /// </summary>
        /// <param name="groupPolicyPresentationDecimalTextBoxToCreate">The GroupPolicyPresentationDecimalTextBox to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyPresentationDecimalTextBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationDecimalTextBox> CreateAsync(GroupPolicyPresentationDecimalTextBox groupPolicyPresentationDecimalTextBoxToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationDecimalTextBox.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationDecimalTextBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GroupPolicyPresentationDecimalTextBox.
        /// </summary>
        /// <returns>The GroupPolicyPresentationDecimalTextBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationDecimalTextBox> GetAsync();

        /// <summary>
        /// Gets the specified GroupPolicyPresentationDecimalTextBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyPresentationDecimalTextBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationDecimalTextBox> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GroupPolicyPresentationDecimalTextBox using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationDecimalTextBoxToUpdate">The GroupPolicyPresentationDecimalTextBox to update.</param>
        /// <returns>The updated GroupPolicyPresentationDecimalTextBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationDecimalTextBox> UpdateAsync(GroupPolicyPresentationDecimalTextBox groupPolicyPresentationDecimalTextBoxToUpdate);

        /// <summary>
        /// Updates the specified GroupPolicyPresentationDecimalTextBox using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationDecimalTextBoxToUpdate">The GroupPolicyPresentationDecimalTextBox to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated GroupPolicyPresentationDecimalTextBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationDecimalTextBox> UpdateAsync(GroupPolicyPresentationDecimalTextBox groupPolicyPresentationDecimalTextBoxToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationDecimalTextBoxRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationDecimalTextBoxRequest Expand(Expression<Func<GroupPolicyPresentationDecimalTextBox, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationDecimalTextBoxRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationDecimalTextBoxRequest Select(Expression<Func<GroupPolicyPresentationDecimalTextBox, object>> selectExpression);

    }
}