// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Application gateway BackendHealth pool.
    /// </summary>
    public partial class ApplicationGatewayBackendHealthPool
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHealthPool class.
        /// </summary>
        public ApplicationGatewayBackendHealthPool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHealthPool class.
        /// </summary>
        /// <param name="backendAddressPool">Reference of an
        /// ApplicationGatewayBackendAddressPool resource.</param>
        /// <param name="backendHttpSettingsCollection">List of
        /// ApplicationGatewayBackendHealthHttpSettings resources.</param>
        public ApplicationGatewayBackendHealthPool(SubResource backendAddressPool = default(SubResource), IList<ApplicationGatewayBackendHealthHttpSettings> backendHttpSettingsCollection = default(IList<ApplicationGatewayBackendHealthHttpSettings>))
        {
            BackendAddressPool = backendAddressPool;
            BackendHttpSettingsCollection = backendHttpSettingsCollection;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reference of an ApplicationGatewayBackendAddressPool
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "backendAddressPool")]
        public SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// Gets or sets list of ApplicationGatewayBackendHealthHttpSettings
        /// resources.
        /// </summary>
        [JsonProperty(PropertyName = "backendHttpSettingsCollection")]
        public IList<ApplicationGatewayBackendHealthHttpSettings> BackendHttpSettingsCollection { get; set; }

    }
}
