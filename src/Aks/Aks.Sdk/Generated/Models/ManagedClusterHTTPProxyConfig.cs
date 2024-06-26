// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using System.Linq;

    /// <summary>
    /// Cluster HTTP proxy configuration.
    /// </summary>
    public partial class ManagedClusterHttpProxyConfig
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterHttpProxyConfig class.
        /// </summary>
        public ManagedClusterHttpProxyConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterHttpProxyConfig class.
        /// </summary>

        /// <param name="httpProxy">The HTTP proxy server endpoint to use.
        /// </param>

        /// <param name="httpsProxy">The HTTPS proxy server endpoint to use.
        /// </param>

        /// <param name="noProxy">The endpoints that should not go through proxy.
        /// </param>

        /// <param name="trustedCa">Alternative CA cert to use for connecting to proxy servers.
        /// </param>
        public ManagedClusterHttpProxyConfig(string httpProxy = default(string), string httpsProxy = default(string), System.Collections.Generic.IList<string> noProxy = default(System.Collections.Generic.IList<string>), string trustedCa = default(string))

        {
            this.HttpProxy = httpProxy;
            this.HttpsProxy = httpsProxy;
            this.NoProxy = noProxy;
            this.TrustedCa = trustedCa;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the HTTP proxy server endpoint to use.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "httpProxy")]
        public string HttpProxy {get; set; }

        /// <summary>
        /// Gets or sets the HTTPS proxy server endpoint to use.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "httpsProxy")]
        public string HttpsProxy {get; set; }

        /// <summary>
        /// Gets or sets the endpoints that should not go through proxy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "noProxy")]
        public System.Collections.Generic.IList<string> NoProxy {get; set; }

        /// <summary>
        /// Gets or sets alternative CA cert to use for connecting to proxy servers.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "trustedCa")]
        public string TrustedCa {get; set; }
    }
}