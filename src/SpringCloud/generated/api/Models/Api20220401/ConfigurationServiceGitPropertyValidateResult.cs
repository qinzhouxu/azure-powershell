// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Extensions;

    /// <summary>Validation result for configuration service settings</summary>
    public partial class ConfigurationServiceGitPropertyValidateResult :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceGitPropertyValidateResult,
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IConfigurationServiceGitPropertyValidateResultInternal
    {

        /// <summary>Backing field for <see cref="GitReposValidationResult" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IValidationMessages[] _gitReposValidationResult;

        /// <summary>The detail validation results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IValidationMessages[] GitReposValidationResult { get => this._gitReposValidationResult; set => this._gitReposValidationResult = value; }

        /// <summary>Backing field for <see cref="IsValid" /> property.</summary>
        private bool? _isValid;

        /// <summary>Indicate if the configuration service settings are valid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.PropertyOrigin.Owned)]
        public bool? IsValid { get => this._isValid; set => this._isValid = value; }

        /// <summary>
        /// Creates an new <see cref="ConfigurationServiceGitPropertyValidateResult" /> instance.
        /// </summary>
        public ConfigurationServiceGitPropertyValidateResult()
        {

        }
    }
    /// Validation result for configuration service settings
    public partial interface IConfigurationServiceGitPropertyValidateResult :
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.IJsonSerializable
    {
        /// <summary>The detail validation results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The detail validation results",
        SerializedName = @"gitReposValidationResult",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IValidationMessages) })]
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IValidationMessages[] GitReposValidationResult { get; set; }
        /// <summary>Indicate if the configuration service settings are valid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicate if the configuration service settings are valid",
        SerializedName = @"isValid",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsValid { get; set; }

    }
    /// Validation result for configuration service settings
    internal partial interface IConfigurationServiceGitPropertyValidateResultInternal

    {
        /// <summary>The detail validation results</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.Api20220401.IValidationMessages[] GitReposValidationResult { get; set; }
        /// <summary>Indicate if the configuration service settings are valid</summary>
        bool? IsValid { get; set; }

    }
}