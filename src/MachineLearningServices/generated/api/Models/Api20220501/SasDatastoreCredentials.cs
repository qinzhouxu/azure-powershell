// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>SAS datastore credentials configuration.</summary>
    public partial class SasDatastoreCredentials :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISasDatastoreCredentials,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISasDatastoreCredentialsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDatastoreCredentials"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDatastoreCredentials __datastoreCredentials = new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DatastoreCredentials();

        /// <summary>[Required] Credential type used to authentication with storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.CredentialsType CredentialsType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDatastoreCredentialsInternal)__datastoreCredentials).CredentialsType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDatastoreCredentialsInternal)__datastoreCredentials).CredentialsType = value ; }

        /// <summary>Backing field for <see cref="Secret" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISasDatastoreSecrets _secret;

        /// <summary>[Required] Storage container secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISasDatastoreSecrets Secret { get => (this._secret = this._secret ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.SasDatastoreSecrets()); set => this._secret = value; }

        /// <summary>Creates an new <see cref="SasDatastoreCredentials" /> instance.</summary>
        public SasDatastoreCredentials()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__datastoreCredentials), __datastoreCredentials);
            await eventListener.AssertObjectIsValid(nameof(__datastoreCredentials), __datastoreCredentials);
        }
    }
    /// SAS datastore credentials configuration.
    public partial interface ISasDatastoreCredentials :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDatastoreCredentials
    {
        /// <summary>[Required] Storage container secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"[Required] Storage container secrets.",
        SerializedName = @"secrets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISasDatastoreSecrets) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISasDatastoreSecrets Secret { get; set; }

    }
    /// SAS datastore credentials configuration.
    internal partial interface ISasDatastoreCredentialsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDatastoreCredentialsInternal
    {
        /// <summary>[Required] Storage container secrets.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISasDatastoreSecrets Secret { get; set; }

    }
}