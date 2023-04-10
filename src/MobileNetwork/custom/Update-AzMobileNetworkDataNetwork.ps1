
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
Updates data network.
.Description
Updates data network.
.Example
Update-AzMobileNetworkDataNetwork -MobileNetworkName azps-mn -DataNetworkName azps-mn-datanetwork -ResourceGroupName azps_test_group -Tag @{"abc"="`12"}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IMobileNetworkIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IDataNetwork
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IMobileNetworkIdentity>: Identity Parameter
  [AttachedDataNetworkName <String>]: The name of the attached data network.
  [DataNetworkName <String>]: The name of the data network.
  [Id <String>]: Resource identity path
  [MobileNetworkName <String>]: The name of the mobile network.
  [PacketCoreControlPlaneName <String>]: The name of the packet core control plane.
  [PacketCoreDataPlaneName <String>]: The name of the packet core data plane.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ServiceName <String>]: The name of the service. You must not use any of the following reserved strings - 'default', 'requested' or 'service'
  [SimGroupName <String>]: The name of the SIM Group.
  [SimName <String>]: The name of the SIM.
  [SimPolicyName <String>]: The name of the SIM policy.
  [SiteName <String>]: The name of the mobile network site.
  [SliceName <String>]: The name of the network slice.
  [SubscriptionId <String>]: The ID of the target subscription.
  [VersionName <String>]: The name of the packet core control plane version.
.Link
https://learn.microsoft.com/powershell/module/az.mobilenetwork/update-azmobilenetworkdatanetwork
#>
function Update-AzMobileNetworkDataNetwork {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IDataNetwork])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
    [System.String]
    # The name of the data network.
    ${DataNetworkName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
    [System.String]
    # The name of the mobile network.
    ${MobileNetworkName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [System.String]
    # An optional description for this data network.
    ${Description},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ITagsObjectTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

    process {
        try {
            $dataNetwork = Get-AzMobileNetworkDataNetwork -MobileNetworkName $PSBoundParameters.MobileNetworkName -ResourceGroupName $PSBoundParameters.ResourceGroupName -Name $PSBoundParameters.DataNetworkName
            $PSBoundParameters.Add('Location', $dataNetwork.Location)

            if (!$PSBoundParameters.ContainsKey('Description') -and $dataNetwork.Description) {
                $PSBoundParameters.Description = $dataNetwork.Description
            }

            if (!$PSBoundParameters.ContainsKey('Tag')) {
                $PSBoundParameters.Tag = $dataNetwork.Tag
            }

            Az.MobileNetwork.private\New-AzMobileNetworkDataNetwork_CreateExpanded @PSBoundParameters
        }
        catch {
            throw
        }
    }
}
