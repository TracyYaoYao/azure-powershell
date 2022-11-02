if(($null -eq $TestName) -or ($TestName -contains 'Enable-AzFrontDoorCdnProfileManagedIdentity'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Enable-AzFrontDoorCdnProfileManagedIdentity.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Enable-AzFrontDoorCdnProfileManagedIdentity' {
    It 'Start' {
        $ResourceGroupName = 'testps-rg-' + (RandomString -allChars $false -len 6)
        {
            $subId = "27cafca8-b9a4-4264-b399-45d0c9cca1ab"
            $ResourceGroupName = 'testps-rg-' + (RandomString -allChars $false -len 6)

            try
            {
                Write-Host -ForegroundColor Green "Create test group $($ResourceGroupName)"
                New-AzResourceGroup -Name $ResourceGroupName -Location $env.location -SubscriptionId $subId

                $frontDoorCdnProfileName = 'fdp-' + (RandomString -allChars $false -len 6);
                Write-Host -ForegroundColor Green "Use frontDoorCdnProfileName : $($frontDoorCdnProfileName)"

                $profileSku = "Standard_AzureFrontDoor";
                New-AzFrontDoorCdnProfile -SkuName $profileSku -Name $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Location Global -SubscriptionId $subId

                $classicResourceReferenceId = "/subscriptions/$subId/resourcegroups/$ResourceGroupName/providers/Microsoft.Network/Frontdoors/$frontDoorCdnProfileName"

            
                Enable-AzFrontDoorCdnProfileManagedIdentity -ResourceGroupName $ResourceGroupName -ClassicResourceReferenceId $classicResourceReferenceId -ProfileName migrationtest003-migrated  -IdentityType SystemAssigned
            } Finally
            {
                Remove-AzResourceGroup -Name $ResourceGroupName -NoWait
            }
        } | Should -Not -Throw
    }

    It 'Start1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
