
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
Create an in-memory object for AzureSqlDatabaseScanRuleset.
.Description
Create an in-memory object for AzureSqlDatabaseScanRuleset.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20211001Preview.AzureSqlDatabaseScanRuleset
.Link
https://docs.microsoft.com/powershell/module/az.Purview/new-AzPurviewAzureSqlDatabaseScanRulesetObject
#>
function New-AzPurviewAzureSqlDatabaseScanRulesetObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20211001Preview.AzureSqlDatabaseScanRuleset')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter()]
        [string]
        $Description,
        [Parameter()]
        [string[]]
        $ExcludedSystemClassification,
        [Parameter()]
        [string[]]
        $IncludedCustomClassificationRuleName,
        [Parameter(Mandatory)]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.DataSourceType])]
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.DataSourceType]
        $Kind,
        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ScanRulesetType])]
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ScanRulesetType]
        $Type
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20211001Preview.AzureSqlDatabaseScanRuleset]::New()

        if ($PSBoundParameters.ContainsKey('Description')) {
            $Object.Description = $Description
        }
        if ($PSBoundParameters.ContainsKey('ExcludedSystemClassification')) {
            $Object.ExcludedSystemClassification = $ExcludedSystemClassification
        }
        if ($PSBoundParameters.ContainsKey('IncludedCustomClassificationRuleName')) {
            $Object.IncludedCustomClassificationRuleName = $IncludedCustomClassificationRuleName
        }
        if ($PSBoundParameters.ContainsKey('Kind')) {
            $Object.Kind = $Kind
        }
        if ($PSBoundParameters.ContainsKey('Type')) {
            $Object.Type = $Type
        }
        return $Object
    }
}

