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
Migrate the CDN profile to Azure Frontdoor(Standard/Premium) profile.
The change need to be committed after this.
.Description
Migrate the CDN profile to Azure Frontdoor(Standard/Premium) profile.
The change need to be committed after this.
.Example
PS C:\> {{ Add code here }}
{{ Add output here }}
.Example
PS C:\> {{ Add code here }}
{{ Add output here }}
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IMigrateResult

MIGRATIONPARAMETER <IMigrationParameters>: Request body for Migrate operation.
  ProfileName <String>: Name of the new profile that need to be created.
  [ClassicResourceReferenceId <String>]: Resource ID.
  [MigrationWebApplicationFirewallMapping <IMigrationWebApplicationFirewallMapping[]>]: Waf mapping for the migrated profile
    [MigratedFromId <String>]: Resource ID.
    [MigratedToId <String>]: Resource ID.
  [SkuName <SkuName?>]: Name of the pricing tier.

MIGRATIONWEBAPPLICATIONFIREWALLMAPPING <IMigrationWebApplicationFirewallMapping[]>: Waf mapping for the migrated profile
  [MigratedFromId <String>]: Resource ID.
  [MigratedToId <String>]: Resource ID.
  
.Link
https://docs.microsoft.com/powershell/module/az.cdn/start-azfrontdoorcdnprofilepreparemigration
#>
function Start-AzFrontDoorCdnProfilePrepareMigration {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IMigrateResult])]
    [CmdletBinding(DefaultParameterSetName='MigrateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
        [System.String]
        # Name of the Resource group within the Azure subscription.
        ${ResourceGroupName},

        [Parameter(ParameterSetName='MigrateExpanded', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [System.String]
        # Resource ID.
        ${ClassicResourceReferenceId},

        [Parameter(ParameterSetName='MigrateExpanded', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [System.String]
        # Name of the new profile that need to be created.
        ${ProfileName},

        [Parameter(ParameterSetName='MigrateExpanded', Mandatory)]
        [ValidateNotNull()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SkuName])]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SkuName]
        # Name of the pricing tier.
        ${SkuName},

        [Parameter(ParameterSetName='MigrateExpanded')]
        [AllowEmptyCollection()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IMigrationWebApplicationFirewallMapping[]]
        # Waf mapping for the migrated profile
        # To construct, see NOTES section for MIGRATIONWEBAPPLICATIONFIREWALLMAPPING properties and create a hash table.
        ${MigrationWebApplicationFirewallMapping},

        [Parameter(ParameterSetName='Migrate', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20221101Preview.IMigrationParameters]
        # Request body for Migrate operation.
        # To construct, see NOTES section for MIGRATIONPARAMETER properties and create a hash table.
        ${MigrationParameter},

        [Parameter(HelpMessage='The subscription ID that identifies an Azure subscription.')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # Azure Subscription ID.
        ${SubscriptionId},

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
        if($PSBoundParameters.ContainsKey('MigrationWebApplicationFirewallMapping')) {
            if(!(Get-Module -ListAvailable -Name Az.FrontDoor)) {
                throw 'Please install Az.FrontDoor module by entering "Install-Module -Name Az.FrontDoor"'
            }
            else {
                Import-Module -Name Az.FrontDoor
            }

            $wafPolicies = $PSBoundParameters.MigrationWebApplicationFirewallMapping

            if($wafPolicies.count -gt 0) {
                # 1. Validate whether there is any waf policy associated with the profile.
                $frontDoorName = ${ClassicResourceReferenceId}.split("/")[-1]
                $frontDoorInfos = Get-AzFrontDoorFrontendEndpoint -ResourceGroupName ${ResourceGroupName} -FrontDoorName $frontDoorName
                $hasWafpolicy = $false
                $allWafPolicies = @()
                # $frontDoorInfos[0].WebApplicationFirewallPolicyLink
                foreach ($info in $frontDoorInfos) {
                    if($info.WebApplicationFirewallPolicyLink) {
                        $hasWafpolicy = $true
                        $allWafPolicies += $info.WebApplicationFirewallPolicyLink
                    }
                }

                if ($hasWafpolicy -eq $false) {
                    throw 'No waf policy associated with the profile. Please check your profile.'
                }

                Write-Debug("Waf Policy parameter ok now and enter validation the format of waf Id.")

                # 2. Validate the format of the waf policy and the migrateFrom.Id whether exists in the profile.
                # /subscriptions/*******/resourceGroups/****/providers/Microsoft.Network/frontdoorWebApplicationFirewallPolicies/******
                foreach ($policy in $wafPolicies) {
                    $migrateFromId = $policy.MigratedFromId
                    Write-Debug("MigratedFromId, " + $migrateFromId)
                   
                    ParseWafPolicyResourceId -WafResourceId $migrateFromId
                    Write-Debug("test1 Done")

                    if ($allWafPolicies -NotContains $migrateFromId)
                    {
                        throw 'Waf policy: $policy.MigratedFromId, not exists in the profile. Waf policy provided should exist in the profile.'
                    }
                    ParseWafPolicyResourceId -WafResourceId $policy.MigratedToId
                }

                # 4. Validate whether MigratedToId policy already exists in the subsrciption or not; If not existed, then create a new waf policy.
                # 5. Validate the Sku
                foreach ($policy in $wafPolicies) {
                    $migrateToWafId = $policy.MigratedToId
                    $migrateToWafResourceGroup = $migrateToWafId.split("/")[4]
                    $migrateToWafName = $migrateToWafId.split("/")[8]

                    try {
                        $existed = Get-AzFrontDoorWafPolicy -ResourceGroupName $migrateToWafResourceGroup -Name $migrateToWafName
                        
                        # Validate the Sku
                        
                    }
                    catch {
                        $migrateFromWafId = $policy.MigratedFromId
                        $migrateFromWafResourceGroup = $migrateFromWafId.split("/")[4]
                        $migrateFromWafName = $migrateFromWafId.split("/")[8]
                        $migrateFromWafProperty = Get-AzFrontDoorWafPolicy -ResourceGroupName $migrateFromWafResourceGroup -Name $migrateFromWafName

                        # Create a new waf policy. 
                        CreatePremiumWafPolicy -ResourceGroupName $migrateToWafResourceGroup -Name $migrateToWafName -WafProperty $migrateFromWafProperty
                    }
                }
            }
        }
        Az.Cdn.internal\Move-AzCdnProfile @PSBoundParameters
    }
}

# Parse the format of the waf reource id. 
function ParseWafPolicyResourceId {
    param (
        [string]$WafResourceId
    )
    Write-Debug("Validate the resource ID")
    $array = $WafResourceId.ToLower().split('/')
    Write-Debug("array: " + $array)
    if ($array.Length -ne 9){
        throw 'On stage one: Format of WebApplicationFirewallMapping is not correct, please check the parameter.'
    }
    if ($array[1] -gt "subscriptions" -or $array[3] -gt "resourcegroups" -or $array[5] -gt "providers" -or $array[6] -gt "microsoft.network" -or $array[7] -gt "frontdoorwebapplicationfirewallpolicies") {
        throw 'On stage two: Format of WebApplicationFirewallMapping is not correct, please check the parameter.'
    }
}

# Corresponding to "Copy to a new waf policy"
function CreateWafPolicy {
    param (
        [string]$ResourceGroupName,
        [string]$Name,
        [Microsoft.Azure.Commands.FrontDoor.Models.PSTrackedResource]$WafProperty
    )

    $skuName = "Standard_AzureFrontDoor"
    if (!$WafProperty.ManagedRules) {
        $skuName = "Premium_AzureFrontDoor"
    }

    # Complete command
    # New-AzFrontDoorWafPolicy -ResourceGroupName $ResourceGroupName -Name $Name -Sku "Premium_AzureFrontDoor" -EnabledState $WafProperty.PolicyEnabledState -Mode $WafProperty.PolicyMode -Customrule $WafProperty.CustomRules -ManagedRule $WafProperty.ManagedRules -RedirectUrl $WafProperty.RedirectUrl -CustomBlockResponseStatusCode $WafProperty.CustomBlockResponseStatusCode -CustomBlockResponseBody $WafProperty.CustomBlockResponseBody -RequestBodyCheck $WafProperty.RequestBodyCheck 
    New-AzFrontDoorWafPolicy -ResourceGroupName $ResourceGroupName -Name $Name -Sku $skuName -EnabledState $WafProperty.PolicyEnabledState -Mode $WafProperty.PolicyMode -Customrule $WafProperty.CustomRules -RequestBodyCheck $WafProperty.RequestBodyCheck -CustomBlockResponseStatusCode $WafProperty.CustomBlockResponseStatusCode -ManagedRule $WafProperty.ManagedRules -RedirectUrl $WafProperty.RedirectUrl
}