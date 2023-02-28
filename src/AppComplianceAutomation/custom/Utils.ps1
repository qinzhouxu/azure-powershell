function Get-Resource-Subscriptions {
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.DoNotExportAttribute()]
    param(
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.Api20230215Preview.IResourceMetadata[]]
        $Resources
    )
    $SubscriptionSet = [Collections.Generic.HashSet[string]]@()
    foreach ($Resource in $Resources) {
        try {
            $Strs = $Resource.ResourceId.Split("/")
            if ($Strs.Count -lt 3) {
                Write-Error "Please input valid resource ids"
            }
            $null = $SubscriptionSet.Add($Strs[2])
        }
        catch {
            Write-Error "Please input valid resource ids"
        }
    }
    $Result = New-Object string[] $SubscriptionSet.Count
    $null = $SubscriptionSet.CopyTo($Result)
    return $Result
}

function Get-Nearest-Time {
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.DoNotExportAttribute()]
    param()
    $RoundedDate = Get-Date -Minute 0 -Second 0 -Millisecond 0
    return $RoundedDate.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffK")
}

function Get-Token {
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.DoNotExportAttribute()]
    param()
    return "Bearer " + (Get-AzAccessToken).Token
}

function Add-Custom-Header {
    [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.DoNotExportAttribute()]
    param(
        [Parameter(Mandatory)]
        $PSBoundParameters
    )
    if (-Not $PSBoundParameters.ContainsKey('XmsAadUserToken')) {
        $PSBoundParameters['XmsAadUserToken'] = Get-Token
    }
    return $PSBoundParameters
}
