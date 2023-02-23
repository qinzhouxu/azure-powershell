@{
  GUID = '44dfbca8-6a2b-4f12-82e9-b09701628ac8'
  RootModule = './Az.AppComplianceAutomation.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: AppComplianceAutomation cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.AppComplianceAutomation.private.dll'
  FormatsToProcess = './Az.AppComplianceAutomation.format.ps1xml'
  FunctionsToExport = 'Get-AzAppComplianceAutomationReport', 'Get-AzAppComplianceAutomationReportControlAssessments', 'Get-AzAppComplianceAutomationWebhook', 'Invoke-AzAppComplianceAutomationDownloadReport', 'New-AzAppComplianceAutomationReport', 'New-AzAppComplianceAutomationWebhook', 'Remove-AzAppComplianceAutomationReport', 'Remove-AzAppComplianceAutomationWebhook', 'Start-AzAppComplianceAutomationQuickEvaluation', 'Update-AzAppComplianceAutomationReport', 'Update-AzAppComplianceAutomationWebhook', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'AppComplianceAutomation'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
