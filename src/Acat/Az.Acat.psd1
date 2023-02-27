@{
  GUID = '181ba138-c31b-435b-b736-7346c340f4ba'
  RootModule = './Az.Acat.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: Acat cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.Acat.private.dll'
  FormatsToProcess = './Az.Acat.format.ps1xml'
  FunctionsToExport = 'Get-AzAcatControlAssessments', 'Get-AzAcatReport', 'Get-AzAcatWebhook', 'Invoke-AzAcatDownloadReport', 'New-AzAcatReport', 'New-AzAcatReportResourceObject', 'New-AzAcatWebhook', 'New-AzAcatWebhookResourceObject', 'Remove-AzAcatReport', 'Remove-AzAcatWebhook', 'Start-AzAcatQuickEvaluation', 'Update-AzAcatReport', 'Update-AzAcatWebhook', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'Acat'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
