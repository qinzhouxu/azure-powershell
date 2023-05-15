
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
Create an in-memory object for DataBoxHeavyJobDetails.
.Description
Create an in-memory object for DataBoxHeavyJobDetails.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20221201.DataBoxHeavyJobDetails
.Link
https://learn.microsoft.com/powershell/module/Az.DataBox/new-AzDataBoxHeavyJobDetailsObject
#>
function New-AzDataBoxHeavyJobDetailsObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20221201.DataBoxHeavyJobDetails')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="Set Device password for unlocking Databox Heavy. Should not be passed for TransferType:ExportFromAzure jobs. If this is not passed, the service will generate password itself. This will not be returned in Get Call. Password Requirements :  Password must be minimum of 12 and maximum of 64 characters. Password must have at least one uppercase alphabet, one number and one special character. Password cannot have the following characters : IilLoO0 Password can have only alphabets, numbers and these characters : @#\-$%^!+=;:_()]+.")]
        [string]
        $DevicePassword,
        [Parameter(Mandatory, HelpMessage="Contact details for notification and shipping.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20221201.IContactDetails]
        $ContactDetail,
        [Parameter(HelpMessage="Details of the data to be exported from azure.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20221201.IDataExportDetails[]]
        $DataExportDetail,
        [Parameter(HelpMessage="Details of the data to be imported into azure.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20221201.IDataImportDetails[]]
        $DataImportDetail,
        [Parameter(HelpMessage="The expected size of the data, which needs to be transferred in this job, in terabytes.")]
        [int]
        $ExpectedDataSizeInTeraByte,
        [Parameter(HelpMessage="Details about which key encryption type is being used.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20221201.IKeyEncryptionKey]
        $KeyEncryptionKey,
        [Parameter(HelpMessage="Preferences for the order.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20221201.IPreferences]
        $Preference,
        [Parameter(HelpMessage="Optional Reverse Shipping details for order.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20221201.IReverseShippingDetails]
        $ReverseShippingDetail,
        [Parameter(HelpMessage="Shipping address of the customer.")]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20221201.IShippingAddress]
        $ShippingAddress,
        [Parameter(Mandatory, HelpMessage="Indicates the type of job details.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator])]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator]
        $Type
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20221201.DataBoxHeavyJobDetails]::New()

        if ($PSBoundParameters.ContainsKey('DevicePassword')) {
            $Object.DevicePassword = $DevicePassword
        }
        if ($PSBoundParameters.ContainsKey('ContactDetail')) {
            $Object.ContactDetail = $ContactDetail
        }
        if ($PSBoundParameters.ContainsKey('DataExportDetail')) {
            $Object.DataExportDetail = $DataExportDetail
        }
        if ($PSBoundParameters.ContainsKey('DataImportDetail')) {
            $Object.DataImportDetail = $DataImportDetail
        }
        if ($PSBoundParameters.ContainsKey('ExpectedDataSizeInTeraByte')) {
            $Object.ExpectedDataSizeInTeraByte = $ExpectedDataSizeInTeraByte
        }
        if ($PSBoundParameters.ContainsKey('KeyEncryptionKey')) {
            $Object.KeyEncryptionKey = $KeyEncryptionKey
        }
        if ($PSBoundParameters.ContainsKey('Preference')) {
            $Object.Preference = $Preference
        }
        if ($PSBoundParameters.ContainsKey('ReverseShippingDetail')) {
            $Object.ReverseShippingDetail = $ReverseShippingDetail
        }
        if ($PSBoundParameters.ContainsKey('ShippingAddress')) {
            $Object.ShippingAddress = $ShippingAddress
        }
        if ($PSBoundParameters.ContainsKey('Type')) {
            $Object.Type = $Type
        }
        return $Object
    }
}

