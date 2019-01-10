call load
mkdir %BUILD_LOCATION%
del %BUILD_LOCATION%\*.nupkg
nuget pack %ROOT_LOCATION%\Tsuki-Runtime\Tsuki-Runtime.csproj -Build -Properties Configuration=Release -Properties Platform=AnyCPU -OutputDirectory %BUILD_LOCATION%
nuget pack %ROOT_LOCATION%\Tsuki-Editor\Tsuki-Editor.csproj -Build -Properties Configuration=Release -Properties Platform=AnyCPU -OutputDirectory %BUILD_LOCATION%