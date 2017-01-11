Imports Microsoft.Practices.EnterpriseLibrary.Data


Module modFunciones
   '''<summary>
   '''Envia el string de la forma 'MiString'
   '''</summary>
   Public Function SendWhereNull(ByVal xCampo As String, ByVal xValor As String) As String
      If F_Null(xValor) Then
         Return " and " & xCampo & " is null"
      Else
         Return " and " & xCampo & "=" & Send(xValor)
      End If
   End Function
   '''<summary>
   '''Envia el string de la forma 'MiString'
   '''</summary>
   Public Function Send(ByVal xstring As String, Optional ByVal xNull As Boolean = True) As String
      If F_Null(xstring) Then
         If xNull Then Send = "Null" Else Send = " '' "
      Else
         Send = "'" & Trim(xstring).Replace("'", "''") & "'"
      End If
   End Function

   '''<summary>
   '''Convierte de Boolean a Integer
   '''</summary>
   Public Function F_BoolInt(ByVal xval As Boolean) As Integer
      If xval = False Then
         F_BoolInt = 0
      Else
         F_BoolInt = 1
      End If
   End Function

   '''<summary>
   '''Convierte de Integer a Boolean
   '''</summary>
   Public Function F_IntBool(ByVal xval As Integer) As Boolean
      If xval = 0 Then
         F_IntBool = False
      Else
         F_IntBool = True
      End If
   End Function

   '''<summary>
   '''Verifica si el campo esta nulo
   '''</summary>
   Public Function F_Null(ByVal xstring As String) As Boolean
      F_Null = True
      If xstring Is Nothing Then
         F_Null = True
      ElseIf Len(LTrim(RTrim(xstring))) = 0 Or xstring = "__/__/____" Or xstring = "__-___.___" Or xstring = "__:__" Or xstring = "  /  /" Or Trim(xstring) = ":" Or Trim(xstring) = Trim("  /  /   :") Then
         F_Null = True
      Else
         F_Null = False
      End If
   End Function
   Public Function F_Null(ByVal Row As DataRow) As Boolean
      If Row Is Nothing Then Return True Else Return False
   End Function
   Public Function F_Null(ByVal Table As DataTable) As Boolean
      If Table Is Nothing Then Return True Else Return False
   End Function
   Public Function F_Null(ByVal xobject As Object) As Boolean
      F_Null = True
      If xobject Is Nothing Then
         F_Null = True
      ElseIf Len(LTrim(RTrim(xobject))) = 0 Or xobject = "__/__/____" Or xobject = "__-___.___" Or xobject = "__:__" Or xobject = "  /  /" Or Trim(xobject) = ":" Or Trim(xobject) = Trim("  /  /   :") Then
         F_Null = True
      Else
         F_Null = False
      End If
   End Function

   ''' <summary>
   ''' Si el parametro por defecto es nulo devuelve el segundo parametro
   ''' </summary>
   ''' <param name="ParamDefecto">Parametro por defecto</param>
   ''' <param name="ParamOpcional">Parametro Opcional a devolver si el parametro por defecto esta nulo</param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Function F_NVL(ByVal ParamDefecto As String, ByVal ParamOpcional As String) As String
      If IsDBNull(ParamDefecto) Or Trim(ParamDefecto) = "" Or Trim(ParamDefecto) = "__/__/____" Or Trim(ParamDefecto) = "__-___.___" Or Trim(ParamDefecto) = "__:__" Or Trim(ParamDefecto) = "Null" Or Trim(ParamDefecto) = Trim("  /  /") Then
         F_NVL = Trim(ParamOpcional)
      Else
         F_NVL = Trim(ParamDefecto)
      End If
   End Function

   Public Function F_UnFormat(ByVal zString As String, Optional ByVal xInt As Integer = 20, Optional xDec As Integer = 2, Optional xNull As Boolean = False) As String
      'Devuelve el formato específico sin comas

      If F_Null(zString) And xNull Then
         F_UnFormat = ""
         Exit Function
      End If

      If F_Null(zString) Then zString = "0"


      Return Math.Round(Val(zString.Replace(",", "")), xDec)

   End Function


#Region "Reportes del sistema"
   Public Function FillDescuentosNomina(ByVal FechaInicial As Date, ByVal FechaFinal As Date) As DataTable
      Dim factory As DatabaseProviderFactory = New DatabaseProviderFactory
      Dim SolidarismoDB As Microsoft.Practices.EnterpriseLibrary.Data.Database = factory.Create("Solidarismo")
      Return SolidarismoDB.ExecuteDataSet("UpSMovimientoRetenciones", FechaInicial, FechaFinal).Tables(0)
   End Function

#End Region

End Module
