
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for MLTableJobOutput.
.Description
Create an in-memory object for MLTableJobOutput.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.MLTableJobOutput
.Link
https://docs.microsoft.com/powershell/module/az.MLWorkspace/new-AzMLWorkspaceMLTableJobOutputObject
#>
function New-AzMLWorkspaceMLTableJobOutputObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.MLTableJobOutput')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Output Asset Delivery Mode.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OutputDeliveryMode])]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.OutputDeliveryMode]
        $Mode,
        [Parameter(HelpMessage="Output Asset URI.")]
        [string]
        $Uri,
        [Parameter(HelpMessage="Description for the output.")]
        [string]
        $Description,
        [Parameter(Mandatory, HelpMessage="[Required] Specifies the type of job.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobOutputType])]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobOutputType]
        $Type
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.MLTableJobOutput]::New()

        if ($PSBoundParameters.ContainsKey('Mode')) {
            $Object.Mode = $Mode
        }
        if ($PSBoundParameters.ContainsKey('Uri')) {
            $Object.Uri = $Uri
        }
        if ($PSBoundParameters.ContainsKey('Description')) {
            $Object.Description = $Description
        }
        if ($PSBoundParameters.ContainsKey('Type')) {
            $Object.Type = $Type
        }
        return $Object
    }
}

