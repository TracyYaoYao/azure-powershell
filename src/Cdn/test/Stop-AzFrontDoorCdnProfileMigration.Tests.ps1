if(($null -eq $TestName) -or ($TestName -contains 'Stop-AzFrontDoorCdnProfileMigration'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Stop-AzFrontDoorCdnProfileMigration.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Stop-AzFrontDoorCdnProfileMigration'  {

    BeforeAll {
        $subId = "27cafca8-b9a4-4264-b399-45d0c9cca1ab"
        $ResourceGroupName = 'testps-rg-' + (RandomString -allChars $false -len 6)
        Write-Host -ForegroundColor Green "Create test group $($ResourceGroupName)"
        New-AzResourceGroup -Name $ResourceGroupName -Location $env.location -SubscriptionId $subId

        $Name = 'fdp-' + (RandomString -allChars $false -len 6);
        Write-Host -ForegroundColor Green "Use frontDoorName : $($Name)"

        $frontDoorCdnProfileName = 'fdp-' + (RandomString -allChars $false -len 6);
        Write-Host -ForegroundColor Green "Use frontDoorCdnProfileName : $($frontDoorCdnProfileName)"

        $profileSku = "Standard_AzureFrontDoor";
        New-AzFrontDoorCdnProfile -SubscriptionId $subId -SkuName $profileSku -Name $frontDoorCdnProfileName -ResourceGroupName $ResourceGroupName -Location Global
    }

    It 'Delete' {
        try
        {
            Stop-AzFrontDoorCdnProfileMigration -SubscriptionId $subId -ResourceGroupName $ResourceGroupName -ProfileName $frontDoorCdnProfileName
        } Finally
        {
            Remove-AzResourceGroup -Name $ResourceGroupName -NoWait
        }
    }
}