// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>Order item update properties.</summary>
    public partial class OrderItemUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ForwardAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressProperties _forwardAddress;

        /// <summary>Updates forward shipping address and contact details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressProperties ForwardAddress { get => (this._forwardAddress = this._forwardAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AddressProperties()); set => this._forwardAddress = value; }

        /// <summary>Contact details for the address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IContactDetails ForwardAddressContactDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)ForwardAddress).ContactDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)ForwardAddress).ContactDetail = value ?? null /* model class */; }

        /// <summary>Shipping details for the address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IShippingAddress ForwardAddressShippingAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)ForwardAddress).ShippingAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)ForwardAddress).ShippingAddress = value ?? null /* model class */; }

        /// <summary>Status of address validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus? ForwardAddressValidationStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)ForwardAddress).AddressValidationStatus; }

        /// <summary>Internal Acessors for ForwardAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressProperties Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemUpdatePropertiesInternal.ForwardAddress { get => (this._forwardAddress = this._forwardAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AddressProperties()); set { {_forwardAddress = value;} } }

        /// <summary>Internal Acessors for ForwardAddressValidationStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus? Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemUpdatePropertiesInternal.ForwardAddressValidationStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)ForwardAddress).AddressValidationStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)ForwardAddress).AddressValidationStatus = value; }

        /// <summary>Backing field for <see cref="NotificationEmailList" /> property.</summary>
        private string[] _notificationEmailList;

        /// <summary>Additional notification email list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string[] NotificationEmailList { get => this._notificationEmailList; set => this._notificationEmailList = value; }

        /// <summary>Backing field for <see cref="Preference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IPreferences _preference;

        /// <summary>Customer preference.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IPreferences Preference { get => (this._preference = this._preference ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.Preferences()); set => this._preference = value; }

        /// <summary>Creates an new <see cref="OrderItemUpdateProperties" /> instance.</summary>
        public OrderItemUpdateProperties()
        {

        }
    }
    /// Order item update properties.
    public partial interface IOrderItemUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable
    {
        /// <summary>Contact details for the address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Contact details for the address",
        SerializedName = @"contactDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IContactDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IContactDetails ForwardAddressContactDetail { get; set; }
        /// <summary>Shipping details for the address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Shipping details for the address",
        SerializedName = @"shippingAddress",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IShippingAddress) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IShippingAddress ForwardAddressShippingAddress { get; set; }
        /// <summary>Status of address validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Status of address validation",
        SerializedName = @"addressValidationStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus? ForwardAddressValidationStatus { get;  }
        /// <summary>Additional notification email list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Additional notification email list.",
        SerializedName = @"notificationEmailList",
        PossibleTypes = new [] { typeof(string) })]
        string[] NotificationEmailList { get; set; }
        /// <summary>Customer preference.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Customer preference.",
        SerializedName = @"preferences",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IPreferences) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IPreferences Preference { get; set; }

    }
    /// Order item update properties.
    internal partial interface IOrderItemUpdatePropertiesInternal

    {
        /// <summary>Updates forward shipping address and contact details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressProperties ForwardAddress { get; set; }
        /// <summary>Contact details for the address</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IContactDetails ForwardAddressContactDetail { get; set; }
        /// <summary>Shipping details for the address</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IShippingAddress ForwardAddressShippingAddress { get; set; }
        /// <summary>Status of address validation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus? ForwardAddressValidationStatus { get; set; }
        /// <summary>Additional notification email list.</summary>
        string[] NotificationEmailList { get; set; }
        /// <summary>Customer preference.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IPreferences Preference { get; set; }

    }
}