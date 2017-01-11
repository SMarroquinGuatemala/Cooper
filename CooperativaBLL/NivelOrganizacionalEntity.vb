Public Class NivelOrganizacionalEntity
   Implements IEquatable(Of NivelOrganizacionalEntity)

   Private NivelOrganizacionalValue As Nullable(Of Integer)
   Public Property NivelOrganizacional() As Nullable(Of Integer)
      Get
         Return NivelOrganizacionalValue
      End Get
      Set(ByVal value As Nullable(Of Integer))
         NivelOrganizacionalValue = value
      End Set
   End Property

   Private NombreValue As String

   Public Property Nombre() As String
      Get
         Return NombreValue
      End Get
      Set(ByVal value As String)
         NombreValue = value
      End Set
   End Property

   Private ValorBasePrestamoValue As Decimal
   Public Property ValorBasePrestamo() As Decimal
      Get
         Return ValorBasePrestamoValue
      End Get
      Set(ByVal value As Decimal)
         ValorBasePrestamoValue = value
      End Set
   End Property

   Private PermanenteValue As Boolean
   Public Property Permanente() As Boolean
      Get
         Return PermanenteValue
      End Get
      Set(ByVal value As Boolean)
         PermanenteValue = value
      End Set
   End Property



   Public Overloads Function Equals(other As NivelOrganizacionalEntity) As Boolean Implements IEquatable(Of NivelOrganizacionalEntity).Equals
      If other Is Nothing Then Return False
      If Me.NivelOrganizacional = other.NivelOrganizacional Then
         Return True
      Else
         Return False
      End If
   End Function
   Public Overrides Function Equals(obj As Object) As Boolean
      If obj Is Nothing Then Return False

      Dim NivelOrganizacionalObj As NivelOrganizacionalEntity = TryCast(obj, NivelOrganizacionalEntity)
      If NivelOrganizacionalObj Is Nothing Then
         Return False
      Else
         Return Equals(NivelOrganizacionalObj)
      End If
   End Function

   Public Overrides Function GetHashCode() As Integer
      Return Me.NivelOrganizacional.GetHashCode()
   End Function
End Class
