call pack
IF "%1" == "" (
    SET REPO="http://repo.imddevil.com/repository/nuget/"
) ELSE (
    SET REPO=%1
) 
echo "Pushing to repo %REPO%"
nuget push -Source %REPO%
pause