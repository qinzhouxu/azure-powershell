// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>The List Usages operation response.</summary>
    public partial class ListUsagesResult :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListUsagesResult,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListUsagesResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListUsagesResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IUsage[] Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IListUsagesResultInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// The URI to fetch the next page of AML resource usage information. Call ListNext() with this to fetch the next page of
        /// AML resource usage information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IUsage[] _value;

        /// <summary>The list of AML resource usages.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IUsage[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="ListUsagesResult" /> instance.</summary>
        public ListUsagesResult()
        {

        }
    }
    /// The List Usages operation response.
    public partial interface IListUsagesResult :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The URI to fetch the next page of AML resource usage information. Call ListNext() with this to fetch the next page of
        /// AML resource usage information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The URI to fetch the next page of AML resource usage information. Call ListNext() with this to fetch the next page of AML resource usage information.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>The list of AML resource usages.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of AML resource usages.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IUsage) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IUsage[] Value { get;  }

    }
    /// The List Usages operation response.
    internal partial interface IListUsagesResultInternal

    {
        /// <summary>
        /// The URI to fetch the next page of AML resource usage information. Call ListNext() with this to fetch the next page of
        /// AML resource usage information.
        /// </summary>
        string NextLink { get; set; }
        /// <summary>The list of AML resource usages.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IUsage[] Value { get; set; }

    }
}