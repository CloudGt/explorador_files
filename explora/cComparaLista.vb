Class cComparaLista

  ' La clase implementa la ordenación manual de los elementos de las columnas.
  Implements IComparer

  ' ****************************************************************************
  ' ATRIBUTOS DE LA CLASE
  ' ****************************************************************************
  ' Índice de la columna a ordenar.
  Private iCol As Integer
  ' Tipo de orden a realizar en la columna.
  Private bAsc As Boolean
  ' Tipo de datos sobre los que realizar la ordenación.
  Private sTip As String


  ' ****************************************************************************
  ' * CONSTRUCTOR SIN ARGUMENTOS DE COMPARAR LISTA
  ' ****************************************************************************
  ' * Constructor cuando no se indican parámetros. Supone que la columna a
  ' * ordenar es la columna 0.
  ' ****************************************************************************
  Public Sub New()
    iCol = 0
  End Sub


  ' ****************************************************************************
  ' * CONSTRUCTOR CON ARGUMENTOS DE COMPARAR LISTA
  ' ****************************************************************************
  ' * Constructor con argumentos. Por defecto se presupone que se realizará un
  ' * orden ascendente y el tipo de datos a ordenar es una cadena.
  ' ****************************************************************************
  Public Sub New(ByVal column As Integer, _
                 Optional ByVal bAscendente As Boolean = True, _
                 Optional ByVal sTipo As String = "cadena")
    iCol = column
    bAsc = bAscendente
    sTip = sTipo
  End Sub


  ' ****************************************************************************
  ' * CONVERTIRUNI
  ' ****************************************************************************
  ' * Función encargada de convertir tamaños de datos a Bytes, comprobando la
  ' * unidad del dato.
  ' ****************************************************************************
  Public Function convertirUni(ByVal sTamano As String) As Long
    ' Resultado de la conversión
    Dim lValor As Long
    ' Cadena auxiliar con el tamaño del dato
    'Dim sAux As String

    ' Si la cadena no es vacía...
    If sTamano <> " " And sTamano <> Nothing Then
      ' Obtención del valor numérico en el dato de tamaño.
      lValor = CType(sTamano.Substring(0, sTamano.IndexOf(" ") + 1), Integer)

      ' Dependiendo de la unidad de los datos, se procederá a su conversión a
      ' bytes.
      If sTamano.Contains("KB") Then
        lValor = lValor * 1024    ' Unidad * 2^10
      ElseIf sTamano.Contains("MB") Then
        lValor = lValor * 1024 ^ 2 ' Unidad * 2^20
      ElseIf sTamano.Contains("GB") Then
        lValor = lValor * 1024 ^ 3 ' Unidad * 2^20
      End If
    Else
      ' En el caso de no haber un tamaño especificado, se asigna -1 para quedar
      ' en el orden siempre al final.
      lValor = -1
    End If

    Return lValor
  End Function




  ' ****************************************************************************
  ' * COMPARARENTEROS
  ' ****************************************************************************
  ' * Función encargada de comparar dos enteros devolviendo los siguientes
  ' * valores:
  ' *  -1: si el primer valor es menor que el segundo valor.
  ' *   0: si los dos valores son iguales.
  ' *   1: si el segundo valor es mayor que el primero.
  ' ****************************************************************************
  Public Function compararEnteros(ByVal lA As Long, ByVal lB As Long) _
                                 As Long
    ' Contiene el resultado de la comparación.
    Dim lResultado As Integer

    ' Cálculo de los resultados a devolver por la función, asignando los valores
    ' indicados en la cabecera.
    If lA < lB Then
      lResultado = -1
    ElseIf lA = lB Then
      lResultado = 0
    Else
      lResultado = 1
    End If

    Return lResultado
  End Function


  ' ****************************************************************************
  ' * COMPARAR
  ' ****************************************************************************
  ' * Función encargada de la comparación de los valores de la columna.
  ' * Comprueba el tipo de datos a comparar y a partir de ahí devuelve el
  ' * resultado correspondiente.
  ' ****************************************************************************
  Public Function comparar(ByVal x As Object, _
  ByVal y As Object) As Integer _
  Implements IComparer.Compare

    Select Case sTip
      Case "espacio"
        If bAsc Then
          Return compararEnteros( _
                 convertirUni(CType(x, ListViewItem).SubItems(iCol).Text), _
                 convertirUni(CType(y, ListViewItem).SubItems(iCol).Text))
        Else
          Return compararEnteros( _
                 convertirUni(CType(y, ListViewItem).SubItems(iCol).Text), _
                 convertirUni(CType(x, ListViewItem).SubItems(iCol).Text))
        End If

      Case "fecha"
        If bAsc Then
          Return [Date].Compare(CType(x, ListViewItem).SubItems(iCol).Text, _
                         CType(y, ListViewItem).SubItems(iCol).Text)
        Else
          Return [Date].Compare(CType(y, ListViewItem).SubItems(iCol).Text, _
                         CType(x, ListViewItem).SubItems(iCol).Text)
        End If

      Case "cadena"
        If bAsc Then
          Return [String].Compare(CType(x, ListViewItem).SubItems(iCol).Text, _
                                  CType(y, ListViewItem).SubItems(iCol).Text)
        Else
          Return [String].Compare(CType(y, ListViewItem).SubItems(iCol).Text, _
                                  CType(x, ListViewItem).SubItems(iCol).Text)
        End If

      Case Else

    End Select

  End Function

End Class
