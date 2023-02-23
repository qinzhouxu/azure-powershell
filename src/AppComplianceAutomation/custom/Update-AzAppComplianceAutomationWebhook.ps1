
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
Update an exiting AppComplianceAutomation webhook.
.Description
Update an exiting AppComplianceAutomation webhook.

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.Api20230215Preview.IWebhookResourcePatch
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.Api20230215Preview.IWebhookResource
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

PARAMETER <IWebhookResourcePatch>: A class represent a AppComplianceAutomation webhook resource update properties.
  [EnableSslVerification <EnableSslVerification?>]: whether to enable ssl verification
  [Event <NotificationEvent[]>]: under which event notification should be sent.
  [PayloadUrl <String>]: webhook payload url
  [SendAllEvent <SendAllEvents?>]: whether to send notification under any event.
  [Status <WebhookStatus?>]: Webhook status.
  [UpdateWebhookKey <UpdateWebhookKey?>]: whether to update webhookKey.
  [WebhookKey <String>]: webhook secret token. If not set, this field value is null; otherwise, please set a string value.
.Link
https://learn.microsoft.com/powershell/module/az.appcomplianceautomation/update-azappcomplianceautomationwebhook
#>
function Update-AzAppComplianceAutomationWebhook {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.Api20230215Preview.IWebhookResource])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Update', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('WebhookName')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Category('Path')]
    [System.String]
    # Webhook Name.
    ${Name},

    [Parameter(ParameterSetName='Update', Mandatory)]
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Category('Path')]
    [System.String]
    # Report Name.
    ${ReportName},

    [Parameter(ParameterSetName='Update', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.Api20230215Preview.IWebhookResourcePatch]
    # A class represent a AppComplianceAutomation webhook resource update properties.
    # To construct, see NOTES section for PARAMETER properties and create a hash table.
    ${Parameter},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Support.EnableSslVerification])]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Support.EnableSslVerification]
    # whether to enable ssl verification
    ${EnableSslVerification},

    [Parameter(ParameterSetName='UpdateExpanded')]
    # whether to disable webhook
    ${Disable},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Support.SendAllEvents])]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Support.SendAllEvents]
    # whether to send notification under any event.
    ${TriggerMode},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [AllowEmptyCollection()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Support.NotificationEvent])]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Support.NotificationEvent[]]
    # under which event notification should be sent.
    ${Events},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Category('Body')]
    [System.String]
    # webhook payload url
    ${PayloadUrl},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Category('Body')]
    [System.String]
    # content type
    ${ContentType},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Category('Body')]
    [System.String]
    # webhook secret token.
    # If not set, this field value is null; otherwise, please set a string value.
    ${Secret},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

process {
    
}
}
