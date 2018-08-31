dotnet publish -c=Release
cd wwwroot
call npm install
call polymer build --preset=es5-bundled
move build/es5-bundled ../bin/Release/netcoreapp2.0/publish/wwwroot