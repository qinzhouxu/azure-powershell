// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Extensions;

    /// <summary>Parameters to reconcile to the GitRepository source kind type.</summary>
    public partial class BucketDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IBucketDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20220301.IBucketDefinitionInternal
    {

        /// <summary>Backing field for <see cref="AccessKey" /> property.</summary>
        private System.Security.SecureString _accessKey;

        /// <summary>Plaintext access key used to securely access the S3 bucket</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public System.Security.SecureString AccessKey { get => this._accessKey; set => this._accessKey = value; }

        /// <summary>Backing field for <see cref="BucketName" /> property.</summary>
        private string _bucketName;

        /// <summary>The bucket name to sync from the url endpoint for the flux configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string BucketName { get => this._bucketName; set => this._bucketName = value; }

        /// <summary>Backing field for <see cref="Insecure" /> property.</summary>
        private bool? _insecure;

        /// <summary>
        /// Specify whether to use insecure communication when puling data from the S3 bucket.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public bool? Insecure { get => this._insecure; set => this._insecure = value; }

        /// <summary>Backing field for <see cref="LocalAuthRef" /> property.</summary>
        private string _localAuthRef;

        /// <summary>
        /// Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the managed or user-provided
        /// configuration secrets.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string LocalAuthRef { get => this._localAuthRef; set => this._localAuthRef = value; }

        /// <summary>Backing field for <see cref="SyncIntervalInSecond" /> property.</summary>
        private long? _syncIntervalInSecond;

        /// <summary>
        /// The interval at which to re-reconcile the cluster git repository source with the remote.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public long? SyncIntervalInSecond { get => this._syncIntervalInSecond; set => this._syncIntervalInSecond = value; }

        /// <summary>Backing field for <see cref="TimeoutInSecond" /> property.</summary>
        private long? _timeoutInSecond;

        /// <summary>
        /// The maximum time to attempt to reconcile the cluster git repository source with the remote.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public long? TimeoutInSecond { get => this._timeoutInSecond; set => this._timeoutInSecond = value; }

        /// <summary>Backing field for <see cref="Url" /> property.</summary>
        private string _url;

        /// <summary>The URL to sync for the flux configuration S3 bucket.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Origin(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PropertyOrigin.Owned)]
        public string Url { get => this._url; set => this._url = value; }

        /// <summary>Creates an new <see cref="BucketDefinition" /> instance.</summary>
        public BucketDefinition()
        {

        }
    }
    /// Parameters to reconcile to the GitRepository source kind type.
    public partial interface IBucketDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.IJsonSerializable
    {
        /// <summary>Plaintext access key used to securely access the S3 bucket</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Plaintext access key used to securely access the S3 bucket",
        SerializedName = @"accessKey",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString AccessKey { get; set; }
        /// <summary>The bucket name to sync from the url endpoint for the flux configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The bucket name to sync from the url endpoint for the flux configuration.",
        SerializedName = @"bucketName",
        PossibleTypes = new [] { typeof(string) })]
        string BucketName { get; set; }
        /// <summary>
        /// Specify whether to use insecure communication when puling data from the S3 bucket.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specify whether to use insecure communication when puling data from the S3 bucket.",
        SerializedName = @"insecure",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Insecure { get; set; }
        /// <summary>
        /// Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the managed or user-provided
        /// configuration secrets.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the managed or user-provided configuration secrets.",
        SerializedName = @"localAuthRef",
        PossibleTypes = new [] { typeof(string) })]
        string LocalAuthRef { get; set; }
        /// <summary>
        /// The interval at which to re-reconcile the cluster git repository source with the remote.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The interval at which to re-reconcile the cluster git repository source with the remote.",
        SerializedName = @"syncIntervalInSeconds",
        PossibleTypes = new [] { typeof(long) })]
        long? SyncIntervalInSecond { get; set; }
        /// <summary>
        /// The maximum time to attempt to reconcile the cluster git repository source with the remote.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum time to attempt to reconcile the cluster git repository source with the remote.",
        SerializedName = @"timeoutInSeconds",
        PossibleTypes = new [] { typeof(long) })]
        long? TimeoutInSecond { get; set; }
        /// <summary>The URL to sync for the flux configuration S3 bucket.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL to sync for the flux configuration S3 bucket.",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string Url { get; set; }

    }
    /// Parameters to reconcile to the GitRepository source kind type.
    internal partial interface IBucketDefinitionInternal

    {
        /// <summary>Plaintext access key used to securely access the S3 bucket</summary>
        System.Security.SecureString AccessKey { get; set; }
        /// <summary>The bucket name to sync from the url endpoint for the flux configuration.</summary>
        string BucketName { get; set; }
        /// <summary>
        /// Specify whether to use insecure communication when puling data from the S3 bucket.
        /// </summary>
        bool? Insecure { get; set; }
        /// <summary>
        /// Name of a local secret on the Kubernetes cluster to use as the authentication secret rather than the managed or user-provided
        /// configuration secrets.
        /// </summary>
        string LocalAuthRef { get; set; }
        /// <summary>
        /// The interval at which to re-reconcile the cluster git repository source with the remote.
        /// </summary>
        long? SyncIntervalInSecond { get; set; }
        /// <summary>
        /// The maximum time to attempt to reconcile the cluster git repository source with the remote.
        /// </summary>
        long? TimeoutInSecond { get; set; }
        /// <summary>The URL to sync for the flux configuration S3 bucket.</summary>
        string Url { get; set; }

    }
}