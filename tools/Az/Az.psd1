#
# Module manifest for module 'Az'
#
# Generated by: Microsoft Corporation
#
# Generated on: 2023/2/3
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '9.4.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'd48d710e-85cb-46a1-990f-22dae76f6b5f'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Cmdlets to manage resources in Azure. This module is compatible with PowerShell and Windows PowerShell.
For more information about the Az module, please visit the following: https://docs.microsoft.com/powershell/azure/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.11.2'; }, 
               @{ModuleName = 'Az.Advisor'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Aks'; RequiredVersion = '5.3.0'; }, 
               @{ModuleName = 'Az.AnalysisServices'; RequiredVersion = '1.1.4'; }, 
               @{ModuleName = 'Az.ApiManagement'; RequiredVersion = '4.0.2'; }, 
               @{ModuleName = 'Az.AppConfiguration'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.ApplicationInsights'; RequiredVersion = '2.2.2'; }, 
               @{ModuleName = 'Az.Attestation'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Automation'; RequiredVersion = '1.9.0'; }, 
               @{ModuleName = 'Az.Batch'; RequiredVersion = '3.3.0'; }, 
               @{ModuleName = 'Az.Billing'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Cdn'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.CloudService'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.CognitiveServices'; RequiredVersion = '1.12.0'; }, 
               @{ModuleName = 'Az.Compute'; RequiredVersion = '5.4.0'; }, 
               @{ModuleName = 'Az.ConfidentialLedger'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.ContainerInstance'; RequiredVersion = '3.1.0'; }, 
               @{ModuleName = 'Az.ContainerRegistry'; RequiredVersion = '3.0.1'; }, 
               @{ModuleName = 'Az.CosmosDB'; RequiredVersion = '1.9.0'; }, 
               @{ModuleName = 'Az.DataBoxEdge'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Databricks'; RequiredVersion = '1.4.0'; }, 
               @{ModuleName = 'Az.DataFactory'; RequiredVersion = '1.16.12'; }, 
               @{ModuleName = 'Az.DataLakeAnalytics'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.DataLakeStore'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.DataProtection'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.DataShare'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.DesktopVirtualization'; RequiredVersion = '3.1.1'; }, 
               @{ModuleName = 'Az.DeploymentManager'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.DevTestLabs'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Dns'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.EventGrid'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.EventHub'; RequiredVersion = '3.2.1'; }, 
               @{ModuleName = 'Az.FrontDoor'; RequiredVersion = '1.9.0'; }, 
               @{ModuleName = 'Az.Functions'; RequiredVersion = '4.0.6'; }, 
               @{ModuleName = 'Az.HDInsight'; RequiredVersion = '5.0.1'; }, 
               @{ModuleName = 'Az.HealthcareApis'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.IotHub'; RequiredVersion = '2.7.4'; }, 
               @{ModuleName = 'Az.KeyVault'; RequiredVersion = '4.9.1'; }, 
               @{ModuleName = 'Az.Kusto'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.LogicApp'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.MachineLearning'; RequiredVersion = '1.1.3'; }, 
               @{ModuleName = 'Az.Maintenance'; RequiredVersion = '1.2.1'; }, 
               @{ModuleName = 'Az.ManagedServiceIdentity'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.ManagedServices'; RequiredVersion = '3.0.0'; }, 
               @{ModuleName = 'Az.MarketplaceOrdering'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Media'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.Migrate'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.Monitor'; RequiredVersion = '4.4.1'; }, 
               @{ModuleName = 'Az.MySql'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Network'; RequiredVersion = '5.4.0'; }, 
               @{ModuleName = 'Az.NotificationHubs'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.OperationalInsights'; RequiredVersion = '3.2.0'; }, 
               @{ModuleName = 'Az.PolicyInsights'; RequiredVersion = '1.5.1'; }, 
               @{ModuleName = 'Az.PostgreSql'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.PowerBIEmbedded'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.PrivateDns'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.RecoveryServices'; RequiredVersion = '6.2.0'; }, 
               @{ModuleName = 'Az.RedisCache'; RequiredVersion = '1.7.1'; }, 
               @{ModuleName = 'Az.RedisEnterpriseCache'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Relay'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.ResourceMover'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Resources'; RequiredVersion = '6.5.2'; }, 
               @{ModuleName = 'Az.Security'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.SecurityInsights'; RequiredVersion = '3.0.1'; }, 
               @{ModuleName = 'Az.ServiceBus'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.ServiceFabric'; RequiredVersion = '3.1.0'; }, 
               @{ModuleName = 'Az.SignalR'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.Sql'; RequiredVersion = '4.3.0'; }, 
               @{ModuleName = 'Az.SqlVirtualMachine'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.StackHCI'; RequiredVersion = '1.4.2'; }, 
               @{ModuleName = 'Az.Storage'; RequiredVersion = '5.4.0'; }, 
               @{ModuleName = 'Az.StorageSync'; RequiredVersion = '1.7.0'; }, 
               @{ModuleName = 'Az.StreamAnalytics'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Support'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Synapse'; RequiredVersion = '2.2.0'; }, 
               @{ModuleName = 'Az.TrafficManager'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.Websites'; RequiredVersion = '2.12.1'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ARM','ResourceManager','Linux','AzureAutomationNotSupported'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '9.4.0 - February 2023
Az.Accounts
* Supported Web Account Manager on ARM64-based Windows systems. Fixed an issue where ''Connect-AzAccount'' failed with error ''Unable to load DLL ''msalruntime_arm64''''. [#20700]
* Enabled credential to be found only by applicationId while tenant was not matched when accquire token. [#20484]
* When Az.Accounts ran in parallel, the waiters were allowed to wait infinitely to avoid throw exception in automation enviroment. [#20455]

Az.Aks
* Added parameter ''-AadProfile'' for ''New-AzAksCluster'' and ''Set-AzAksCluster''
* Added parameter ''-NodeHostGroupID'' for ''New-AzAksCluster'' and parameter ''-HostGroupID'' for ''New-AzAksNodePool''

Az.ApplicationInsights
* Added parameter validation for ''Get-AzApplicationInsights'' [#20697]

Az.Compute
* Added ''-SkipIdentity'', ''-PathUserIdentity'', ''-IsTest'' parameter to ''Set-AzVMAEMExtension'' 
* Added ''ConsistencyMode'' parameter to ''New-AzRestorePoint''.
* Updated the storage account type value in several locations from the outdated ''StandardLRS'' to the current ''Standard_LRS''.
* Filled in missing parameter descriptions across multiple parameters and improved some existing parameter descriptions.
* Updated Compute PS to use the new .Net SDK version 59.0.0. This includes an approved breaking change for a non-functional feature. 
  - The type of the property ''Source'' of type ''Microsoft.Azure.Management.Compute.Models.GalleryDataDiskImage'', ''Microsoft.Azure.Management.Compute.Models.GalleryOSDiskImage'', and ''Microsoft.Azure.Management.Compute.Models.GalleryImageVersionStorageProfile'' has changed from ''Microsoft.Azure.Management.Compute.Models.GalleryArtifactVersionSource'' to ''Microsoft.Azure.Management.Compute.Models.GalleryDiskImageSource''.
* Updated the broken ''UbuntuLTS'' image alias to use its original sku version of ''16.04-LTS'' instead of the nonexistent image ''20.04-LTS''. This fixes an issue introduced in the version 5.3.0 release. 
* Updated Set-AzVMRunCommand and Set-AzVmssRunCommand ScriptLocalPath parameter set to work with Linux and with files that have comments.
* Added ''-TargetExtendedLocation'' parameter to ''New-AzGalleryImageVersion'' and ''Update-AzGalleryImageVersion''
* Added ''-AllowDeletionOfReplicatedLocation'' to ''Update-AzGalleryImageVersion''

Az.DataFactory
* Updated ADF .Net SDK version to 9.0.0

Az.DataProtection
* Added support for Immutable backup vaults
* Added Cross subscription restore flag for backup vaults
* Added Soft delete setting for backup vaults
* Fixed issue with Set-AzDataProtectionMSIPermission command
* Replaced Get-InstalledModule with Get-Module -ListAvailable
* Added New-AzDataProtectionSoftDeleteSettingObject command

Az.EventHub
* Fixed ''New-AzEventHubAuthorizationRuleSASToken'' cmdlet which was returning wrong skn value

Az.Monitor
* Removed default value for time window for autoscale profile [#20660]
  * ''Get-AzAutoscaleSetting''
  * ''New-AzAutoscaleSetting''

Az.Network
* Fixed a bug that does not enable to set Perform SNAT to Always
* Fixed the incorrect type of ''-TotalBytesPerSession'' in ''New-AzNetworkWatcherPacketCapture''

Az.RecoveryServices
* Added support for enable/disable Public Network Access and PrivateEndpoints
* Added support for Immutable Vaults
* Added support for RetainRecoveryPointsAsPerPolicy in Disable-AzRecoveryServicesBackupProtection cmdlet. Now user can suspend backups and retain RPs as per policy
* Added List Recovery Point expiry time
* Added RecoveryServices, RecoveryServices.Backup, RecoveryServices.Backup.CrossRegionRestore management SDK
* Added support for non-UTC time zones with standard policy for workloadType IaasVM, MSSql, AzureFiles

Az.RedisCache
* Updated ''Get-AzRedisCacheLink'' and ''New-AzRedisCacheLink'' to print ''PrimaryHostName'', ''GeoReplicatedPrimaryHostName'', ''ServerRole'', and ''LinkedRedisCacheLocation''.

Az.Resources
* Fixed query issue when objectId in assignment is empty for ''Get-DenyAssignment''
* Fixed an issue where running deployment cmdlets with ''-WhatIf'' throws exception when formatting results with nested array changes

Az.Sql
* Added an optional parameter ''HAReplicaCount'' to ''Restore-AzSqlDatabase''
* Added new cmdlets for managed instance DTC
    ''Get-AzSqlInstanceDtc''
    ''Set-AzSqlInstanceDtc''
* Added ''TargetSubscriptionId'' to ''Restore-AzSqlInstanceDatabase'' in order to enable cross subscription restore
* Enabled support for UserAssignedManagedIdentity in Auditing
* Fixed WorkspaceResourceId parameter value in ''Set-AzSqlServerAudit''

Az.StackHCI
* Added Remote Support terms and conditions for HCI device types.
* Unified Resource Group support for both Azure Stack HCI and Arc for server resources.
* Enhanced error feedback and logging in the Register-AzStackHCI cmdlet.
* Bug fixes and improvements in Azure Arc for servers enablement in Register-AzStackHCI cmdlet.
* Improved parameter validations in the Register-AzStackHCI cmdlet.
* Enabled Managed System Identity (MSI) for Registration in Fairfax Cloud.
* Minor bug fixes and improvements.

Az.Storage
* Added a warning message for the upcoming breaking change when creating a Storage account
    - ''New-AzStorageAccount''
* Removed the ValidateSet of StandardBlobTier parameter
    - ''Copy-AzStorageBlob''
    - ''Set-AzStorageBlobContent'' 
    - ''Start-AzStorageBlobCopy''

Az.TrafficManager
* Added a new optional parameter ''AlwaysServe'' for endpoints.
'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

