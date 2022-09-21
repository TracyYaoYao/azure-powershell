
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
Create an in-memory object for DeliveryRuleResponseHeaderAction.
.Description
Create an in-memory object for DeliveryRuleResponseHeaderAction.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20220501Preview.DeliveryRuleResponseHeaderAction
.Link
https://docs.microsoft.com/powershell/module/az.Cdn/new-AzFrontDoorCdnRuleResponseHeaderActionObject
#>
function New-AzFrontDoorCdnRuleResponseHeaderActionObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20220501Preview.DeliveryRuleResponseHeaderAction')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="Action to perform.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HeaderAction])]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.HeaderAction]
        $ParameterHeaderAction,
        [Parameter(Mandatory, HelpMessage="Name of the header to modify.")]
        [string]
        $ParameterHeaderName,
        [Parameter(HelpMessage="Value for the specified action.")]
        [string]
        $ParameterValue,
        [Parameter(Mandatory, HelpMessage="The name of the action for the delivery rule.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeliveryRuleAction])]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeliveryRuleAction]
        $Name
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20220501Preview.DeliveryRuleResponseHeaderAction]::New()

        if ($PSBoundParameters.ContainsKey('ParameterHeaderAction')) {
            $Object.ParameterHeaderAction = $ParameterHeaderAction
        }
        if ($PSBoundParameters.ContainsKey('ParameterHeaderName')) {
            $Object.ParameterHeaderName = $ParameterHeaderName
        }
        if ($PSBoundParameters.ContainsKey('ParameterValue')) {
            $Object.ParameterValue = $ParameterValue
        }
        if ($PSBoundParameters.ContainsKey('Name')) {
            $Object.Name = $Name
        }
        return $Object
    }
}

