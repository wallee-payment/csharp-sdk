#!/usr/bin/env bash
echo "[INFO] Restoring NuGet packages."
msbuild /t:restore

echo "[INFO] Building Customweb.Wallee.csproj."
msbuild src/Customweb.Wallee/Customweb.Wallee.csproj /t:pack /p:Configuration=Release /p:Platform="Any CPU" /p:GenerateDocumentation=true /p:DocumentationFile=Customweb.Wallee.xml

if [ $? -ne 0 ]
then
  echo "[ERROR] Compilation failed with exit code $?."
  exit 1
else
  echo "[INFO] Compilation was successfully."
fi


echo "[INFO] Copying created NuGet package."
cp "src/Customweb.Wallee/bin/Any CPU/Release/Customweb.Wallee.1.0.5.nupkg" ./Customweb.Wallee.1.0.5.nupkg;
