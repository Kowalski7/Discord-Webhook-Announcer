Imports System.IO

Public Class profiles
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim profileName = InputBox("Enter the name that you wish your profile to be saved as:" & vbNewLine & vbNewLine & "Do not use the following characters:" & vbNewLine & "\ / : * ? "" < > |", "Save profile as...")
        Select Case profileName
            Case ""
                Return
        End Select
        Try
            Dim filedata As String()
            filedata = {main.webhookLink.Text, main.username.Text, main.profilePicLink.Text}
            File.WriteAllLines("profiles\" + profileName + ".dwh", filedata)
        Catch
            MsgBox("Unable to save file!" & vbNewLine & "This may be caused by an illegal character in the name you chose.", vbCritical + vbOKOnly, "Profiles")
        End Try
        displayProfiles()
    End Sub
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        File.Delete("profiles\" + profilesList.SelectedItem + ".dwh")
        toggleButtons(0)
        displayProfiles()
    End Sub
    Private Sub UseBtn_Click(sender As Object, e As EventArgs) Handles useBtn.Click
        Try
            Dim fileReader As StreamReader = My.Computer.FileSystem.OpenTextFileReader("profiles\" + profilesList.SelectedItem + ".dwh")
            main.webhookLink.Text = fileReader.ReadLine
            main.username.Text = fileReader.ReadLine
            main.profilePicLink.Text = fileReader.ReadLine
            fileReader.Close()
        Catch
            MsgBox("Unable to load profile!" & vbNewLine & "It may have been deleted or renamed.", vbCritical + vbOKOnly, "Profiles")
        End Try
        If main.autoFetch.Checked = True Then
            If main.username.Text = "Webhook" And main.profilePicLink.Text = "" Then
                main.fetchWHinfo(1, 1)
            ElseIf main.username.Text = "Webhook" Then
                main.fetchWHinfo(1, 0)
            ElseIf main.profilePicLink.Text = "" Then
                main.fetchWHinfo(0, 1)
            End If
        End If
    End Sub
    Private Sub profilesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles profilesList.SelectedIndexChanged
        If profilesList.SelectedItem <> "" Then
            toggleButtons(1)
        End If
    End Sub

    Sub displayProfiles()
        If (Not Directory.Exists("profiles")) Then
            Try
                Directory.CreateDirectory("profiles")
            Catch
                MsgBox("Unable to create or load the profiles database!" & vbNewLine & "Make sure you are not running this program in a system protected directory (ex: ""Program Files"")" & vbNewLine & "You can try moving the program to another folder or run it as Administrator", vbCritical + vbOKOnly, "Profiles Database Error")
            End Try
        End If
        profilesList.Items.Clear()
        For Each file As String In Directory.GetFiles("profiles", "*.dwh")
            profilesList.Items.Add(Path.GetFileNameWithoutExtension(file))
        Next
    End Sub
    Sub toggleButtons(x As String)
        If x = 1 Then
            deleteBtn.Enabled = True
            useBtn.Enabled = True
            deleteBtn.BackColor = Color.FromArgb(114, 137, 218)
            useBtn.BackColor = Color.FromArgb(114, 137, 218)
            Return
        End If
        If x = 0 Then
            deleteBtn.Enabled = False
            useBtn.Enabled = False
            deleteBtn.BackColor = Color.FromArgb(32, 34, 37)
            useBtn.BackColor = Color.FromArgb(32, 34, 37)
        End If
    End Sub

    Private Sub Profiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Font = New Font(main.pfc.Families(0), 48, FontStyle.Bold)
        profilesList.Font = New Font(main.pfc.Families(0), 12, FontStyle.Regular)
        saveBtn.Font = New Font(main.pfc.Families(0), 14.25, FontStyle.Regular)
        deleteBtn.Font = New Font(main.pfc.Families(0), 14.25, FontStyle.Regular)
        useBtn.Font = New Font(main.pfc.Families(0), 14.25, FontStyle.Regular)
        displayProfiles()
    End Sub

End Class