
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
Create an in-memory object for DeliveryRuleRouteConfigurationOverrideAction.
.Description
Create an in-memory object for DeliveryRuleRouteConfigurationOverrideAction.
.Example
$originGroupId = "xxxx"
New-AzFrontDoorCdnRuleRouteConfigurationOverrideActionObject -Name RouteConfigurationOverride -OriginGroupOverrideForwardingProtocol HttpOnly -OriginGroupId $originGroupId

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DeliveryRuleRouteConfigurationOverrideAction
.Link
https://learn.microsoft.com/powershell/module/az.Cdn/new-AzFrontDoorCdnRuleRouteConfigurationOverrideActionObject
#>
function New-AzFrontDoorCdnRuleRouteConfigurationOverrideActionObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.DeliveryRuleRouteConfigurationOverrideAction])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeliveryRuleAction])]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeliveryRuleAction]
    # The name of the action for the delivery rule.
    ${Name},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleCacheBehavior])]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleCacheBehavior]
    # Caching behavior for the requests.
    ${CacheConfigurationCacheBehavior},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.String]
    # The duration for which the content needs to be cached.
    # Allowed format is [d.]hh:mm:ss.
    ${CacheConfigurationCacheDuration},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleIsCompressionEnabled])]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleIsCompressionEnabled]
    # Indicates whether content compression is enabled.
    # If compression is enabled, content will be served as compressed if user requests for a compressed version.
    # Content won't be compressed on AzureFrontDoor when requested content is smaller than 1 byte or larger than 1 MB.
    ${CacheConfigurationIsCompressionEnabled},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.String]
    # query parameters to include or exclude (comma separated).
    ${CacheConfigurationQueryParameter},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleQueryStringCachingBehavior])]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.RuleQueryStringCachingBehavior]
    # Defines how Frontdoor caches requests that include query strings.
    # You can ignore any query strings when caching, ignore specific query strings, cache every request with a unique URL, or cache specific query strings.
    ${CacheConfigurationQueryStringCachingBehavior},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [System.String]
    # Resource ID.
    ${OriginGroupId},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ForwardingProtocol])]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ForwardingProtocol]
    # Protocol this rule will use when forwarding traffic to backends.
    ${OriginGroupOverrideForwardingProtocol}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $Host.Version.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.Cdn.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            __AllParameterSets = 'Az.Cdn.custom\New-AzFrontDoorCdnRuleRouteConfigurationOverrideActionObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.Cdn.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
