// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>Product Family</summary>
    public partial class ProductFamily :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamily,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal
    {

        /// <summary>Current availability stage of the product. Availability stage</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage? AvailabilityInformationAvailabilityStage { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).AvailabilityInformationAvailabilityStage; }

        /// <summary>Reason why the product is disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason? AvailabilityInformationDisabledReason { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).AvailabilityInformationDisabledReason; }

        /// <summary>Message for why the product is disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public string AvailabilityInformationDisabledReasonMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).AvailabilityInformationDisabledReasonMessage; }

        /// <summary>Default url to display billing information</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public string CostInformationBillingInfoUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).CostInformationBillingInfoUrl; }

        /// <summary>Details on the various billing aspects for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBillingMeterDetails[] CostInformationBillingMeterDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).CostInformationBillingMeterDetail; }

        /// <summary>Attributes for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public string[] DescriptionAttribute { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionAttribute; }

        /// <summary>Keywords for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public string[] DescriptionKeyword { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionKeyword; }

        /// <summary>Links for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink[] DescriptionLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionLink; }

        /// <summary>Long description of the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public string DescriptionLongDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionLongDescription; }

        /// <summary>Short description of the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public string DescriptionShortDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionShortDescription; }

        /// <summary>Type of description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType? DescriptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionType; }

        /// <summary>Display Name for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DisplayName; }

        /// <summary>list of filters supported for a product</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IFilterableProperty[] FilterableProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICommonPropertiesInternal)Property).FilterableProperty; }

        /// <summary>Hierarchy information of a product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IHierarchyInformation HierarchyInformation { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).HierarchyInformation; }

        /// <summary>Image information for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IImageInformation[] ImageInformation { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).ImageInformation; }

        /// <summary>Internal Acessors for AvailabilityInformation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformation Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.AvailabilityInformation { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).AvailabilityInformation; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).AvailabilityInformation = value; }

        /// <summary>Internal Acessors for AvailabilityInformationAvailabilityStage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage? Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.AvailabilityInformationAvailabilityStage { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).AvailabilityInformationAvailabilityStage; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).AvailabilityInformationAvailabilityStage = value; }

        /// <summary>Internal Acessors for AvailabilityInformationDisabledReason</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason? Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.AvailabilityInformationDisabledReason { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).AvailabilityInformationDisabledReason; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).AvailabilityInformationDisabledReason = value; }

        /// <summary>Internal Acessors for AvailabilityInformationDisabledReasonMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.AvailabilityInformationDisabledReasonMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).AvailabilityInformationDisabledReasonMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).AvailabilityInformationDisabledReasonMessage = value; }

        /// <summary>Internal Acessors for CostInformation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICostInformation Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.CostInformation { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).CostInformation; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).CostInformation = value; }

        /// <summary>Internal Acessors for CostInformationBillingInfoUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.CostInformationBillingInfoUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).CostInformationBillingInfoUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).CostInformationBillingInfoUrl = value; }

        /// <summary>Internal Acessors for CostInformationBillingMeterDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBillingMeterDetails[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.CostInformationBillingMeterDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).CostInformationBillingMeterDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).CostInformationBillingMeterDetail = value; }

        /// <summary>Internal Acessors for Description</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDescription Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).Description = value; }

        /// <summary>Internal Acessors for DescriptionAttribute</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.DescriptionAttribute { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionAttribute; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionAttribute = value; }

        /// <summary>Internal Acessors for DescriptionKeyword</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.DescriptionKeyword { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionKeyword; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionKeyword = value; }

        /// <summary>Internal Acessors for DescriptionLink</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.DescriptionLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionLink = value; }

        /// <summary>Internal Acessors for DescriptionLongDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.DescriptionLongDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionLongDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionLongDescription = value; }

        /// <summary>Internal Acessors for DescriptionShortDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.DescriptionShortDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionShortDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionShortDescription = value; }

        /// <summary>Internal Acessors for DescriptionType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType? Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.DescriptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DescriptionType = value; }

        /// <summary>Internal Acessors for DisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).DisplayName = value; }

        /// <summary>Internal Acessors for FilterableProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IFilterableProperty[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.FilterableProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICommonPropertiesInternal)Property).FilterableProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICommonPropertiesInternal)Property).FilterableProperty = value; }

        /// <summary>Internal Acessors for HierarchyInformation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IHierarchyInformation Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.HierarchyInformation { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).HierarchyInformation; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).HierarchyInformation = value; }

        /// <summary>Internal Acessors for ImageInformation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IImageInformation[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.ImageInformation { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).ImageInformation; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBasicInformationInternal)Property).ImageInformation = value; }

        /// <summary>Internal Acessors for ProductLine</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductLine[] Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.ProductLine { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyPropertiesInternal)Property).ProductLine; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyPropertiesInternal)Property).ProductLine = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyProperties Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ProductFamilyProperties()); set { {_property = value;} } }

        /// <summary>List of product lines supported in the product family</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductLine[] ProductLine { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyPropertiesInternal)Property).ProductLine; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyProperties _property;

        /// <summary>Properties of product family</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ProductFamilyProperties()); }

        /// <summary>Contains details related to resource provider</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails[] ResourceProviderDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyPropertiesInternal)Property).ResourceProviderDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyPropertiesInternal)Property).ResourceProviderDetail = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="ProductFamily" /> instance.</summary>
        public ProductFamily()
        {

        }
    }
    /// Product Family
    public partial interface IProductFamily :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable
    {
        /// <summary>Current availability stage of the product. Availability stage</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Current availability stage of the product. Availability stage",
        SerializedName = @"availabilityStage",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage? AvailabilityInformationAvailabilityStage { get;  }
        /// <summary>Reason why the product is disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Reason why the product is disabled.",
        SerializedName = @"disabledReason",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason? AvailabilityInformationDisabledReason { get;  }
        /// <summary>Message for why the product is disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Message for why the product is disabled.",
        SerializedName = @"disabledReasonMessage",
        PossibleTypes = new [] { typeof(string) })]
        string AvailabilityInformationDisabledReasonMessage { get;  }
        /// <summary>Default url to display billing information</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Default url to display billing information",
        SerializedName = @"billingInfoUrl",
        PossibleTypes = new [] { typeof(string) })]
        string CostInformationBillingInfoUrl { get;  }
        /// <summary>Details on the various billing aspects for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Details on the various billing aspects for the product system.",
        SerializedName = @"billingMeterDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBillingMeterDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBillingMeterDetails[] CostInformationBillingMeterDetail { get;  }
        /// <summary>Attributes for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Attributes for the product system.",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(string) })]
        string[] DescriptionAttribute { get;  }
        /// <summary>Keywords for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Keywords for the product system.",
        SerializedName = @"keywords",
        PossibleTypes = new [] { typeof(string) })]
        string[] DescriptionKeyword { get;  }
        /// <summary>Links for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Links for the product system.",
        SerializedName = @"links",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink[] DescriptionLink { get;  }
        /// <summary>Long description of the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Long description of the product system.",
        SerializedName = @"longDescription",
        PossibleTypes = new [] { typeof(string) })]
        string DescriptionLongDescription { get;  }
        /// <summary>Short description of the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Short description of the product system.",
        SerializedName = @"shortDescription",
        PossibleTypes = new [] { typeof(string) })]
        string DescriptionShortDescription { get;  }
        /// <summary>Type of description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Type of description.",
        SerializedName = @"descriptionType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType? DescriptionType { get;  }
        /// <summary>Display Name for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Display Name for the product system.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get;  }
        /// <summary>list of filters supported for a product</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"list of filters supported for a product",
        SerializedName = @"filterableProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IFilterableProperty) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IFilterableProperty[] FilterableProperty { get;  }
        /// <summary>Hierarchy information of a product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Hierarchy information of a product.",
        SerializedName = @"hierarchyInformation",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IHierarchyInformation) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IHierarchyInformation HierarchyInformation { get;  }
        /// <summary>Image information for the product system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Image information for the product system.",
        SerializedName = @"imageInformation",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IImageInformation) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IImageInformation[] ImageInformation { get;  }
        /// <summary>List of product lines supported in the product family</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of product lines supported in the product family",
        SerializedName = @"productLines",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductLine) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductLine[] ProductLine { get;  }
        /// <summary>Contains details related to resource provider</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Contains details related to resource provider",
        SerializedName = @"resourceProviderDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails[] ResourceProviderDetail { get; set; }

    }
    /// Product Family
    internal partial interface IProductFamilyInternal

    {
        /// <summary>Availability information of the product system.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformation AvailabilityInformation { get; set; }
        /// <summary>Current availability stage of the product. Availability stage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage? AvailabilityInformationAvailabilityStage { get; set; }
        /// <summary>Reason why the product is disabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason? AvailabilityInformationDisabledReason { get; set; }
        /// <summary>Message for why the product is disabled.</summary>
        string AvailabilityInformationDisabledReasonMessage { get; set; }
        /// <summary>Cost information for the product system.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICostInformation CostInformation { get; set; }
        /// <summary>Default url to display billing information</summary>
        string CostInformationBillingInfoUrl { get; set; }
        /// <summary>Details on the various billing aspects for the product system.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBillingMeterDetails[] CostInformationBillingMeterDetail { get; set; }
        /// <summary>Description related to the product system.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDescription Description { get; set; }
        /// <summary>Attributes for the product system.</summary>
        string[] DescriptionAttribute { get; set; }
        /// <summary>Keywords for the product system.</summary>
        string[] DescriptionKeyword { get; set; }
        /// <summary>Links for the product system.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink[] DescriptionLink { get; set; }
        /// <summary>Long description of the product system.</summary>
        string DescriptionLongDescription { get; set; }
        /// <summary>Short description of the product system.</summary>
        string DescriptionShortDescription { get; set; }
        /// <summary>Type of description.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType? DescriptionType { get; set; }
        /// <summary>Display Name for the product system.</summary>
        string DisplayName { get; set; }
        /// <summary>list of filters supported for a product</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IFilterableProperty[] FilterableProperty { get; set; }
        /// <summary>Hierarchy information of a product.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IHierarchyInformation HierarchyInformation { get; set; }
        /// <summary>Image information for the product system.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IImageInformation[] ImageInformation { get; set; }
        /// <summary>List of product lines supported in the product family</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductLine[] ProductLine { get; set; }
        /// <summary>Properties of product family</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyProperties Property { get; set; }
        /// <summary>Contains details related to resource provider</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails[] ResourceProviderDetail { get; set; }

    }
}