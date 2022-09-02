// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;

    /// <summary>Extra Operation properties</summary>
    public partial class OperationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IOperationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IOperationPropertiesInternal
    {

        /// <summary>Internal Acessors for ServiceSpecification</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IServiceSpecification Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IOperationPropertiesInternal.ServiceSpecification { get => (this._serviceSpecification = this._serviceSpecification ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.ServiceSpecification()); set { {_serviceSpecification = value;} } }

        /// <summary>Backing field for <see cref="ServiceSpecification" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IServiceSpecification _serviceSpecification;

        /// <summary>Service specifications of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IServiceSpecification ServiceSpecification { get => (this._serviceSpecification = this._serviceSpecification ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.ServiceSpecification()); set => this._serviceSpecification = value; }

        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.ILogSpecification[] ServiceSpecificationLogSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IServiceSpecificationInternal)ServiceSpecification).LogSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IServiceSpecificationInternal)ServiceSpecification).LogSpecification = value ?? null /* arrayOf */; }

        /// <summary>Specifications of the Metrics for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IMetricSpecification[] ServiceSpecificationMetricSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IServiceSpecificationInternal)ServiceSpecification).MetricSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IServiceSpecificationInternal)ServiceSpecification).MetricSpecification = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="OperationProperties" /> instance.</summary>
        public OperationProperties()
        {

        }
    }
    /// Extra Operation properties
    public partial interface IOperationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifications of the Log for Azure Monitoring",
        SerializedName = @"logSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.ILogSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.ILogSpecification[] ServiceSpecificationLogSpecification { get; set; }
        /// <summary>Specifications of the Metrics for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifications of the Metrics for Azure Monitoring",
        SerializedName = @"metricSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IMetricSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IMetricSpecification[] ServiceSpecificationMetricSpecification { get; set; }

    }
    /// Extra Operation properties
    internal partial interface IOperationPropertiesInternal

    {
        /// <summary>Service specifications of the operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IServiceSpecification ServiceSpecification { get; set; }
        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.ILogSpecification[] ServiceSpecificationLogSpecification { get; set; }
        /// <summary>Specifications of the Metrics for Azure Monitoring</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Api20220501.IMetricSpecification[] ServiceSpecificationMetricSpecification { get; set; }

    }
}