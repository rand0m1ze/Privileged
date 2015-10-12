for /f %x in ('wevtutil el') do wevtutil cl "%x"
powershell
wevtutil el | Foreach-Object {wevtutil cl "$_"}