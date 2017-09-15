// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApplicationInsights.Management.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApplicationInsights;
    using Microsoft.Azure.Management.ApplicationInsights.Management;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A container holding only the Tags for a resource, allowing the user to
    /// update the tags on a WebTest instance.
    /// </summary>
    public partial class TagsResource
    {
        /// <summary>
        /// Initializes a new instance of the TagsResource class.
        /// </summary>
        public TagsResource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TagsResource class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        public TagsResource(IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
