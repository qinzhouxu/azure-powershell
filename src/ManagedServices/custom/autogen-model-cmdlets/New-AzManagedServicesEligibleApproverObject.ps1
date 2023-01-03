
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
Create an in-memory object for EligibleApprover.
.Description
Create an in-memory object for EligibleApprover.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.EligibleApprover
.Link
https://learn.microsoft.com/powershell/module/az.ManagedServices/new-AzManagedServicesEligibleApproverObject
#>
function New-AzManagedServicesEligibleApproverObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.EligibleApprover')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="The identifier of the Azure Active Directory principal.")]
        [string]
        $PrincipalId,
        [Parameter(HelpMessage="The display name of the Azure Active Directory principal.")]
        [string]
        $PrincipalIdDisplayName
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.EligibleApprover]::New()

        if ($PSBoundParameters.ContainsKey('PrincipalId')) {
            $Object.PrincipalId = $PrincipalId
        }
        if ($PSBoundParameters.ContainsKey('PrincipalIdDisplayName')) {
            $Object.PrincipalIdDisplayName = $PrincipalIdDisplayName
        }
        return $Object
    }
}

