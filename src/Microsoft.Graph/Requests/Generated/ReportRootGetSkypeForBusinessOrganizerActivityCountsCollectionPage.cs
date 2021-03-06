// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    /// <summary>
    /// The type ReportRootGetSkypeForBusinessOrganizerActivityCountsCollectionPage.
    /// </summary>
    public partial class ReportRootGetSkypeForBusinessOrganizerActivityCountsCollectionPage : CollectionPage<SkypeForBusinessOrganizerActivityCounts>, IReportRootGetSkypeForBusinessOrganizerActivityCountsCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IReportRootGetSkypeForBusinessOrganizerActivityCountsRequest"/> instance.
        /// </summary>
        public IReportRootGetSkypeForBusinessOrganizerActivityCountsRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new ReportRootGetSkypeForBusinessOrganizerActivityCountsRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
