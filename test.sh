#!/usr/bin/env bash

wget -nc https://nuget.org/nuget.exe
mozroots --import --sync

echo "[INFO] remove src/Customweb.Wallee.Test/bin/Debug/Customweb.Wallee.Test.dll"
rm src/Customweb.Wallee.Test/bin/Debug/Customweb.Wallee.Test.dll 2> /dev/null

echo "[INFO] install NUnit runners via NuGet"
wget -nc https://nuget.org/nuget.exe
mozroots --import --sync
mono nuget.exe install src/Customweb.Wallee.Test/packages.config -o packages

echo "[INFO] Install NUnit runners via NuGet"
mono nuget.exe install NUnit.Runners -Version 2.6.2 -OutputDirectory packages

echo "[INFO] Build the solution and run the unit test"
msbuild Customweb.Wallee.sln && \
    mono ./packages/NUnit.Runners.2.6.2/tools/nunit-console.exe src/Customweb.Wallee.Test/bin/Debug/Customweb.Wallee.Test.dll
