// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IMethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IReportRootGetOneDriveUsageAccountDetailRequest.
    /// </summary>
    public partial interface IReportRootGetOneDriveUsageAccountDetailRequest : IBaseRequest
    {


        /// <summary>
        /// Issues the GET request.
        /// </summary>
        System.Threading.Tasks.Task<IReportRootGetOneDriveUsageAccountDetailCollectionPage> GetAsync();
        
        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOneDriveUsageAccountDetailCollectionPage> GetAsync(
            CancellationToken cancellationToken);
  


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="onedriveusageaccountdetail">The OneDriveUsageAccountDetail object set with the properties to update.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOneDriveUsageAccountDetailCollectionPage> PatchAsync(OneDriveUsageAccountDetail onedriveusageaccountdetail);

        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="onedriveusageaccountdetail">The OneDriveUsageAccountDetail object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOneDriveUsageAccountDetailCollectionPage> PatchAsync(OneDriveUsageAccountDetail onedriveusageaccountdetail, 
            CancellationToken cancellationToken);
          

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="onedriveusageaccountdetail">The OneDriveUsageAccountDetail object to update.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOneDriveUsageAccountDetailCollectionPage> PutAsync(OneDriveUsageAccountDetail onedriveusageaccountdetail);

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="onedriveusageaccountdetail">The OneDriveUsageAccountDetail object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOneDriveUsageAccountDetailCollectionPage> PutAsync(OneDriveUsageAccountDetail onedriveusageaccountdetail, 
            CancellationToken cancellationToken);




        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOneDriveUsageAccountDetailRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOneDriveUsageAccountDetailRequest Select(string value);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOneDriveUsageAccountDetailRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOneDriveUsageAccountDetailRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOneDriveUsageAccountDetailRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOneDriveUsageAccountDetailRequest OrderBy(string value);
    }
}
