---
external help file:
Module Name: Az.Acat
online version: https://learn.microsoft.com/powershell/module/az.acat/new-azacatwebhookresourceobject
schema: 2.0.0
---

# New-AzAcatWebhookResourceObject

## SYNOPSIS
Create an in-memory object for WebhookResource.

## SYNTAX

```
New-AzAcatWebhookResourceObject [-ContentType <String>] [-Disable <Boolean>]
 [-EnableSslVerification <EnableSslVerification>] [-Events <NotificationEvent[]>] [-PayloadUrl <String>]
 [-Secret <String>] [-TriggerMode <SendAllEvents>] [<CommonParameters>]
```

## DESCRIPTION
Create an in-memory object for WebhookResource.

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -ContentType
content type

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Disable
whether to disable webhook

```yaml
Type: System.Boolean
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnableSslVerification
whether to enable ssl verification

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Acat.Support.EnableSslVerification
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Events
under which event notification should be sent.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Acat.Support.NotificationEvent[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PayloadUrl
webhook payload url

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Secret
webhook secret token.
If not set, this field value is null; otherwise, please set a string value.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TriggerMode
whether to send notification under any event.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Acat.Support.SendAllEvents
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Acat.Models.Api20230215Preview.IWebhookResource

## NOTES

ALIASES

## RELATED LINKS

