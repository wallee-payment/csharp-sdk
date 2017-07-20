#!/usr/bin/env bash

ls */*/* -lahr && nuget pack src/Customweb.Wallee/Customweb.Wallee.nuspec -Version $WALLEE_SDK_VERSION -Verbosity detailed && \
nuget push *.nupkg -ApiKey $NUGET_API_KEY -Verbosity detailed
