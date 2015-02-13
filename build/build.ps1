# Find or download NuGet.exe
$nuget = '.\nuget.exe'
if ((Test-Path $nuget) -eq $false) {
  (new-object System.Net.WebClient).DownloadFile('http://www.nuget.org/nuget.exe', $nuget)
}

# Set up the relevant aliases.
Set-Alias MSBuild (Join-Path -Path (Get-ItemProperty "HKLM:\SOFTWARE\Microsoft\MSBuild\ToolsVersions\4.0").MSBuildToolsPath -ChildPath "MSBuild.exe")
Set-Alias NuGet $nuget

# Set up the temporary build artifact directory.
if (!(Test-Path -path .\temporary)) { New-Item .\temporary -Type Directory }
$temp = Resolve-Path .\temporary

# Set up the publish directory.
if (!(Test-Path -path ..\publish)) { New-Item ..\publish -Type Directory }
$publish = Resolve-Path ..\publish

# Find the current version.
Get-Content '..\src\ObservableWinFormsEvents\Properties\AssemblyInfo.cs' | ForEach-Object { if ($_ -match 'AssemblyInformationalVersion\("(.*)"\)') { $version = $matches[1] } }
if ($version -eq $null) { throw 'Unable to determine version.' }

# Restore any missing packages.
NuGet restore "..\src\ObservableWinFormsEvents.sln"

# Build from source.
MSBuild "/nologo" "/property:Configuration=Release,OutputPath=$temp" "..\src\ObservableWinFormsEvents\ObservableWinFormsEvents.csproj"

# Build the NuGet package.
NuGet pack "./ObservableWinFormsEvents.nuspec" -o $publish -Version $version

# Clean up the temporary directory.
Remove-Item $temp -Recurse