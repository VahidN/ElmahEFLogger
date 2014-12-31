"%~dp0NuGet.exe" pack "..\ElmahEFLogger\ElmahEFLogger.csproj" -Prop Configuration=Release
copy "%~dp0*.nupkg" "%localappdata%\NuGet\Cache"
pause