
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
    [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.PreviewMessageAttribute("This cmdlet is using a preview API version and is subject to breaking change in a future release.")]
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IProfile])]
    [CmdletBinding(PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
        [System.String]
        # Name of the Azure Front Door Standard or Azure Front Door Premium which is unique within the resource group.
        ${ProfileName},
    
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
        [System.String]
        # Name of the Resource group within the Azure subscription.
        ${ResourceGroupName},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # Azure Subscription ID.
        ${SubscriptionId},

        [Parameter(Mandatory, ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IProfileUpgradeParameters]
        # Parameters required for profile upgrade.
        # To construct, see NOTES section for PROFILEUPGRADEPARAMETER properties and create a hash table.
        ${ProfileUpgradeParameter},
    
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
        if(!(Get-Module -ListAvailable -Name Az.FrontDoor)) {
            throw 'Please install Az.FrontDoor module by entering "Install-Module -Name Az.FrontDoor"'
        }
        Import-Module -Name Az.FrontDoor

        $wafPolicies = $PSBoundParameters.ProfileUpgradeParameter
        $validateWafId = "^/subscriptions/(?<subscriptionId>[^/]+)/resourcegroups/(?<resourceGroupName>[^/]+)/providers/microsoft.network/frontdoorwebapplicationfirewallpolicies/(?<policyName>[^/]+)$"

        if($wafPolicies.count -ne 0) {
            # 1. Validate the format of the waf ID
            foreach ($wafMapping in $wafPolicies.WafMappingList) {
                $changeToWafPolciy = $wafMapping.ChangeToWafPolicyId
                if ($changeToWafPolciy.ToLower() -notmatch $validateWafId) {
                    throw "The format of Waf policy id is supposed to be like '/subscriptions/*******/resourceGroups/****/providers/Microsoft.Network/frontdoorWebApplicationFirewallPolicies/******' "
                }
            }

            foreach ($wafMapping in $wafPolicies.wafMappingList) {
                $changeToWafPolicy = $wafMapping.ChangeToWafPolicyId
                $changeToWafPolicyName = $changeToWafPolicy.split("/")[8]
                if ($changeToWafPolicyName -notmatch '(^[a-zA-Z]+)\w+$') {
                    throw "The WAF name must begin with a letter, and may only contain numbers and letters."
                }
                $changeToWafPolicyResourceGroup = $changeToWafPolicy.split("/")[4]

                # 2. Validate whether the policy already exists in the subsrciption
                try {
                    Get-AzFrontDoorWafPolicy -ResourceGroupName $changeToWafPolicyResourceGroup -Name $changeToWafPolicyName -ErrorAction Stop | Out-Null
                }
                catch {
                    $policyName = $wafMapping.SecurityPolicyName
                    # Get the waf policy name of the security.
                    try{
                        $policyNameProperty = Get-AzFrontDoorCdnSecurityPolicy -ResourceGroupName ${ResourceGroupName} -ProfileName ${ProfileName} -Name $policyName -ErrorAction Stop
                    }
                    catch {
                        throw 'Security policy name not exists in this profile...'
                    }
                    $currentWafName = $policyNameProperty.Parameter.WafPolicyId.split("/")[8]
                    $currentWafResourceGroup = $policyNameProperty.Parameter.WafPolicyId.split("/")[4]
                    $wafPolicyProperty = Get-AzFrontDoorWafPolicy -ResourceGroupName $currentWafResourceGroup -Name $currentWafName

                    # Create a new waf policy. 
                    CreatePremiumWafPolicy -ResourceGroupName $changeToWafPolicyResourceGroup -Name $changeToWafPolicyName -WafProperty $wafPolicyProperty
                }
            }
        }

        Az.Cdn.internal\Update-AzFrontDoorCdnProfileSku @PSBoundParameters
    }
}


# Corresponding to "Copy to a new waf policy"
function CreatePremiumWafPolicy {
    param (
        [string]$ResourceGroupName,
        [string]$Name,
        [Microsoft.Azure.Commands.FrontDoor.Models.PSTrackedResource]$WafProperty
    )

    # Remove the null/empty property
    $validatedWafProperty = ValidateWafPolicyProperty $WafProperty

    New-AzFrontDoorWafPolicy -ResourceGroupName $ResourceGroupName -Name $Name -Sku "Premium_AzureFrontDoor" @validatedWafProperty  | Out-Null
}

# Validate the property of a waf policy
function ValidateWafPolicyProperty {
    param (
        [Microsoft.Azure.Commands.FrontDoor.Models.PSTrackedResource]$WafProperty
    )

    $wafPropertHash = @{}
    if ($WafProperty.PolicyEnabledState) {
        $wafPropertHash.Add('EnabledState', $WafProperty.PolicyEnabledState)
    } 
    if ($WafProperty.PolicyMode) {
        $wafPropertHash.Add('Mode', $WafProperty.PolicyMode)
    }
    if ($WafProperty.CustomRules) {
        $wafPropertHash.Add('Customrule', $WafProperty.CustomRules)
    }
    if ($WafProperty.ManagedRules) {
        $wafPropertHash.Add('ManagedRule', $WafProperty.ManagedRules)
    }
    if ($WafProperty.RedirectUrl) {
        $wafPropertHash.Add('RedirectUrl', $WafProperty.RedirectUrl)
    }
    if ($WafProperty.CustomBlockResponseStatusCode) {
        $wafPropertHash.Add('CustomBlockResponseStatusCode', $WafProperty.CustomBlockResponseStatusCode)
    }
    if ($WafProperty.CustomBlockResponseBody) {
        $wafPropertHash.Add('CustomBlockResponseBody', $WafProperty.CustomBlockResponseBody)
    }
    if ($WafProperty.RequestBodyCheck) {
        $wafPropertHash.Add('RequestBodyCheck', $WafProperty.RequestBodyCheck)
    }
    return $wafPropertHash
}
