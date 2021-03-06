// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The resource tags.
    /// </summary>
    public partial class PSResourceTags
    {
        /// <summary>
        /// Initializes a new instance of the PSResourceTags class.
        /// </summary>
        public PSResourceTags()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PSResourceTags class.
        /// </summary>
        /// <param name="tags">Gets or sets the tags, a dictionary of
        /// descriptors arm object</param>
        public PSResourceTags(IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the tags, a dictionary of descriptors arm object
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
