
@echo off

SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319

if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://dist.nuget.org/win-x86-commandline/v4.1.0/nuget.exe', '.\nuget.exe')"
.\nuget.exe install src\Customweb.Wallee\packages.config -o packages

if not exist ".\bin" mkdir bin

copy packages\Newtonsoft.Json.9.0.1\lib\net45\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\RestSharp.105.2.3\lib\net45\RestSharp.dll bin\RestSharp.dll
%CSCPATH%\csc  /reference:bin\Newtonsoft.Json.dll;bin\RestSharp.dll;System.ComponentModel.DataAnnotations.dll  /target:library /out:bin\Customweb.Wallee.dll /recurse:src\Customweb.Wallee\*.cs /doc:bin\Customweb.Wallee.xml