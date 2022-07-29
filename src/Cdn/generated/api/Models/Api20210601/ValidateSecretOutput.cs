// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Output of the validated secret.</summary>
    public partial class ValidateSecretOutput :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IValidateSecretOutput,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IValidateSecretOutputInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Detailed error message</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Status? _status;

        /// <summary>The validation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Status? Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="ValidateSecretOutput" /> instance.</summary>
        public ValidateSecretOutput()
        {

        }
    }
    /// Output of the validated secret.
    public partial interface IValidateSecretOutput :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>Detailed error message</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Detailed error message",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>The validation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The validation status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Status) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Status? Status { get; set; }

    }
    /// Output of the validated secret.
    internal partial interface IValidateSecretOutputInternal

    {
        /// <summary>Detailed error message</summary>
        string Message { get; set; }
        /// <summary>The validation status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.Status? Status { get; set; }

    }
}