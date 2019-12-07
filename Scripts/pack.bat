call load
mkdir %BUILD_LOCATION%
del %BUILD_LOCATION%\*.nupkg
nuget pack %ROOT_LOCATION%\Tsuki-Runtime\Tsuki-Runtime.csproj -Properties Configuration=Release -Properties Platform=AnyCPU -OutputDirectory %BUILD_LOCATION%
nuget pack %ROOT_LOCATION%\Tsuki-Editor\Tsuki-Editor.csproj -Properties Configuration=Release -Properties Platform=AnyCPU -OutputDirectory %BUILD_LOCATION%
nuget pack %ROOT_LOCATION%\Tsuki-Graphs\Tsuki-Graphs.csproj -Properties Configuration=Release -Properties Platform=AnyCPU -OutputDirectory %BUILD_LOCATION%