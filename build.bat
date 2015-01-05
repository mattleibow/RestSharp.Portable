set NETFX=%WINDIR%\Microsoft.NET\Framework\v4.0.30319
set GENAPI=tools\GenAPI.exe
set NUGET=tools\nuget.exe
set BUILD_OPTS=/p:Configuration=Release /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=Normal /nr:true /p:BuildInParallel=true /p:RestorePackages=true /t:Clean,Rebuild

REM build RestSharp
cd RestSharp 
%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe RestSharp.sln %BUILD_OPTS%
%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe RestSharp.Xamarin.sln %BUILD_OPTS%
cd ..

REM generate files
rd generated /s /q  REM delete the old stuff
if not exist generated mkdir generated
%GENAPI% .\RestSharp\RestSharp.WindowsPhone\bin\Release\RestSharp.WindowsPhone.dll -libPath:"%NETFX%" -w:TypeForwards -out:.\generated\forwarded.generated.cs
%GENAPI% .\RestSharp\RestSharp.WindowsPhone\bin\Release\RestSharp.WindowsPhone.dll -libPath:"%NETFX%" -w:CSDecl -out:.\generated\stubs.generated.cs

REM build portable
%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe RestSharp.Portable.sln %BUILD_OPTS%

REM package
%NUGET% pack restsharp.portable.nuspec