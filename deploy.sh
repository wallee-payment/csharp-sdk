#!/usr/bin/env bash

nuget pack src/Customweb.Wallee/Customweb.Wallee.nuspec -Version $WALLEE_SDK_VERSION && \
nuget push *.nupkg -ApiKey $NUGET_API_KEY -Verbosity detailed