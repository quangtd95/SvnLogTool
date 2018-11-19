Imports System.IO
Imports System.Text

Public Class Form1
    Private Sub btnChooseFolder_Click(sender As Object, e As EventArgs) Handles btnChooseFolder.Click
        Dim FolderBrowserDialog1 = New FolderBrowserDialog()
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtSvnPath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim svnPath = txtSvnPath.Text.Trim
        Dim query = txtSearch.Text.Trim
        Dim logFilePath = Directory.GetCurrentDirectory & "\log.txt"
        If String.IsNullOrWhiteSpace(svnPath) Then
            MessageBox.Show("please input svn directory!", "pleeez")
            Exit Sub
        End If
        If Not Directory.Exists(svnPath) Then
            MessageBox.Show("Folder doesn't exists!", "pleeez")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(query) Then
            MessageBox.Show("Please Write down something to search!", "pleeez")
            Exit Sub
        End If

        Dim CommandSVN As String = String.Empty
        CommandSVN &= "echo ""Please wait..."""
        CommandSVN &= " & cd """ & svnPath & """"
        CommandSVN &= " & " & svnPath.Chars(0) & ":"
        CommandSVN &= " & svn log --search """ & query & """"
        CommandSVN &= " -v > """ & logFilePath & """"

        RunCommandCom(CommandSVN, String.Empty, False)

        Dim lines = IO.File.ReadAllLines(logFilePath, System.Text.Encoding.GetEncoding("shift-jis"))

        Dim fileList As New HashSet(Of String)
        Dim fileAdded As New HashSet(Of String)
        Dim fileDeleteWarning As New HashSet(Of String)

        For i As Integer = lines.Count - 1 To 0 Step -1
            Dim s As String = lines(i)
            If s.Contains("   A ") Then
                Dim path = s.Replace("   A ", "")
                If Not fileAdded.Contains(path) Then
                    fileAdded.Add(path)
                End If
                If Not fileList.Contains(path) Then
                    fileList.Add(path)
                End If
                If fileDeleteWarning.Contains(path) Then
                    fileDeleteWarning.Remove(path)
                End If
            ElseIf s.Contains("   M ") Then
                Dim path = s.Replace("   M ", "")
                If Not fileList.Contains(path) Then
                    fileList.Add(path)
                End If
            ElseIf s.Contains("   D ") Then
                Dim path = s.Replace("   D ", "")
                If fileList.Contains(path) Then
                    fileList.Remove(path)
                End If
                If Not fileAdded.Contains(path) Then
                    If Not fileDeleteWarning.Contains(path) Then
                        fileDeleteWarning.Add(path)
                    End If
                Else
                    fileAdded.Remove(path)
                End If
            End If
        Next i
        If fileList.Count = 0 Then
            MessageBox.Show("There is no data to collect", "plezz")
            Exit Sub
        Else
            Dim outData As New StringBuilder

            outData.AppendLine("These files were added/modified by " & query)
            outData.AppendLine("->")
            For Each dt In fileList
                outData.AppendLine(dt)
            Next
            outData.AppendLine("=============================================================================================")
            outData.AppendLine("")

            outData.AppendLine("These files are not of " & query & " but he/she deleted")
            outData.AppendLine("->")
            For Each dt In fileDeleteWarning
                outData.AppendLine(dt)
            Next
            outData.AppendLine("=============================================================================================")
            outData.AppendLine("")

            Dim bytesData() As Byte
            Dim outFile = Directory.GetCurrentDirectory & "\output" & CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds) & ".txt"

            bytesData = System.Text.Encoding.GetEncoding(932).GetBytes(outData.ToString)
            Dim fs As New System.IO.FileStream(outFile,
                                              System.IO.FileMode.Create,
                                              System.IO.FileAccess.Write)
            fs.Write(bytesData, 0, bytesData.Length)
            fs.Close()
            MessageBox.Show("Output of processing is stored at " & outFile)
            My.Computer.FileSystem.DeleteFile(logFilePath)
            Process.Start(Directory.GetCurrentDirectory)
            Process.Start(outFile)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Please restart your computer after installing svn")
        Dim webAddress As String = "https://sourceforge.net/projects/win32svn/files/latest/download"
        Process.Start(webAddress)
    End Sub

    Sub RunCommandCom(command As String, arguments As String, permanent As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        p.Start()
        p.WaitForExit()
    End Sub
End Class
