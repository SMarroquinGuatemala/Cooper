Public Class FrmBasePrestamosTecleo
    Dim NivelesDeAcceso As New CooperativaBLL.NivelOrganizacionalClass
    Private NivelOrganizacionalValue As Integer
    Public Property NivelOrganizacional() As Integer
        Get
            Return NivelOrganizacionalValue
        End Get
        Set(ByVal value As Integer)
            NivelOrganizacionalValue = value
        End Set
    End Property


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If Not String.IsNullOrEmpty(txtValor.Text) Then
                If IsNumeric(txtValor.Text) Then
                    If Not Val(txtValor.Text) = 0 Then
                        NivelesDeAcceso.NivelOrganizacional = txtNivelOrganizacional.Text

                        NivelesDeAcceso.Nombre = txtNombre.Text
                        NivelesDeAcceso.ValorBasePrestamo = txtValor.Text
                        NivelesDeAcceso.Save()
                        MsgBox(My.Resources.MensajeGrabar, MsgBoxStyle.Information, My.Resources.MensajedelSistema)
                        Me.Close()
                    Else
                        MsgBox("Debe de ingresar un valor", MsgBoxStyle.Information, My.Resources.MensajedelSistema)
                        ActiveControl = txtValor
                    End If
                Else
                    MsgBox("Formato incorrecto", MsgBoxStyle.Information, My.Resources.MensajedelSistema)
                    ActiveControl = txtValor
                End If
            Else
                MsgBox("Debe de ingresar un valor", MsgBoxStyle.Information, My.Resources.MensajedelSistema)
                ActiveControl = txtValor
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmBasePrestamosTecleo_Load(sender As Object, e As EventArgs) Handles Me.Load
        NivelesDeAcceso.NivelOrganizacional = Me.NivelOrganizacional
        NivelesDeAcceso.FillList()
        txtNivelOrganizacional.Text = Me.NivelOrganizacional
        ActiveControl = txtValor
    End Sub

    Private Sub txtNivelOrganizacional_TextChanged(sender As Object, e As EventArgs) Handles txtNivelOrganizacional.TextChanged
        Try
            txtNombre.Text = NivelesDeAcceso.NivelesOrganicacionales.Find(Function(x) x.NivelOrganizacional = txtNivelOrganizacional.Text).Nombre.ToString
            txtValor.Text = NivelesDeAcceso.NivelesOrganicacionales.Find(Function(x) x.NivelOrganizacional = txtNivelOrganizacional.Text).ValorBasePrestamo.ToString
        Catch ex As Exception

        End Try
    End Sub
End Class