
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
Gets the logs for an operation on an environment.
.Description
Gets the logs for an operation on an environment.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.IDevCenterdataIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDevCenterdataIdentity>: Identity Parameter
  [Name <String>]: The name of an action that will take place on a Dev Box.
  [CatalogName <String>]: The name of the catalog
  [CustomizationGroupName <String>]: A customization group name.
  [CustomizationTaskId <String>]: A customization task ID.
  [DefinitionName <String>]: The name of the environment definition
  [DevBoxName <String>]: The name of a Dev Box.
  [EnvironmentName <String>]: The name of the environment.
  [Id <String>]: Resource identity path
  [OperationId <String>]: The id of the operation on a Dev Box.
  [PoolName <String>]: The name of a pool of Dev Boxes.
  [ProjectName <String>]: The DevCenter Project upon which to execute operations.
  [ScheduleName <String>]: The name of a schedule.
  [TaskName <String>]: A customization task name.
  [UserId <String>]: The AAD object id of the user. If value is 'me', the identity is taken from the authentication context.
.Link
https://learn.microsoft.com/powershell/module/az.devcenter/get-azdevcenteruserenvironmentlog
#>
function Get-AzDevCenterUserEnvironmentLog {
    [OutputType([System.Boolean])]
    [CmdletBinding(DefaultParameterSetName = 'Get', PositionalBinding = $false)]
    param(
        [Parameter(ParameterSetName = 'Get', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Uri')]
        [System.String]
        # The DevCenter-specific URI to operate on.
        ${Endpoint},

        [Parameter(ParameterSetName = 'GetByDevCenter', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Uri')]
        [Alias('DevCenter')]
        [System.String]
        # The DevCenter upon which to execute operations.
        ${DevCenterName},

        [Parameter(ParameterSetName = 'Get', Mandatory)]
        [Parameter(ParameterSetName = 'GetByDevCenter', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Path')]
        [System.String]
        # The name of the environment.
        ${EnvironmentName},

        [Parameter(ParameterSetName = 'Get', Mandatory)]
        [Parameter(ParameterSetName = 'GetByDevCenter', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Path')]
        [System.String]
        # The id of the operation on an environment.
        ${OperationId},

        [Parameter(ParameterSetName = 'Get', Mandatory)]
        [Parameter(ParameterSetName = 'GetByDevCenter', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Path')]
        [System.String]
        # The DevCenter Project upon which to execute operations.
        ${ProjectName},

        [Parameter(ParameterSetName = 'Get')]
        [Parameter(ParameterSetName = 'GetByDevCenter')]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.DefaultInfo(Script = '"me"')]
        [System.String]
        # The AAD object id of the user.
        # If value is 'me', the identity is taken from the authentication context.
        ${UserId},

        [Parameter(Mandatory)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Body')]
        [System.String]
        # Path to write output file to
        ${OutFile},

        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The DefaultProfile parameter is not functional.
        # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
        ${DefaultProfile},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Returns true when the command succeeds
        ${PassThru},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )

    process {
        if (-not $PSBoundParameters.ContainsKey('Endpoint')) {
            $Endpoint = GetEndpointFromResourceGraph -DevCenterName $DevCenterName -Project $ProjectName
            $null = $PSBoundParameters.Add("Endpoint", $Endpoint)
            $null = $PSBoundParameters.Remove("DevCenterName")

        }
        else {
            $Endpoint = ValidateAndProcessEndpoint -Endpoint $Endpoint
            $PSBoundParameters["Endpoint"] = $Endpoint
        }

        Az.DevCenterdata.internal\Get-AzDevCenterUserEnvironmentLog @PSBoundParameters
    }
}
