
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
Upgrade a profile from Standard_AzureFrontDoor to Premium_AzureFrontDoor.
.Description
Upgrade a profile from Standard_AzureFrontDoor to Premium_AzureFrontDoor.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IProfileUpgradeParameters
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IProfile
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

PROFILEUPGRADEPARAMETER <IProfileUpgradeParameters>: Parameters required for profile upgrade.
  WafMappingList <IProfileChangeSkuWafMapping[]>: Web Application Firewall (WAF) and security policy mapping for the profile upgrade
    SecurityPolicyName <String>: The security policy name.
    [ChangeToWafPolicyId <String>]: Resource ID.

WAFMAPPINGLIST <IProfileChangeSkuWafMapping[]>: Web Application Firewall (WAF) and security policy mapping for the profile upgrade
  SecurityPolicyName <String>: The security policy name.
  [ChangeToWafPolicyId <String>]: Resource ID.
.Link
https://docs.microsoft.com/powershell/module/az.cdn/update-azfrontdoorcdnprofilesku
#>
function Update-AzFrontDoorCdnProfileSku {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IProfile])]
    [CmdletBinding(DefaultParameterSetName='Upgrade', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(ParameterSetName='Upgrade', Mandatory)]
        [Parameter(ParameterSetName='UpgradeExpanded', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
        [System.String]
        # Name of the Azure Front Door Standard or Azure Front Door Premium which is unique within the resource group.
        ${ProfileName},
    
        [Parameter(ParameterSetName='Upgrade', Mandatory)]
        [Parameter(ParameterSetName='UpgradeExpanded', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
        [System.String]
        # Name of the Resource group within the Azure subscription.
        ${ResourceGroupName},
    
        [Parameter(ParameterSetName='Upgrade')]
        [Parameter(ParameterSetName='UpgradeExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # Azure Subscription ID.
        ${SubscriptionId},

        [Parameter(ParameterSetName='Upgrade', Mandatory, ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IProfileUpgradeParameters]
        # Parameters required for profile upgrade.
        # To construct, see NOTES section for PROFILEUPGRADEPARAMETER properties and create a hash table.
        ${ProfileUpgradeParameter},
    
        [Parameter(ParameterSetName='UpgradeExpanded', Mandatory)]
        [AllowEmptyCollection()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IProfileChangeSkuWafMapping[]]
        # Web Application Firewall (WAF) and security policy mapping for the profile upgrade
        # To construct, see NOTES section for WAFMAPPINGLIST properties and create a hash table.
        ${WafMappingList},
    
        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The credentials, account, tenant, and subscription used for communication with Azure.
        ${DefaultProfile},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command as a job
        ${AsJob},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command asynchronously
        ${NoWait},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )
    
    process {
        if ($PSCmdlet.ParameterSetName -eq 'Update' -or $PSCmdlet.ParameterSetName -eq 'UpdateExpanded') {
            $frontDoorCdnProfile = Get-AzFrontDoorCdnProfile -ResourceGroupName ${ResourceGroupName} -ProfileName ${ProfileName}
        }else {
            throw "Not supported ParameterSetName."
        }

        if ($null -eq $frontDoorCdnProfile)
        {
            throw "Provided FrontDoorCdnProfile does not exist."
        }

        if($PSBoundParameters.ProfileUpgradeParameter -ne "@{}") {
            if(!(Get-Module -ListAvailable -Name Az.FrontDoor)) {
                throw 'Please install Az.FrontDoor module by entering "Install-Module -Name Az.FrontDoor"'
            }
            else {
                Import-Module -Name Az.FrontDoor
            }

            $wafPolicies = $PSBoundParameters.ProfileUpgradeParameter
            if($WafPolicies.count -gt 0) {
                # Validate the format of the WafID
                foreach ($policy in $wafPolicies) {
                    $policyName = $policy.SecurityPolicyName
                    ParseWafResourceId -WafResourceId $policy.ChangeToWafPolicyId
                }
                
                foreach ($policy in $wafPolicies) {
                    $changeToWafPolicy = $policy.ChangeToWafPolicyId
                    $changeToWafPolicyName = $changeToWafPolicy.split("/")[8]
                    New-AzFrontDoorWafPolicy -ResourceGroupName ${ResourceGroupName} -Name $changeToWafPolicyName
                }
            }
        }
        Az.Cdn.internal\Update-AzFrontDoorCdnProfileSku @PSBoundParameters
    }
}

function ParseWafResourceId{
    param (
        [string]$WafResourceId
    )

    $array = $WafResourceId.ToLower().split('/')
    if ($array.Length -ne 9){
        throw 'Format of WebApplicationFirewallMapping is not correct, please check the parameter.'
    }
    if ($SplitInfo[1] -gt "subscriptions" -or $SplitInfo[3] -gt "resourceGroups" -or $SplitInfo[5] -gt "providers" -or $SplitInfo[6] -gt "Microsoft.Network" -or $SplitInfo[7] -gt "frontdoorWebApplicationFirewallPolicies") {
        throw 'Format of WebApplicationFirewallMapping is not correct, please check the parameter.'
    }
}