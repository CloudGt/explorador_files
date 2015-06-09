Class cComparaLista

  ' La clase implementa la ordenaci�n manual de los elementos de las columnas.
  Implements IComparer

  ' ****************************************************************************
  ' ATRIBUTOS DE LA CLASE
  ' ****************************************************************************
  ' �ndice de la columna a ordenar.
  Private iCol As Integer
  ' Tipo de orden a realizar en la columna.
  Private bAsc As Boolean
  ' Tipo de datos sobre los que realizar la ordenaci�n.
  Private sTip As String


  ' ****************************************************************************
  ' * CONSTRUCTOR SIN ARGUMENTOS DE COMPARAR LISTA
  ' ****************************************************************************
  ' * Constructor cuando no se indican par�metros. Supone que la columna a
  ' * ordenar es la columna 0.
  ' ****************************************************************************
  Public Sub New()
    iCol = 0
  End Sub


  ' ****************************************************************************
  ' * CONSTRUCTOR CON ARGUMENTOS DE COMPARAR LISTA
  ' ****************************************************************************
  ' * Constructor con argumentos. Por defecto se presupone que se realizar� un
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
  ' * Funci�n encargada de convertir tama�os de datos a Bytes, comprobando la
  ' * unidad del dato.
  ' ****************************************************************************
  Public Function convertirUni(ByVal sTamano As String) As Long
    ' Resultado de la conversi�n
    Dim lValor As Long
    ' Cadena auxiliar con el tama�o del dato
    'Dim sAux As String

    ' Si la cadena no es vac�a...
    If sTamano <> " " And sTamano <> Nothing Then
      ' Obtenci�n del valor num�rico en el dato de tama�o.
      lValor = CType(sTamano.Substring(0, sTamano.IndexOf(" ") + 1), Integer)

      ' Dependiendo de la unidad de los datos, se proceder� a su conversi�n a
      ' bytes.
      If sTamano.Contains("KB") Then
        lValor = lValor * 1024    ' Unidad * 2^10
      ElseIf sTamano.Contains("MB") Then
        lValor = lValor * 1024 ^ 2 ' Unidad * 2^20
      ElseIf sTamano.Contains("GB") Then
        lValor = lValor * 1024 ^ 3 ' Unidad * 2^20
      End If
    Else
      ' En el caso de no haber un tama�o especificado, se asigna -1 para quedar
      ' en el orden siempre al final.
      lValor = -1
    End If

    Return lValor
  End Function




  ' ****************************************************************************
  ' * COMPARARENTEROS
  ' ****************************************************************************
  ' * Funci�n encargada de comparar dos enteros devolviendo los siguientes
  ' * valores:
  ' *  -1: si el primer valor es menor que el segundo valor.
  ' *   0: si los dos valores son iguales.
  ' *   1: si el segundo valor es mayor que el primero.
  ' ****************************************************************************
  Public Function compararEnteros(ByVal lA As Long, ByVal lB As Long) _
                                 As Long
    ' Contiene el resultado de la comparaci�n.
    Dim lResultado As Integer

    ' C�lculo de los resultados a devolver por la funci�n, asignando los valores
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
  ' * Funci�n encargada de la comparaci�n de los valores de la columna.
  ' * Comprueba el tipo de datos a comparar y a partir de ah� devuelve el
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
