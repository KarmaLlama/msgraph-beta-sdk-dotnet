// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IProfileRequestBuilder.
    /// </summary>
    public partial interface IProfileRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IProfileRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IProfileRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Account.
        /// </summary>
        /// <returns>The <see cref="IProfileAccountCollectionRequestBuilder"/>.</returns>
        IProfileAccountCollectionRequestBuilder Account { get; }

        /// <summary>
        /// Gets the request builder for Anniversaries.
        /// </summary>
        /// <returns>The <see cref="IProfileAnniversariesCollectionRequestBuilder"/>.</returns>
        IProfileAnniversariesCollectionRequestBuilder Anniversaries { get; }

        /// <summary>
        /// Gets the request builder for EducationalActivities.
        /// </summary>
        /// <returns>The <see cref="IProfileEducationalActivitiesCollectionRequestBuilder"/>.</returns>
        IProfileEducationalActivitiesCollectionRequestBuilder EducationalActivities { get; }

        /// <summary>
        /// Gets the request builder for Emails.
        /// </summary>
        /// <returns>The <see cref="IProfileEmailsCollectionRequestBuilder"/>.</returns>
        IProfileEmailsCollectionRequestBuilder Emails { get; }

        /// <summary>
        /// Gets the request builder for Interests.
        /// </summary>
        /// <returns>The <see cref="IProfileInterestsCollectionRequestBuilder"/>.</returns>
        IProfileInterestsCollectionRequestBuilder Interests { get; }

        /// <summary>
        /// Gets the request builder for Languages.
        /// </summary>
        /// <returns>The <see cref="IProfileLanguagesCollectionRequestBuilder"/>.</returns>
        IProfileLanguagesCollectionRequestBuilder Languages { get; }

        /// <summary>
        /// Gets the request builder for Names.
        /// </summary>
        /// <returns>The <see cref="IProfileNamesCollectionRequestBuilder"/>.</returns>
        IProfileNamesCollectionRequestBuilder Names { get; }

        /// <summary>
        /// Gets the request builder for Phones.
        /// </summary>
        /// <returns>The <see cref="IProfilePhonesCollectionRequestBuilder"/>.</returns>
        IProfilePhonesCollectionRequestBuilder Phones { get; }

        /// <summary>
        /// Gets the request builder for Positions.
        /// </summary>
        /// <returns>The <see cref="IProfilePositionsCollectionRequestBuilder"/>.</returns>
        IProfilePositionsCollectionRequestBuilder Positions { get; }

        /// <summary>
        /// Gets the request builder for Projects.
        /// </summary>
        /// <returns>The <see cref="IProfileProjectsCollectionRequestBuilder"/>.</returns>
        IProfileProjectsCollectionRequestBuilder Projects { get; }

        /// <summary>
        /// Gets the request builder for Skills.
        /// </summary>
        /// <returns>The <see cref="IProfileSkillsCollectionRequestBuilder"/>.</returns>
        IProfileSkillsCollectionRequestBuilder Skills { get; }

        /// <summary>
        /// Gets the request builder for WebAccounts.
        /// </summary>
        /// <returns>The <see cref="IProfileWebAccountsCollectionRequestBuilder"/>.</returns>
        IProfileWebAccountsCollectionRequestBuilder WebAccounts { get; }

        /// <summary>
        /// Gets the request builder for Websites.
        /// </summary>
        /// <returns>The <see cref="IProfileWebsitesCollectionRequestBuilder"/>.</returns>
        IProfileWebsitesCollectionRequestBuilder Websites { get; }
    
    }
}