// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SKU of a load balancer.
    /// </summary>
    public partial class LoadBalancerSku
    {
        /// <summary>
        /// Initializes a new instance of the LoadBalancerSku class.
        /// </summary>
        public LoadBalancerSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LoadBalancerSku class.
        /// </summary>
        /// <param name="name">Name of a load balancer SKU. Possible values
        /// include: 'Basic', 'Standard', 'Gateway'</param>
        /// <param name="tier">Tier of a load balancer SKU. Possible values
        /// include: 'Regional', 'Global'</param>
        public LoadBalancerSku(string name = default(string), string tier = default(string))
        {
            Name = name;
            Tier = tier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of a load balancer SKU. Possible values include:
        /// 'Basic', 'Standard', 'Gateway'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets tier of a load balancer SKU. Possible values include:
        /// 'Regional', 'Global'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

    }
}
