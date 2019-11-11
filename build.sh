#!/usr/bin/env bash
echo "[INFO] Restoring NuGet packages."
msbuild /t:restore

echo "[INFO] Building Wallee.csproj."
msbuild src/Wallee/Wallee.csproj /t:pack /p:Configuration=Release /p:Platform="Any CPU" /p:GenerateDocumentation=true /p:DocumentationFile=Wallee.xml

if [ $? -ne 0 ]
then
echo "[ERROR] Compilation failed with exit code $?."
exit 1
else
echo "[INFO] Compilation was successfully."
fi


echo "[INFO] Copying created NuGet package."
cp "src/Wallee/bin/Any CPU/Release/Wallee.2.0.1.nupkg" ./Wallee.2.0.1.nupkg;
