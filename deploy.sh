#!/usr/bin/env bash

mono nuget.exe push Customweb.Wallee.1.0.5.nupkg -ApiKey $NUGET_API_KEY -Verbosity detailed -Source nuget.org