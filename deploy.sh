#!/usr/bin/env bash
echo "[INFO] Download nuget.exe."
wget -nc https://dist.nuget.org/win-x86-commandline/v4.5.1/nuget.exe;
mozroots --import --sync

echo "[INFO] Publishing NuGet package."
mono nuget.exe push Wallee.2.0.1.nupkg -ApiKey $NUGET_API_KEY -Verbosity detailed -Source nuget.org