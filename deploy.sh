#!/usr/bin/env bash

mono nuget.exe pack src/Customweb.Wallee/Customweb.Wallee.nuspec -Version $WALLEE_SDK_VERSION -Verbosity detailed && \
mono nuget.exe push Customweb.Wallee.$WALLEE_SDK_VERSION.nupkg -ApiKey $NUGET_API_KEY -Verbosity detailed -Source nuget.org