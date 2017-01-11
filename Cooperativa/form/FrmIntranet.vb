Public Class FrmIntranet
    Dim WithEvents Web_V1 As System.Windows.Forms.WebBrowser

    Private Sub Form_Load()
        Web_V1 = webIntranet
    End Sub

    Private Sub Web_V1_NewWindow(ByVal URL As String, ByVal Flags As Long, ByVal TargetFrameName As String, PostData As Object, ByVal Headers As String, Processed As Boolean)
       
    End Sub
    Private Sub FrmIntranet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            webIntranet.Navigate("http://intsdfca1:83/cooperativa/?FechaOperacion=" & FechaOperacion & "&LoginApp=" & Usuario)
        Catch ex As Exception
            F_Error(ex, "Cargar Intranet")
        End Try
    End Sub

    Private Sub webIntranet_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles webIntranet.DocumentCompleted

    End Sub

    Private Sub webIntranet_NewWindow(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles webIntranet.NewWindow
       
    End Sub
End Class