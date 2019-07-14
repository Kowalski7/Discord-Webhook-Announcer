Imports System.Collections.Specialized
Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization

Public Class main
    Private Sub ProfilePicLink_TextChanged(sender As Object, e As EventArgs) Handles profilePicLink.TextChanged
        If profilePicLink.Text = "" Then
            profilePic.Image = My.Resources.default_picture
            profilePic.SizeMode = ImageLayout.Zoom
            Return
        End If
        Try
            Dim tClient As WebClient = New WebClient
            Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(profilePicLink.Text)))
            profilePic.Image = tImage
            profilePic.SizeMode = ImageLayout.Zoom
        Catch
            profilePic.Image = My.Resources.error_picture
            profilePic.SizeMode = ImageLayout.Zoom
        End Try
    End Sub

    Private Sub Send_Click(sender As Object, e As EventArgs) Handles send.Click
        Dim dcWeb As dWebHook = New dWebHook
        If username.Text = "Webhook" Then
            dcWeb.UserName = ""
        Else
            dcWeb.UserName = username.Text
        End If
        dcWeb.WebHook = webhookLink.Text
        dcWeb.ProfilePicture = profilePicLink.Text
        dcWeb.SendMessage(messageField.Text)
    End Sub

    Private Sub profilesBtn_Click(sender As Object, e As EventArgs) Handles profilesBtn.Click
        profiles.Show()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        profilePic.SizeMode = ImageLayout.Zoom
        circleOverlay.Parent = profilePic
        circleOverlay.BackColor = Color.Transparent
        circleOverlay.Location = New Point(0, 0)
        Dim pfc As New Drawing.Text.PrivateFontCollection
        If Not File.Exists(Path.GetTempPath + "\whitney_font.ttf") Then
            My.Computer.FileSystem.WriteAllBytes(Path.GetTempPath + "\whitney_font.ttf", My.Resources.whitney, False)
        End If
        pfc.AddFontFile(Path.GetTempPath + "\whitney_font.ttf")
        username.Font = New Font(pfc.Families(0), 27.75, FontStyle.Bold)
        Label1.Font = New Font(pfc.Families(0), 12, FontStyle.Regular)
        Label2.Font = New Font(pfc.Families(0), 12, FontStyle.Regular)
        Label3.Font = New Font(pfc.Families(0), 12, FontStyle.Regular)
        autoFetch.Font = New Font(pfc.Families(0), 12, FontStyle.Regular)
        messageField.Font = New Font(pfc.Families(0), 12, FontStyle.Regular)
        profilesBtn.Font = New Font(pfc.Families(0), 14.25, FontStyle.Regular)
        send.Font = New Font(pfc.Families(0), 18, FontStyle.Regular)
        profiles.Label1.Font = New Font(pfc.Families(0), 48, FontStyle.Bold)
        profiles.profilesList.Font = New Font(pfc.Families(0), 12, FontStyle.Regular)
        profiles.saveBtn.Font = New Font(pfc.Families(0), 14.25, FontStyle.Regular)
        profiles.deleteBtn.Font = New Font(pfc.Families(0), 14.25, FontStyle.Regular)
        profiles.useBtn.Font = New Font(pfc.Families(0), 14.25, FontStyle.Regular)
    End Sub

    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged
        If username.Text = "" Then
            username.Text = "Webhook"
        End If
    End Sub

    Private Sub WebhookLink_TextChanged(sender As Object, e As EventArgs) Handles webhookLink.TextChanged
        If autoFetch.Checked = True Then
            fetchWHinfo(1, 1)
        End If
    End Sub
    Sub fetchWHinfo(uCheck As String, pCheck As String)
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader
        Try
            request = DirectCast(WebRequest.Create(webhookLink.Text), HttpWebRequest)

            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            Dim rawresp As String
            rawresp = reader.ReadToEnd()
            Dim jss As New JavaScriptSerializer()
            Dim dict As Dictionary(Of String, String) = jss.Deserialize(Of Dictionary(Of String, String))(rawresp)

            If uCheck = 1 Then
                username.Text = dict("name")
            End If
            If pCheck = 1 Then
                profilePicLink.Text = "https://cdn.discordapp.com/avatars/" + dict("id") + "/" + dict("avatar") + ".png?size=128"
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class

Public Class dWebHook
    Implements IDisposable

    Private ReadOnly client As WebClient
    Private Shared discordValues As NameValueCollection = New NameValueCollection()
    Public Property WebHook As String
    Public Property UserName As String
    Public Property ProfilePicture As String

    Public Sub New()
        client = New WebClient()
    End Sub

    Public Sub SendMessage(ByVal msgSend As String)
        If msgSend = "" Or WebHook = "" Then
            MsgBox("The webhook link and message are required!", vbCritical + vbOKOnly)
            Return
        End If
        discordValues.Add("username", UserName)
        discordValues.Add("avatar_url", ProfilePicture)
        discordValues.Add("content", msgSend)

        client.UploadValues(WebHook, discordValues)

        discordValues.Remove("username")
        discordValues.Remove("avatar_url")
        discordValues.Remove("content")
    End Sub

    Public Sub Dispose()
        client.Dispose()
    End Sub

    Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
        DirectCast(client, IDisposable).Dispose()
    End Sub
End Class
