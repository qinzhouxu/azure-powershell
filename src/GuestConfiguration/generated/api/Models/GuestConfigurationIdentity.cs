// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Extensions;

    public partial class GuestConfigurationIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IGuestConfigurationIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IGuestConfigurationIdentityInternal
    {

        /// <summary>Backing field for <see cref="GuestConfigurationAssignmentName" /> property.</summary>
        private string _guestConfigurationAssignmentName;

        /// <summary>Name of the guest configuration assignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public string GuestConfigurationAssignmentName { get => this._guestConfigurationAssignmentName; set => this._guestConfigurationAssignmentName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="MachineName" /> property.</summary>
        private string _machineName;

        /// <summary>The name of the ARC machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public string MachineName { get => this._machineName; set => this._machineName = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The guest configuration assignment name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ReportId" /> property.</summary>
        private string _reportId;

        /// <summary>The GUID for the guest configuration assignment report.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public string ReportId { get => this._reportId; set => this._reportId = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The resource group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>
        /// Subscription ID which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every
        /// service call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="VMName" /> property.</summary>
        private string _vMName;

        /// <summary>The name of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public string VMName { get => this._vMName; set => this._vMName = value; }

        /// <summary>Backing field for <see cref="VmssName" /> property.</summary>
        private string _vmssName;

        /// <summary>The name of the virtual machine scale set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.PropertyOrigin.Owned)]
        public string VmssName { get => this._vmssName; set => this._vmssName = value; }

        /// <summary>Creates an new <see cref="GuestConfigurationIdentity" /> instance.</summary>
        public GuestConfigurationIdentity()
        {

        }
    }
    public partial interface IGuestConfigurationIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>Name of the guest configuration assignment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the guest configuration assignment.",
        SerializedName = @"guestConfigurationAssignmentName",
        PossibleTypes = new [] { typeof(string) })]
        string GuestConfigurationAssignmentName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name of the ARC machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the ARC machine.",
        SerializedName = @"machineName",
        PossibleTypes = new [] { typeof(string) })]
        string MachineName { get; set; }
        /// <summary>The guest configuration assignment name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The guest configuration assignment name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The GUID for the guest configuration assignment report.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The GUID for the guest configuration assignment report.",
        SerializedName = @"reportId",
        PossibleTypes = new [] { typeof(string) })]
        string ReportId { get; set; }
        /// <summary>The resource group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource group name.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>
        /// Subscription ID which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every
        /// service call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription ID which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>The name of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the virtual machine.",
        SerializedName = @"vmName",
        PossibleTypes = new [] { typeof(string) })]
        string VMName { get; set; }
        /// <summary>The name of the virtual machine scale set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the virtual machine scale set.",
        SerializedName = @"vmssName",
        PossibleTypes = new [] { typeof(string) })]
        string VmssName { get; set; }

    }
    internal partial interface IGuestConfigurationIdentityInternal

    {
        /// <summary>Name of the guest configuration assignment.</summary>
        string GuestConfigurationAssignmentName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The name of the ARC machine.</summary>
        string MachineName { get; set; }
        /// <summary>The guest configuration assignment name.</summary>
        string Name { get; set; }
        /// <summary>The GUID for the guest configuration assignment report.</summary>
        string ReportId { get; set; }
        /// <summary>The resource group name.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>
        /// Subscription ID which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every
        /// service call.
        /// </summary>
        string SubscriptionId { get; set; }
        /// <summary>The name of the virtual machine.</summary>
        string VMName { get; set; }
        /// <summary>The name of the virtual machine scale set.</summary>
        string VmssName { get; set; }

    }
}