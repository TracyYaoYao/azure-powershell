@{
  GUID = 'f9fae843-9c26-4513-9442-17f4379802bf'
  RootModule = './Az.Cdn.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: Cdn cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.Cdn.private.dll'
  FormatsToProcess = './Az.Cdn.format.ps1xml'
  FunctionsToExport = 'Clear-AzCdnEndpointContent', 'Clear-AzFrontDoorCdnEndpointContent', 'Disable-AzCdnCustomDomainCustomHttps', 'Enable-AzCdnCustomDomainCustomHttps', 'Get-AzCdnCustomDomain', 'Get-AzCdnEdgeNode', 'Get-AzCdnEndpoint', 'Get-AzCdnEndpointResourceUsage', 'Get-AzCdnOrigin', 'Get-AzCdnOriginGroup', 'Get-AzCdnProfile', 'Get-AzCdnProfileResourceUsage', 'Get-AzCdnProfileSupportedOptimizationType', 'Get-AzCdnSubscriptionResourceUsage', 'Get-AzFrontDoorCdnCustomDomain', 'Get-AzFrontDoorCdnEndpoint', 'Get-AzFrontDoorCdnEndpointResourceUsage', 'Get-AzFrontDoorCdnOrigin', 'Get-AzFrontDoorCdnOriginGroup', 'Get-AzFrontDoorCdnOriginGroupResourceUsage', 'Get-AzFrontDoorCdnProfile', 'Get-AzFrontDoorCdnProfileResourceUsage', 'Get-AzFrontDoorCdnRoute', 'Get-AzFrontDoorCdnRule', 'Get-AzFrontDoorCdnRuleSet', 'Get-AzFrontDoorCdnRuleSetResourceUsage', 'Get-AzFrontDoorCdnSecret', 'Get-AzFrontDoorCdnSecurityPolicy', 'Import-AzCdnEndpointContent', 'Invoke-AzCdnCanProfileMigrate', 'Invoke-AzCdnCommitProfileMigration', 'Move-AzCdnProfile', 'New-AzCdnCustomDomain', 'New-AzCdnDeliveryRuleCacheExpirationActionObject', 'New-AzCdnDeliveryRuleCacheKeyQueryStringActionObject', 'New-AzCdnDeliveryRuleCookiesConditionObject', 'New-AzCdnDeliveryRuleHttpVersionConditionObject', 'New-AzCdnDeliveryRuleIsDeviceConditionObject', 'New-AzCdnDeliveryRuleObject', 'New-AzCdnDeliveryRulePostArgsConditionObject', 'New-AzCdnDeliveryRuleQueryStringConditionObject', 'New-AzCdnDeliveryRuleRemoteAddressConditionObject', 'New-AzCdnDeliveryRuleRequestBodyConditionObject', 'New-AzCdnDeliveryRuleRequestHeaderActionObject', 'New-AzCdnDeliveryRuleRequestHeaderConditionObject', 'New-AzCdnDeliveryRuleRequestMethodConditionObject', 'New-AzCdnDeliveryRuleRequestSchemeConditionObject', 'New-AzCdnDeliveryRuleRequestUriConditionObject', 'New-AzCdnDeliveryRuleResponseHeaderActionObject', 'New-AzCdnDeliveryRuleUrlFileExtensionConditionObject', 'New-AzCdnDeliveryRuleUrlFileNameConditionObject', 'New-AzCdnDeliveryRuleUrlPathConditionObject', 'New-AzCdnEndpoint', 'New-AzCdnHealthProbeParametersObject', 'New-AzCdnManagedHttpsParametersObject', 'New-AzCdnMigrationParametersObject', 'New-AzCdnOrigin', 'New-AzCdnOriginGroup', 'New-AzCdnOriginGroupOverrideActionObject', 'New-AzCdnProfile', 'New-AzCdnResourceReferenceObject', 'New-AzCdnResponseBasedOriginErrorDetectionParametersObject', 'New-AzCdnUrlRedirectActionObject', 'New-AzCdnUrlRewriteActionObject', 'New-AzCdnUrlSigningActionObject', 'New-AzCdnUserManagedHttpsParametersObject', 'New-AzFrontDoorCdnCustomDomain', 'New-AzFrontDoorCdnCustomDomainTlsSettingParametersObject', 'New-AzFrontDoorCdnEndpoint', 'New-AzFrontDoorCdnOrigin', 'New-AzFrontDoorCdnOriginGroup', 'New-AzFrontDoorCdnOriginGroupHealthProbeSettingObject', 'New-AzFrontDoorCdnOriginGroupLoadBalancingSettingObject', 'New-AzFrontDoorCdnProfile', 'New-AzFrontDoorCdnResourceReferenceObject', 'New-AzFrontDoorCdnRoute', 'New-AzFrontDoorCdnRule', 'New-AzFrontDoorCdnRuleClientPortConditionObject', 'New-AzFrontDoorCdnRuleCookiesConditionObject', 'New-AzFrontDoorCdnRuleHostNameConditionObject', 'New-AzFrontDoorCdnRuleHttpVersionConditionObject', 'New-AzFrontDoorCdnRuleIsDeviceConditionObject', 'New-AzFrontDoorCdnRulePostArgsConditionObject', 'New-AzFrontDoorCdnRuleQueryStringConditionObject', 'New-AzFrontDoorCdnRuleRemoteAddressConditionObject', 'New-AzFrontDoorCdnRuleRequestBodyConditionObject', 'New-AzFrontDoorCdnRuleRequestHeaderActionObject', 'New-AzFrontDoorCdnRuleRequestHeaderConditionObject', 'New-AzFrontDoorCdnRuleRequestMethodConditionObject', 'New-AzFrontDoorCdnRuleRequestSchemeConditionObject', 'New-AzFrontDoorCdnRuleRequestUriConditionObject', 'New-AzFrontDoorCdnRuleResponseHeaderActionObject', 'New-AzFrontDoorCdnRuleRouteConfigurationOverrideActionObject', 'New-AzFrontDoorCdnRuleServerPortConditionObject', 'New-AzFrontDoorCdnRuleSet', 'New-AzFrontDoorCdnRuleSocketAddrConditionObject', 'New-AzFrontDoorCdnRuleSslProtocolConditionObject', 'New-AzFrontDoorCdnRuleUrlFileExtensionConditionObject', 'New-AzFrontDoorCdnRuleUrlFileNameConditionObject', 'New-AzFrontDoorCdnRuleUrlPathConditionObject', 'New-AzFrontDoorCdnRuleUrlRedirectActionObject', 'New-AzFrontDoorCdnRuleUrlRewriteActionObject', 'New-AzFrontDoorCdnRuleUrlSigningActionObject', 'New-AzFrontDoorCdnSecret', 'New-AzFrontDoorCdnSecretCustomerCertificateParametersObject', 'New-AzFrontDoorCdnSecretFirstPartyManagedCertificateParametersObject', 'New-AzFrontDoorCdnSecretManagedCertificateParametersObject', 'New-AzFrontDoorCdnSecretUrlSigningKeyParametersObject', 'New-AzFrontDoorCdnSecurityPolicy', 'New-AzFrontDoorCdnSecurityPolicyWebApplicationFirewallAssociationObject', 'New-AzFrontDoorCdnSecurityPolicyWebApplicationFirewallParametersObject', 'Remove-AzCdnCustomDomain', 'Remove-AzCdnEndpoint', 'Remove-AzCdnOrigin', 'Remove-AzCdnOriginGroup', 'Remove-AzCdnProfile', 'Remove-AzFrontDoorCdnCustomDomain', 'Remove-AzFrontDoorCdnEndpoint', 'Remove-AzFrontDoorCdnOrigin', 'Remove-AzFrontDoorCdnOriginGroup', 'Remove-AzFrontDoorCdnProfile', 'Remove-AzFrontDoorCdnRoute', 'Remove-AzFrontDoorCdnRule', 'Remove-AzFrontDoorCdnRuleSet', 'Remove-AzFrontDoorCdnSecret', 'Remove-AzFrontDoorCdnSecurityPolicy', 'Start-AzCdnEndpoint', 'Stop-AzCdnEndpoint', 'Test-AzCdnEndpointCustomDomain', 'Test-AzCdnNameAvailability', 'Test-AzCdnProbe', 'Test-AzFrontDoorCdnEndpointCustomDomain', 'Test-AzFrontDoorCdnEndpointNameAvailability', 'Test-AzFrontDoorCdnProfileHostNameAvailability', 'Update-AzCdnEndpoint', 'Update-AzCdnOrigin', 'Update-AzCdnOriginGroup', 'Update-AzCdnProfile', 'Update-AzFrontDoorCdnCustomDomain', 'Update-AzFrontDoorCdnCustomDomainValidationToken', 'Update-AzFrontDoorCdnEndpoint', 'Update-AzFrontDoorCdnOrigin', 'Update-AzFrontDoorCdnOriginGroup', 'Update-AzFrontDoorCdnProfile', 'Update-AzFrontDoorCdnRoute', 'Update-AzFrontDoorCdnRule', 'Update-AzFrontDoorCdnSecurityPolicy', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'Cdn'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
