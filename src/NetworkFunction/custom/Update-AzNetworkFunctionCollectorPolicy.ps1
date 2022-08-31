
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
Creates or updates a Collector Policy resource
.Description
Creates or updates a Collector Policy resource
.Example
{{ Add code here }}
.Example
{{ Add code here }}
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220801.ICollectorPolicy
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.
EMISSIONPOLICY <IEmissionPoliciesPropertiesFormat[]>: Emission policies.
  [EmissionDestination <IEmissionPolicyDestination[]>]: Emission policy destinations.
    [DestinationType <DestinationType?>]: Emission destination type.
  [EmissionType <EmissionType?>]: Emission format type.
INGESTIONPOLICYINGESTIONSOURCE <IIngestionSourcesPropertiesFormat[]>: Ingestion Sources.
  [ResourceId <String>]: Resource ID.
  [SourceType <SourceType?>]: Ingestion source type.
.Link
https://docs.microsoft.com/powershell/module/az.networkfunction/set-aznetworkfunctioncollectorpolicy
#>
function Update-AzNetworkFunctionCollectorPolicy {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220801.ICollectorPolicy])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Path')]
    [System.String]
    # Azure Traffic Collector name
    ${AzureTrafficCollectorName},

    [Parameter(Mandatory)]
    [Alias('CollectorPolicyName')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Path')]
    [System.String]
    # Collector Policy Name
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Path')]
    [System.String]
    # The name of the resource group.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Azure Subscription ID.
    ${SubscriptionId},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220801.IEmissionPoliciesPropertiesFormat[]]
    # Emission policies.
    # To construct, see NOTES section for EMISSIONPOLICY properties and create a hash table.
    ${EmissionPolicy},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220801.IIngestionSourcesPropertiesFormat[]]
    # Ingestion Sources.
    # To construct, see NOTES section for INGESTIONPOLICYINGESTIONSOURCE properties and create a hash table.
    ${IngestionPolicyIngestionSource},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.IngestionType])]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.IngestionType]
    # The ingestion type.
    ${IngestionPolicyIngestionType},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Body')]
    [System.String]
    # Resource location.
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220801.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

process {
    try {
        Az.NetworkFunction.internal\Set-AzNetworkFunctionCollectorPolicy @PSBoundParameters
    } catch {
        throw
    }
}
}