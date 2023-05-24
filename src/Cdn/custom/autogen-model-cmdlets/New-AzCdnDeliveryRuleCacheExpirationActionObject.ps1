
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
Create an in-memory object for DeliveryRuleCacheExpirationAction.
.Description
Create an in-memory object for DeliveryRuleCacheExpirationAction.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.DeliveryRuleCacheExpirationAction
.Link
https://learn.microsoft.com/powershell/module/Az.Cdn/new-AzCdnDeliveryRuleCacheExpirationActionObject
#>
function New-AzCdnDeliveryRuleCacheExpirationActionObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.DeliveryRuleCacheExpirationAction')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="Caching behavior for the requests.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CacheBehavior])]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.CacheBehavior]
        $ParameterCacheBehavior,
        [Parameter(HelpMessage="The duration for which the content needs to be cached. Allowed format is [d.]hh:mm:ss.")]
        [string]
        $ParameterCacheDuration,
        [Parameter(Mandatory, HelpMessage="The name of the action for the delivery rule.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeliveryRuleAction])]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DeliveryRuleAction]
        $Name
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.DeliveryRuleCacheExpirationAction]::New()

        if ($PSBoundParameters.ContainsKey('ParameterCacheBehavior')) {
            $Object.ParameterCacheBehavior = $ParameterCacheBehavior
        }
        if ($PSBoundParameters.ContainsKey('ParameterCacheDuration')) {
            $Object.ParameterCacheDuration = $ParameterCacheDuration
        }
        if ($PSBoundParameters.ContainsKey('Name')) {
            $Object.Name = $Name
        }
        return $Object
    }
}

