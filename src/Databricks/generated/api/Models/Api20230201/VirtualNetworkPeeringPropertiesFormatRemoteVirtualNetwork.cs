// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Extensions;

    /// <summary>
    /// The remote virtual network should be in the same region. See here to learn more (https://learn.microsoft.com/en-us/azure/databricks/administration-guide/cloud-configurations/azure/vnet-peering).
    /// </summary>
    public partial class VirtualNetworkPeeringPropertiesFormatRemoteVirtualNetwork :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IVirtualNetworkPeeringPropertiesFormatRemoteVirtualNetwork,
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Models.Api20230201.IVirtualNetworkPeeringPropertiesFormatRemoteVirtualNetworkInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The Id of the remote virtual network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Databricks.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>
        /// Creates an new <see cref="VirtualNetworkPeeringPropertiesFormatRemoteVirtualNetwork" /> instance.
        /// </summary>
        public VirtualNetworkPeeringPropertiesFormatRemoteVirtualNetwork()
        {

        }
    }
    /// The remote virtual network should be in the same region. See here to learn more (https://learn.microsoft.com/en-us/azure/databricks/administration-guide/cloud-configurations/azure/vnet-peering).
    public partial interface IVirtualNetworkPeeringPropertiesFormatRemoteVirtualNetwork :
        Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.IJsonSerializable
    {
        /// <summary>The Id of the remote virtual network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Databricks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Id of the remote virtual network.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// The remote virtual network should be in the same region. See here to learn more (https://learn.microsoft.com/en-us/azure/databricks/administration-guide/cloud-configurations/azure/vnet-peering).
    internal partial interface IVirtualNetworkPeeringPropertiesFormatRemoteVirtualNetworkInternal

    {
        /// <summary>The Id of the remote virtual network.</summary>
        string Id { get; set; }

    }
}