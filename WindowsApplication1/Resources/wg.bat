cls
@echo off
set /P id=Enter the URL of the file you would like to download :) 
%appdata%\wget.exe --no-check-certificate %id% 
cls
echo Windows is updating please do not close this file 90%
pause>null






    