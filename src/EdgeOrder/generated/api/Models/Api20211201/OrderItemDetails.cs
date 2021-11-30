// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>Order item details</summary>
    public partial class OrderItemDetails :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemDetails,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemDetailsInternal
    {

        /// <summary>Backing field for <see cref="CancellationReason" /> property.</summary>
        private string _cancellationReason;

        /// <summary>Cancellation reason.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string CancellationReason { get => this._cancellationReason; }

        /// <summary>Backing field for <see cref="CancellationStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemCancellationEnum? _cancellationStatus;

        /// <summary>Describes whether the order item is cancellable or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemCancellationEnum? CancellationStatus { get => this._cancellationStatus; }

        /// <summary>Backing field for <see cref="CurrentStage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails _currentStage;

        /// <summary>Current Order item Status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails CurrentStage { get => (this._currentStage = this._currentStage ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.StageDetails()); }

        /// <summary>Backing field for <see cref="DeletionStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.ActionStatusEnum? _deletionStatus;

        /// <summary>Describes whether the order item is deletable or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.ActionStatusEnum? DeletionStatus { get => this._deletionStatus; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IErrorDetail _error;

        /// <summary>Top level error for the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IErrorDetail Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.ErrorDetail()); }

        /// <summary>Backing field for <see cref="ForwardShippingDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IForwardShippingDetails _forwardShippingDetail;

        /// <summary>Forward Package Shipping details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IForwardShippingDetails ForwardShippingDetail { get => (this._forwardShippingDetail = this._forwardShippingDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ForwardShippingDetails()); }

        /// <summary>Backing field for <see cref="ManagementRpDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails _managementRpDetail;

        /// <summary>
        /// Parent RP details - this returns only the first or default parent RP from the entire list
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails ManagementRpDetail { get => (this._managementRpDetail = this._managementRpDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ResourceProviderDetails()); }

        /// <summary>Backing field for <see cref="ManagementRpDetailsList" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails[] _managementRpDetailsList;

        /// <summary>List of parent RP details supported for configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails[] ManagementRpDetailsList { get => this._managementRpDetailsList; }

        /// <summary>Internal Acessors for CancellationReason</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemDetailsInternal.CancellationReason { get => this._cancellationReason; set { {_cancellationReason = value;} } }

        /// <summary>Internal Acessors for CancellationStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemCancellationEnum? Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemDetailsInternal.CancellationStatus { get => this._cancellationStatus; set { {_cancellationStatus = value;} } }

        /// <summary>Internal Acessors for CurrentStage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemDetailsInternal.CurrentStage { get => (this._currentStage = this._currentStage ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.StageDetails()); set { {_currentStage = value;} } }

        /// <summary>Internal Acessors for DeletionStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.ActionStatusEnum? Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemDetailsInternal.DeletionStatus { get => this._deletionStatus; set { {_deletionStatus = value;} } }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemDetailsInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.ErrorDetail()); set { {_error = value;} } }

        /// <summary>Internal Acessors for ForwardShippingDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IForwardShippingDetails Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemDetailsInternal.ForwardShippingDetail { get => (this._forwardShippingDetail = this._forwardShippingDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ForwardShippingDetails()); set { {_forwardShippingDetail = value;} } }

        /// <summary>Internal Acessors for ManagementRpDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemDetailsInternal.ManagementRpDetail { get => (this._managementRpDetail = this._managementRpDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ResourceProviderDetails()); set { {_managementRpDetail = value;} } }

        /// <summary>Internal Acessors for ManagementRpDetailsList</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemDetailsInternal.ManagementRpDetailsList { get => this._managementRpDetailsList; set { {_managementRpDetailsList = value;} } }

        /// <summary>Internal Acessors for OrderItemStageHistory</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemDetailsInternal.OrderItemStageHistory { get => this._orderItemStageHistory; set { {_orderItemStageHistory = value;} } }

        /// <summary>Internal Acessors for ReturnReason</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemDetailsInternal.ReturnReason { get => this._returnReason; set { {_returnReason = value;} } }

        /// <summary>Internal Acessors for ReturnStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemReturnEnum? Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemDetailsInternal.ReturnStatus { get => this._returnStatus; set { {_returnStatus = value;} } }

        /// <summary>Internal Acessors for ReverseShippingDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReverseShippingDetails Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IOrderItemDetailsInternal.ReverseShippingDetail { get => (this._reverseShippingDetail = this._reverseShippingDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ReverseShippingDetails()); set { {_reverseShippingDetail = value;} } }

        /// <summary>Backing field for <see cref="NotificationEmailList" /> property.</summary>
        private string[] _notificationEmailList;

        /// <summary>Additional notification email list</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string[] NotificationEmailList { get => this._notificationEmailList; set => this._notificationEmailList = value; }

        /// <summary>Backing field for <see cref="OrderItemStageHistory" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails[] _orderItemStageHistory;

        /// <summary>Order item status history</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails[] OrderItemStageHistory { get => this._orderItemStageHistory; }

        /// <summary>Backing field for <see cref="OrderItemType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemType _orderItemType;

        /// <summary>Order item type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemType OrderItemType { get => this._orderItemType; set => this._orderItemType = value; }

        /// <summary>Backing field for <see cref="Preference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IPreferences _preference;

        /// <summary>Customer notification Preferences</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IPreferences Preference { get => (this._preference = this._preference ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.Preferences()); set => this._preference = value; }

        /// <summary>Backing field for <see cref="ProductDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductDetails _productDetail;

        /// <summary>Unique identifier for configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductDetails ProductDetail { get => (this._productDetail = this._productDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ProductDetails()); set => this._productDetail = value; }

        /// <summary>Backing field for <see cref="ReturnReason" /> property.</summary>
        private string _returnReason;

        /// <summary>Return reason.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public string ReturnReason { get => this._returnReason; }

        /// <summary>Backing field for <see cref="ReturnStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemReturnEnum? _returnStatus;

        /// <summary>Describes whether the order item is returnable or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemReturnEnum? ReturnStatus { get => this._returnStatus; }

        /// <summary>Backing field for <see cref="ReverseShippingDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReverseShippingDetails _reverseShippingDetail;

        /// <summary>Reverse Package Shipping details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReverseShippingDetails ReverseShippingDetail { get => (this._reverseShippingDetail = this._reverseShippingDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ReverseShippingDetails()); }

        /// <summary>Creates an new <see cref="OrderItemDetails" /> instance.</summary>
        public OrderItemDetails()
        {

        }
    }
    /// Order item details
    public partial interface IOrderItemDetails :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable
    {
        /// <summary>Cancellation reason.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Cancellation reason.",
        SerializedName = @"cancellationReason",
        PossibleTypes = new [] { typeof(string) })]
        string CancellationReason { get;  }
        /// <summary>Describes whether the order item is cancellable or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Describes whether the order item is cancellable or not.",
        SerializedName = @"cancellationStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemCancellationEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemCancellationEnum? CancellationStatus { get;  }
        /// <summary>Current Order item Status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Current Order item Status",
        SerializedName = @"currentStage",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails CurrentStage { get;  }
        /// <summary>Describes whether the order item is deletable or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Describes whether the order item is deletable or not.",
        SerializedName = @"deletionStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.ActionStatusEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.ActionStatusEnum? DeletionStatus { get;  }
        /// <summary>Top level error for the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Top level error for the job.",
        SerializedName = @"error",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IErrorDetail) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IErrorDetail Error { get;  }
        /// <summary>Forward Package Shipping details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Forward Package Shipping details",
        SerializedName = @"forwardShippingDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IForwardShippingDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IForwardShippingDetails ForwardShippingDetail { get;  }
        /// <summary>
        /// Parent RP details - this returns only the first or default parent RP from the entire list
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Parent RP details - this returns only the first or default parent RP from the entire list",
        SerializedName = @"managementRpDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails ManagementRpDetail { get;  }
        /// <summary>List of parent RP details supported for configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of parent RP details supported for configuration.",
        SerializedName = @"managementRpDetailsList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails[] ManagementRpDetailsList { get;  }
        /// <summary>Additional notification email list</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Additional notification email list",
        SerializedName = @"notificationEmailList",
        PossibleTypes = new [] { typeof(string) })]
        string[] NotificationEmailList { get; set; }
        /// <summary>Order item status history</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Order item status history",
        SerializedName = @"orderItemStageHistory",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails[] OrderItemStageHistory { get;  }
        /// <summary>Order item type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Order item type.",
        SerializedName = @"orderItemType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemType) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemType OrderItemType { get; set; }
        /// <summary>Customer notification Preferences</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Customer notification Preferences",
        SerializedName = @"preferences",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IPreferences) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IPreferences Preference { get; set; }
        /// <summary>Unique identifier for configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Unique identifier for configuration.",
        SerializedName = @"productDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductDetails ProductDetail { get; set; }
        /// <summary>Return reason.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Return reason.",
        SerializedName = @"returnReason",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnReason { get;  }
        /// <summary>Describes whether the order item is returnable or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Describes whether the order item is returnable or not.",
        SerializedName = @"returnStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemReturnEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemReturnEnum? ReturnStatus { get;  }
        /// <summary>Reverse Package Shipping details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Reverse Package Shipping details",
        SerializedName = @"reverseShippingDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReverseShippingDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReverseShippingDetails ReverseShippingDetail { get;  }

    }
    /// Order item details
    internal partial interface IOrderItemDetailsInternal

    {
        /// <summary>Cancellation reason.</summary>
        string CancellationReason { get; set; }
        /// <summary>Describes whether the order item is cancellable or not.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemCancellationEnum? CancellationStatus { get; set; }
        /// <summary>Current Order item Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails CurrentStage { get; set; }
        /// <summary>Describes whether the order item is deletable or not.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.ActionStatusEnum? DeletionStatus { get; set; }
        /// <summary>Top level error for the job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20.IErrorDetail Error { get; set; }
        /// <summary>Forward Package Shipping details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IForwardShippingDetails ForwardShippingDetail { get; set; }
        /// <summary>
        /// Parent RP details - this returns only the first or default parent RP from the entire list
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails ManagementRpDetail { get; set; }
        /// <summary>List of parent RP details supported for configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails[] ManagementRpDetailsList { get; set; }
        /// <summary>Additional notification email list</summary>
        string[] NotificationEmailList { get; set; }
        /// <summary>Order item status history</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IStageDetails[] OrderItemStageHistory { get; set; }
        /// <summary>Order item type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemType OrderItemType { get; set; }
        /// <summary>Customer notification Preferences</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IPreferences Preference { get; set; }
        /// <summary>Unique identifier for configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductDetails ProductDetail { get; set; }
        /// <summary>Return reason.</summary>
        string ReturnReason { get; set; }
        /// <summary>Describes whether the order item is returnable or not.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.OrderItemReturnEnum? ReturnStatus { get; set; }
        /// <summary>Reverse Package Shipping details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IReverseShippingDetails ReverseShippingDetail { get; set; }

    }
}