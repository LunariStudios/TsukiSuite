<#
.SYNOPSIS
    Automates the Unity build process via command line.

.DESCRIPTION
    This script starts a Unity build process with customizable parameters. It includes error handling and provides detailed output for troubleshooting.

.PARAMETER UnityPath
    The path to the Unity executable. Default is "C:/Program Files/Unity/Hub/Editor/6000.0.23f1/Editor/Unity.exe".

.PARAMETER BuildTarget
    The build target platform (e.g., android, ios). Default is "android".

.PARAMETER AndroidBuildTargetType
    The Android build target type (e.g., apk, aab). Default is "apk".

.PARAMETER ProjectPath
    The path to the Unity project. Default is the parent directory of the script.

.PARAMETER AdditionalUnityArgs
    Any additional arguments to pass to Unity.

.EXAMPLE
    .\BuildUnityProject.ps1 -BuildTarget ios

.EXAMPLE
    .\BuildUnityProject.ps1 -UnityPath "C:\Program Files\Unity\Editor\Unity.exe" -ProjectPath "C:\MyUnityProject"

#>

[CmdletBinding()]
param(
    [string]$UnityPath = "C:/Program Files/Unity/Hub/Editor/2022.3.19f1/Editor/Unity.exe",
    [string]$Logfile = "-"
)

Write-Host "Starting Unity process"

try {
    $workspace = Resolve-Path "$PSScriptRoot/.."
    $unityArgs = "-batchmode -projectPath $workspace -executeMethod Lunari.Tsuki.Editor.TsukiBuild.PerformTsukiBuild -buildTarget StandaloneWindows64 -quit -timestamps -logfile build.log"

    if (-not (Test-Path "$UnityPath")) {
        throw "Unity executable not found at path: $UnityPath"
    }

    Write-Host "Unity path: $UnityPath"
    Write-Host "Unity arguments: $unityArgs"
    Write-Host "Starting process using: Start-Process -FilePath $UnityPath -ArgumentList "$unityArgs" -NoNewWindow -PassThru"
    $process = Start-Process -FilePath $UnityPath -ArgumentList "$unityArgs" -NoNewWindow -PassThru
    Write-Host "Unity process started, process: $process"

    if ($process) {
        $unityPid = $process.Id
        Write-Host "Unity process started with PID: $unityPid"
        Wait-Process -InputObject $process

        # Check the exit code
        if ($process.ExitCode -ne 0) {
            Write-Error "Unity process exited with code '$($process.ExitCode)'"
            exit $process.ExitCode
        } else {
            Write-Host "Unity process completed successfully."
        }
    } else {
        throw "Failed to start Unity process."
    }
} catch {
    Write-Error "An error occurred during Unity build: $_"
    throw $_
}