
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
Creates or updates a catalog.
.Description
Creates or updates a catalog.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.ICatalog
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.IDevCenterIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.ICatalog
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

BODY <ICatalog>: Represents a catalog.
  [SystemDataCreatedAt <DateTime?>]: The timestamp of resource creation (UTC).
  [SystemDataCreatedBy <String>]: The identity that created the resource.
  [SystemDataCreatedByType <CreatedByType?>]: The type of identity that created the resource.
  [SystemDataLastModifiedAt <DateTime?>]: The timestamp of resource last modification (UTC)
  [SystemDataLastModifiedBy <String>]: The identity that last modified the resource.
  [SystemDataLastModifiedByType <CreatedByType?>]: The type of identity that last modified the resource.
  [AdoGitBranch <String>]: Git branch.
  [AdoGitPath <String>]: The folder where the catalog items can be found inside the repository.
  [AdoGitSecretIdentifier <String>]: A reference to the Key Vault secret containing a security token to authenticate to a Git repository.
  [AdoGitUri <String>]: Git URI.
  [GitHubBranch <String>]: Git branch.
  [GitHubPath <String>]: The folder where the catalog items can be found inside the repository.
  [GitHubSecretIdentifier <String>]: A reference to the Key Vault secret containing a security token to authenticate to a Git repository.
  [GitHubUri <String>]: Git URI.

INPUTOBJECT <IDevCenterIdentity>: Identity Parameter
  [AttachedNetworkConnectionName <String>]: The name of the attached NetworkConnection.
  [CatalogName <String>]: The name of the Catalog.
  [DevBoxDefinitionName <String>]: The name of the Dev Box definition.
  [DevCenterName <String>]: The name of the devcenter.
  [EnvironmentTypeName <String>]: The name of the environment type.
  [GalleryName <String>]: The name of the gallery.
  [Id <String>]: Resource identity path
  [ImageName <String>]: The name of the image.
  [Location <String>]: The Azure region
  [NetworkConnectionName <String>]: Name of the Network Connection that can be applied to a Pool.
  [OperationId <String>]: The ID of an ongoing async operation
  [PoolName <String>]: Name of the pool.
  [ProjectName <String>]: The name of the project.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScheduleName <String>]: The name of the schedule that uniquely identifies it.
  [SubscriptionId <String>]: The ID of the target subscription.
  [VersionName <String>]: The version of the image.
.Link
https://learn.microsoft.com/powershell/module/az.devcenter/new-azdevcenteradmincatalog
#>
function New-AzDevCenterAdminCatalog {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.ICatalog])]
[CmdletBinding(DefaultParameterSetName='CreateExpandedAdo', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='CreateExpandedAdo', Mandatory)]
    [Parameter(ParameterSetName='CreateExpandedGitHub', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
    [System.String]
    # The name of the devcenter.
    ${DevCenterName},

    [Parameter(ParameterSetName='CreateExpandedAdo', Mandatory)]
    [Parameter(ParameterSetName='CreateExpandedGitHub', Mandatory)]
    [Alias('CatalogName')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
    [System.String]
    # The name of the Catalog.
    ${Name},

    [Parameter(ParameterSetName='CreateExpandedAdo', Mandatory)]
    [Parameter(ParameterSetName='CreateExpandedGitHub', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='CreateExpandedAdo', Mandatory)]
    [Parameter(ParameterSetName='CreateExpandedGitHub', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='CreateViaIdentityExpandedAdo', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='CreateViaIdentityExpandedGitHub', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.IDevCenterIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='CreateExpandedAdo')]
    [Parameter(ParameterSetName='CreateViaIdentityExpandedAdo')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [System.String]
    # Git branch.
    ${AdoGitBranch},

    [Parameter(ParameterSetName='CreateExpandedAdo')]
    [Parameter(ParameterSetName='CreateViaIdentityExpandedAdo')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [System.String]
    # The folder where the catalog items can be found inside the repository.
    ${AdoGitPath},

    [Parameter(ParameterSetName='CreateExpandedAdo', Mandatory)]
    [Parameter(ParameterSetName='CreateViaIdentityExpandedAdo', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [System.String]
    # A reference to the Key Vault secret containing a security token to authenticate to a Git repository.
    ${AdoGitSecretIdentifier},

    [Parameter(ParameterSetName='CreateExpandedAdo', Mandatory)]
    [Parameter(ParameterSetName='CreateViaIdentityExpandedAdo', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [System.String]
    # Git URI.
    ${AdoGitUri},

    [Parameter(ParameterSetName='CreateExpandedGitHub')]
    [Parameter(ParameterSetName='CreateViaIdentityExpandedGitHub')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [System.String]
    # Git branch.
    ${GitHubBranch},

    [Parameter(ParameterSetName='CreateExpandedGitHub')]
    [Parameter(ParameterSetName='CreateViaIdentityExpandedGitHub')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [System.String]
    # The folder where the catalog items can be found inside the repository.
    ${GitHubPath},

    [Parameter(ParameterSetName='CreateExpandedGitHub', Mandatory)]
    [Parameter(ParameterSetName='CreateViaIdentityExpandedGitHub', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [System.String]
    # A reference to the Key Vault secret containing a security token to authenticate to a Git repository.
    ${GitHubSecretIdentifier},

    [Parameter(ParameterSetName='CreateExpandedGitHub', Mandatory)]
    [Parameter(ParameterSetName='CreateViaIdentityExpandedGitHub', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
    [System.String]
    # Git URI.
    ${GitHubUri},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)


process {
    Az.DevCenter.internal\New-AzDevCenterAdminCatalog @PSBoundParameters
}

}
