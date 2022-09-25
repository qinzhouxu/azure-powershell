// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Extensions;

    /// <summary>Data source used when creating the volume.</summary>
    public partial class SourceCreationData :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.ISourceCreationData,
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.ISourceCreationDataInternal
    {

        /// <summary>Backing field for <see cref="CreateSource" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.VolumeCreateOption? _createSource;

        /// <summary>This enumerates the possible sources of a volume creation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.VolumeCreateOption? CreateSource { get => this._createSource; set => this._createSource = value; }

        /// <summary>Backing field for <see cref="SourceUri" /> property.</summary>
        private string _sourceUri;

        /// <summary>
        /// If createOption is Copy, this is the ARM id of the source snapshot or disk. If createOption is Restore, this is the ARM-like
        /// id of the source disk restore point.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public string SourceUri { get => this._sourceUri; set => this._sourceUri = value; }

        /// <summary>Creates an new <see cref="SourceCreationData" /> instance.</summary>
        public SourceCreationData()
        {

        }
    }
    /// Data source used when creating the volume.
    public partial interface ISourceCreationData :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.IJsonSerializable
    {
        /// <summary>This enumerates the possible sources of a volume creation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This enumerates the possible sources of a volume creation.",
        SerializedName = @"createSource",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.VolumeCreateOption) })]
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.VolumeCreateOption? CreateSource { get; set; }
        /// <summary>
        /// If createOption is Copy, this is the ARM id of the source snapshot or disk. If createOption is Restore, this is the ARM-like
        /// id of the source disk restore point.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If createOption is Copy, this is the ARM id of the source snapshot or disk. If createOption is Restore, this is the ARM-like id of the source disk restore point.",
        SerializedName = @"sourceUri",
        PossibleTypes = new [] { typeof(string) })]
        string SourceUri { get; set; }

    }
    /// Data source used when creating the volume.
    internal partial interface ISourceCreationDataInternal

    {
        /// <summary>This enumerates the possible sources of a volume creation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Support.VolumeCreateOption? CreateSource { get; set; }
        /// <summary>
        /// If createOption is Copy, this is the ARM id of the source snapshot or disk. If createOption is Restore, this is the ARM-like
        /// id of the source disk restore point.
        /// </summary>
        string SourceUri { get; set; }

    }
}