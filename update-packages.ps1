# ============================================================
#  update-packages.ps1
#  Updates all NuGet packages in movielandia-.net-api.csproj
#  to their latest stable versions.
# ============================================================

$ProjectFile = "$PSScriptRoot\movielandia-.net-api.csproj"

if (-not (Test-Path $ProjectFile)) {
    Write-Error "Project file not found: $ProjectFile"
    exit 1
}

# Ensure dotnet-outdated-tool is installed
$toolList = dotnet tool list --global 2>&1
if ($toolList -notmatch "dotnet-outdated") {
    Write-Host "`n[+] Installing dotnet-outdated-tool globally..." -ForegroundColor Cyan
    dotnet tool install --global dotnet-outdated-tool
} else {
    Write-Host "`n[i] dotnet-outdated-tool is already installed." -ForegroundColor DarkGray
}

# ── Parse current packages from .csproj ──────────────────────
Write-Host "`n[+] Reading packages from project file..." -ForegroundColor Cyan
[xml]$csproj = Get-Content $ProjectFile
$packages = $csproj.Project.ItemGroup.PackageReference | Where-Object { $_.Include -ne $null }

if ($packages.Count -eq 0) {
    Write-Host "No PackageReference entries found." -ForegroundColor Yellow
    exit 0
}

Write-Host "`n  Package`t`t`t`t`t`tCurrent" -ForegroundColor White
Write-Host "  -------`t`t`t`t`t`t-------" -ForegroundColor DarkGray
$packages | ForEach-Object {
    Write-Host ("  {0,-55} {1}" -f $_.Include, $_.Version) -ForegroundColor Gray
}

# ── Run dotnet-outdated and apply updates ─────────────────────
Write-Host "`n[+] Checking for updates and upgrading to latest stable versions...`n" -ForegroundColor Cyan
dotnet outdated $ProjectFile --upgrade --version-lock Major

# ── Restore after update ──────────────────────────────────────
Write-Host "`n[+] Restoring packages..." -ForegroundColor Cyan
dotnet restore $ProjectFile

# ── Show new versions ─────────────────────────────────────────
Write-Host "`n[+] Updated package versions:" -ForegroundColor Green
[xml]$updated = Get-Content $ProjectFile
$updated.Project.ItemGroup.PackageReference |
    Where-Object { $_.Include -ne $null } |
    ForEach-Object {
        Write-Host ("  {0,-55} {1}" -f $_.Include, $_.Version) -ForegroundColor White
    }

Write-Host "`n[OK] All packages updated successfully!`n" -ForegroundColor Green
