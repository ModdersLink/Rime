# build-release.ps1 — build a COMPLETE RimeREPL CLI release into dist/.
#
# Why this exists: RimeREPL only *references* the Content + Serialization support
# assemblies, so a plain `dotnet build` of RimeREPL does NOT build the other
# Frostbite2_0 support assemblies (Texture/Shader/Havok/Mesh/Toolkit). Those are loaded
# dynamically at mount time (LoadSupportAssembly), so if their DLLs aren't next to
# RimeREPL.exe the matching commands silently don't register — e.g. `dump_texture` needs
# RimeLib.Texture.Frostbite2_0.dll. This script builds RimeREPL + every Frostbite2_0
# support assembly into one folder, ready to zip and ship.
#
# Usage:  pwsh ./build-release.ps1     (or right-click → Run with PowerShell)

$ErrorActionPreference = "Stop"
Set-Location $PSScriptRoot
$dist = Join-Path $PSScriptRoot "dist"
if (Test-Path $dist) { Remove-Item -Recurse -Force $dist }

# RimeREPL first (the exe + base libs), then EVERY Frostbite2_0 support assembly. ALL of
# them (Content, Serialization, Texture, Shader, Havok, Mesh, Toolkit) are loaded
# dynamically at mount time, not referenced by RimeREPL — so each must be built explicitly
# or it won't be in the output (e.g. without Content.Frostbite2_0.dll, mount_game fails).
$projects = @(
    "Utils\RimeREPL\RimeREPL.csproj"
    "RimeLib.Content.Frostbite2_0\RimeLib.Content.Frostbite2_0.csproj"
    "RimeLib.Serialization.Frostbite2_0\RimeLib.Serialization.Frostbite2_0.csproj"
    "RimeLib.Texture.Frostbite2_0\RimeLib.Texture.Frostbite2_0.csproj"
    "RimeLib.Shader.Frostbite2_0\RimeLib.Shader.Frostbite2_0.csproj"
    "RimeLib.Havok.Frostbite2_0\RimeLib.Havok.Frostbite2_0.csproj"
    "RimeLib.Mesh.Frostbite2_0\RimeLib.Mesh.Frostbite2_0.csproj"
    "RimeLib.Terrain.Frostbite2_0\RimeLib.Terrain.Frostbite2_0.csproj"
    "RimeLib.Toolkit.Frostbite2_0\RimeLib.Toolkit.Frostbite2_0.csproj"
)

foreach ($p in $projects) {
    Write-Host "==> building $p" -ForegroundColor Cyan
    dotnet build $p -c Release -o $dist --nologo
    if ($LASTEXITCODE -ne 0) { throw "build failed: $p" }
}

Write-Host ""
Write-Host "Release ready in: $dist" -ForegroundColor Green
Write-Host "Contains RimeREPL.exe + all Frostbite2_0 support DLLs (so replace_resource AND"
Write-Host "dump_texture/dump_resource/dump_partition_json/etc. all work). Zip dist/ to share."
