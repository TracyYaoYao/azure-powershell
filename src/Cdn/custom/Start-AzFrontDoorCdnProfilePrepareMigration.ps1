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
Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20220501Preview.IMigrateResult
.Link
https://docs.microsoft.com/powershell/module/az.cdn/start-azfrontdoorcdnprofilepreparemigration
#>
function Start-AzFrontDoorCdnProfilePrepareMigration {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20220501Preview.IMigrateResult])]
    [CmdletBinding(PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Path')]
        [System.String]
        # Name of the Resource group within the Azure subscription.
        ${ResourceGroupName},

        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [System.String]
        # Resource ID.
        ${ClassicResourceReferenceId},

        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [System.String]
        # Name of the new profile that need to be created.
        ${ProfileName},

        [Parameter(Mandatory)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SkuName]
        # Name of the pricing tier.
        ${SkuName},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [System.String]
        # Waf mapping for the migrated profile
        # To construct, see NOTES section for MIGRATIONWEBAPPLICATIONFIREWALLMAPPING properties and create a hash table.
        ${MigrationWebApplicationFirewallMapping},

        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20220501Preview.IMigrationParameters]
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

            $WafPolicies = $PSBoundParameters.MigrationWebApplicationFirewallMapping['Value']

            if($MigratePolicies.count -gt 0) {
                # Validate the format of the waf policy
                # /subscriptions/*******/resourceGroups/****/providers/Microsoft.Network/frontdoorWebApplicationFirewallPolicies/******
                foreach ($policy in $WafPolicies) {
                    ParseWafResourceId -WafResourceId $policy.migratedFrom.Id
                    ParseWafResourceId -WafResourceId $policy.migratedTo.Id
                }

                $AllEndpointsInfo = Get-AzFrontDoorFrontendEndpoint -ResourceGroupName ${ResourceGroupName} -ProfileName ${ProfileName}
                foreach($endpointInfo in $AllEndpointsInfo) {

                }

                $AzFrontDoorWafPolicies = Get-AzFrontDoorWafPolicy -ResourceGroupName
                if ($AzFrontDoorWafPolicies == null) {
                    throw 'No waf policy associated with current profile. Please check your profile.'
                }

                foreach ($policy in $WafPolicies) {
                    $MigrateFromWafId = $policy.migratedFrom
                    if ($AzFrontDoorWafPolicies -notcontains $MigrateFromWafId) {
                        throw '$MigrateFromWafId dose not exist in the Profile. You are supposed to prvoide a Waf policy existed in the profile.'
                    }
                }

                foreach ($policy in $WafPolicies) {
                    $MigrateToWafId = $policy.migratedTo
                    if ($AzFrontDoorWafPolicies -notcontains $MigrateToWafId) {
                        if ($PSBoundParameters.ContainsKey('ProfileName')) {
                            New-AzFrontDoorWafPolicy -ResourceGroupName ${ResourceGroupName} -Name ${ProfileName}
                        }
                        else {
                            New-AzFrontDoorWafPolicy -ResourceGroupName ${ResourceGroupName} -Name ${Name} + "-migrated"
                        }
                    }
                }
            }
        }

        Az.Cdn.internal\Move-AzCdnProfile @PSBoundParameters
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
