dotnet publish -c=Release
cd wwwroot
call npm install
call polymer build --preset=es6-bundled
move build/es6-bundled ../bin/Release/netcoreapp2.1/publish/wwwroot