Imports System.IO


Public Class FrmGenerarArchivoBanco
    Private bancos As New CooperativaBLL.clsBancos
    Private CuentaBancariaValue As String
    Public Property CuentaBancaria() As String
        Get
            Return CuentaBancariaValue
        End Get
        Set(ByVal value As String)
            CuentaBancariaValue = value
        End Set
    End Property

    Private ChequeInicialValue As String
    Public Property ChequeInicial() As String
        Get
            Return ChequeInicialValue
        End Get
        Set(ByVal value As String)
            ChequeInicialValue = value
        End Set
    End Property

    Private ChequeFinalValue As String
    Public Property ChequeFinal() As String
        Get
            Return ChequeFinalValue
        End Get
        Set(ByVal value As String)
            ChequeFinalValue = value
        End Set
    End Property




    Public Sub CrearFiletxt(ByVal CuentaBancaria As String, ByVal ChequeInicial As String, ByVal ChequeFinal As String, ByVal Ubicacion As String)
        Try
            Using Fs As FileStream = New FileStream(System.IO.Path.Combine(Ubicacion, String.Concat(CuentaBancaria, ChequeInicial, ChequeFinal, ".txt")), FileMode.Append), Log As StreamWriter = New StreamWriter(Fs)

            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerarArchivo.Click
        Try
            If String.IsNullOrEmpty(lblCuentaBancaria.Text) Then Throw New Exception("El número de cuenta no debe de estar en blanco")
            If String.IsNullOrEmpty(lblDocumentoInicial.Text) Then Throw New Exception("El número de documento inicial no debe de estar en blanco")
            If String.IsNullOrEmpty(lblDocumentoFinal.Text) Then Throw New Exception("El número de documento final no debe de estar en blanco")

            Dim myStream As Stream
            Dim swEscritor As StreamWriter
            Dim saveFileDialog1 As New SaveFileDialog()
            If (grdDatos.Rows.Count > 0) Then
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt"
                saveFileDialog1.FilterIndex = 2
                saveFileDialog1.InitialDirectory = "C:\arclot"
                saveFileDialog1.RestoreDirectory = True
                saveFileDialog1.FileName = String.Concat(Me.CuentaBancaria.ToString.Replace("–", ""), Me.ChequeInicial, Me.ChequeFinal)
                If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                    myStream = saveFileDialog1.OpenFile()
                    If (myStream IsNot Nothing) Then
                        myStream.Close()
                        swEscritor = New StreamWriter(saveFileDialog1.FileName)
                        For Each row As DataGridViewRow In grdDatos.Rows
                            swEscritor.WriteLine(row.Cells.Item("TextoArchivo").Value.ToString)
                        Next
                        swEscritor.Flush()
                        swEscritor.Close()
                        bancos.ActualizaChequesBancos(lblCuentaBancaria.Text, lblDocumentoInicial.Text, lblDocumentoFinal.Text)
                    End If
                    MsgBox("Archivo generado correctamente", MsgBoxStyle.Information, My.Resources.MensajedelSistema)
                    Button2_Click(sender, e)
                End If
            Else
                MsgBox("No hay registros para generar el archivo", MsgBoxStyle.Information, My.Resources.MensajedelSistema)
            End If
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If String.IsNullOrEmpty(txtFechaInicial.Text.Replace(txtFechaInicial.Culture.DateTimeFormat.DateSeparator, "").Replace(txtFechaInicial.Culture.DateTimeFormat.TimeSeparator, "").Trim) Then
                MsgBox("El campo fecha inicial es requerido para el proceso", MsgBoxStyle.Information, My.Resources.MensajedelSistema)
                ActiveControl = txtFechaInicial
                Exit Sub
            End If

            If String.IsNullOrEmpty(txtFechaInicial.Text.Replace(txtFechaInicial.Culture.DateTimeFormat.DateSeparator, "").Replace(txtFechaInicial.Culture.DateTimeFormat.TimeSeparator, "").Trim) Then
                MsgBox("El campo fecha final es requerido para el proceso", MsgBoxStyle.Information, My.Resources.MensajedelSistema)
                ActiveControl = txtFechaFinal
                Exit Sub
            End If

            grdDatos.DataSource = bancos.GetListChequesAutorizados(txtFechaInicial.Text, txtFechaFinal.Text, txtDocumentoInicial.Text, txtDocumentoFinal.Text)
            xTableDefault = New DataTable
            xTableDefault = bancos.GetParametrosNombreArchivo(txtFechaInicial.Text, txtFechaFinal.Text, txtDocumentoInicial.Text, txtDocumentoFinal.Text)
            If (Not xTableDefault.Rows.Count = 0) Then
                Me.ChequeInicial = xTableDefault.Rows(0).Item("NumeroDocumentoInicial").ToString
                Me.ChequeFinal = xTableDefault.Rows(0).Item("NumeroDocumentoFinal").ToString
                Me.CuentaBancaria = xTableDefault.Rows(0).Item("CuentaBancaria").ToString
                lblCuentaBancaria.Text = Me.CuentaBancaria
                lblDocumentoInicial.Text = Me.ChequeInicial
                lblDocumentoFinal.Text = Me.ChequeFinal
            End If

        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub FrmGenerarArchivoBanco_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            txtFechaInicial.Text = F_PrimerDiaSemana(txtFechaInicial.Text)
            txtFechaFinal.Text = F_UltimoDiaSemana(txtFechaFinal.Text)

        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub txtDocumentoFinal_GotFocus(sender As Object, e As EventArgs) Handles txtDocumentoFinal.GotFocus
        If Not String.IsNullOrEmpty(txtDocumentoInicial.Text) Then
            txtDocumentoFinal.Text = txtDocumentoInicial.Text
            txtDocumentoFinal.SelectAll()
        End If
    End Sub
End Class