Public Class frmInfo

  ' Controla la opacidad de la aplicación
  Private iIndice As Integer

  ' ****************************************************************************
  ' * FRMINFO_LOAD
  ' ****************************************************************************
  ' * Inicialización de la ventana.
  ' ****************************************************************************
  Private Sub frmInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ' Reinicio del contador para aplicar el efecto de aparición.
    iIndice = 1

    ' Establecimiento de la ventana como transparente.
    Me.Opacity = 0

    ' Activación del cronómetro para crear el efecto.
    Me.tmrReloj.Enabled = True
  End Sub

  ' ****************************************************************************
  ' * TMRRELOJ_TICK
  ' ****************************************************************************
  ' * Crea el efecto de aparición en la ventana.
  ' ****************************************************************************
  Private Sub tmrReloj_Tick(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) _
                            Handles tmrReloj.Tick
    ' Variable auxiliar para obtener resultados reales y no enteros
    Dim dAux As Double

    ' Mientras no se llegue a una opacidad del 100% (iIndice / 10 = 100)
    If iIndice < 1001 Then
      dAux = iIndice
      Me.Opacity = dAux / 10.0
      iIndice = iIndice + 1
    Else ' Desactivación del cronómetro al llegar al límite de opacidad
      Me.tmrReloj.Enabled = False
    End If
  End Sub

  ' ****************************************************************************
  ' * PBIMAGEN_CLICK
  ' ****************************************************************************
  ' * Cierra la ventana al hacer clic sobre la imagen
  ' ****************************************************************************
  Private Sub pbImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbImagen.Click
    Me.Close()
  End Sub

End Class