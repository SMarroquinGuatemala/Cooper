Imports System.ComponentModel
Imports System.Linq.Expressions

Public Class MySortableBindingList(Of T)
    Inherits BindingList(Of T)
    ' reference to the list provided at the time of instantiation
    Private originalList As List(Of T)
    Private sortDirection As ListSortDirection
    Private sortProperty As PropertyDescriptor

    ' function that refereshes the contents
    ' of the base classes collection of elements
    Dim populateBaseList As Action(Of MySortableBindingList(Of T), List(Of T)) = Function(a, b) (b) 'a.ResetItems(b)
    ' a cache of functions that perform the sorting
    ' for a given type, property, and sort direction
    Shared cachedOrderByExpressions As New Dictionary(Of String, Func(Of List(Of T), IEnumerable(Of T)))()

    Public Sub New()
        originalList = New List(Of T)()
    End Sub

    Public Sub New(enumerable As IEnumerable(Of T))
        originalList = enumerable.ToList()
        populateBaseList(Me, originalList)
    End Sub

    Public Sub New(list As List(Of T))
        originalList = list
        populateBaseList(Me, originalList)
    End Sub

    Protected Overrides Sub ApplySortCore(prop As PropertyDescriptor, direction As ListSortDirection)
        '
        '         Look for an appropriate sort method in the cache if not found .
        '         Call CreateOrderByMethod to create one. 
        '         Apply it to the original list.
        '         Notify any bound controls that the sort has been applied.
        '         


        sortProperty = prop

        Dim orderByMethodName As Object = If(sortDirection = ListSortDirection.Ascending, "OrderBy", "OrderByDescending")
        Dim cacheKey As Object = String.Concat(GetType(T).GUID, prop.Name, orderByMethodName)

        If Not cachedOrderByExpressions.ContainsKey(cacheKey) Then
            CreateOrderByMethod(prop, orderByMethodName, cacheKey)
        End If

        ResetItems(cachedOrderByExpressions(cacheKey)(originalList).ToList())
        ResetBindings()
        sortDirection = If(sortDirection = ListSortDirection.Ascending, ListSortDirection.Descending, ListSortDirection.Ascending)
    End Sub


    Private Sub CreateOrderByMethod(prop As PropertyDescriptor, orderByMethodName As String, cacheKey As String)

        '
        '         Create a generic method implementation for IEnumerable<T>.
        '         Cache it.
        '        


        Dim sourceParameter As Object = Expression.Parameter(GetType(List(Of T)), "source")
        Dim lambdaParameter As Object = Expression.Parameter(GetType(T), "lambdaParameter")
        Dim accesedMember As Object = GetType(T).GetProperty(prop.Name)
        Dim propertySelectorLambda As Object = Expression.Lambda(Expression.MakeMemberAccess(lambdaParameter, accesedMember), lambdaParameter)
        Dim orderByMethod As Object = GetType(Enumerable).GetMethods().Where(Function(a) a.Name = orderByMethodName AndAlso a.GetParameters().Length = 2).[Single]().MakeGenericMethod(GetType(T), prop.PropertyType)

        Dim orderByExpression As Object = Expression.Lambda(Of Func(Of List(Of T), IEnumerable(Of T)))(Expression.[Call](orderByMethod, New Expression() {sourceParameter, propertySelectorLambda}), sourceParameter)

        cachedOrderByExpressions.Add(cacheKey, orderByExpression.Compile())
    End Sub

    Protected Overrides Sub RemoveSortCore()
        ResetItems(originalList)
    End Sub

    Private Sub ResetItems(items As List(Of T))

        MyBase.ClearItems()

        Dim i As Integer = 0
        While i < items.Count
            MyBase.InsertItem(i, items(i))
            System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While
    End Sub

    Protected Overrides ReadOnly Property SupportsSortingCore() As Boolean
        Get
            ' indeed we do
            Return True
        End Get
    End Property

    Protected Overrides ReadOnly Property SortDirectionCore() As ListSortDirection
        Get
            Return sortDirection
        End Get
    End Property

    Protected Overrides ReadOnly Property SortPropertyCore() As PropertyDescriptor
        Get
            Return sortProperty
        End Get
    End Property

    Protected Overrides Sub OnListChanged(e As ListChangedEventArgs)
        originalList = MyBase.Items.ToList()
    End Sub
End Class


