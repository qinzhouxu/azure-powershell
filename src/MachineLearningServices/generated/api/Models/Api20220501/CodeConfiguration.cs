// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Configuration for a scoring code asset.</summary>
    public partial class CodeConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ICodeConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ICodeConfigurationInternal
    {

        /// <summary>Backing field for <see cref="CodeId" /> property.</summary>
        private string _codeId;

        /// <summary>ARM resource ID of the code asset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string CodeId { get => this._codeId; set => this._codeId = value; }

        /// <summary>Backing field for <see cref="ScoringScript" /> property.</summary>
        private string _scoringScript;

        /// <summary>[Required] The script to execute on startup. eg. "score.py"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string ScoringScript { get => this._scoringScript; set => this._scoringScript = value; }

        /// <summary>Creates an new <see cref="CodeConfiguration" /> instance.</summary>
        public CodeConfiguration()
        {

        }
    }
    /// Configuration for a scoring code asset.
    public partial interface ICodeConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>ARM resource ID of the code asset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ARM resource ID of the code asset.",
        SerializedName = @"codeId",
        PossibleTypes = new [] { typeof(string) })]
        string CodeId { get; set; }
        /// <summary>[Required] The script to execute on startup. eg. "score.py"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"[Required] The script to execute on startup. eg. ""score.py""",
        SerializedName = @"scoringScript",
        PossibleTypes = new [] { typeof(string) })]
        string ScoringScript { get; set; }

    }
    /// Configuration for a scoring code asset.
    internal partial interface ICodeConfigurationInternal

    {
        /// <summary>ARM resource ID of the code asset.</summary>
        string CodeId { get; set; }
        /// <summary>[Required] The script to execute on startup. eg. "score.py"</summary>
        string ScoringScript { get; set; }

    }
}