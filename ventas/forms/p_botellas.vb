Imports MySql.Data.MySqlClient
Imports System.Math
Public Class p_botellas
    Private _cantUnidad As Decimal
    Private _pesoCerrada As Decimal
    Private _pesoAbierta As Decimal
    Private _aingreso As Integer
    Private _conteo As Integer
    Private _precio As Decimal
    Private _saldo As Decimal
    Private _dia As String
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim nCerrada, nAbierta, nDifPesos, nCantidad, nCantidad_c, nCantidad_a As Decimal
        Dim n As Integer = 0, m As Integer
        If Len(txtBotCerrada.Text) = 0 Then
            nCerrada = 0
        Else
            nCerrada = txtBotCerrada.Text
        End If
        If Len(txtBotAbierta.Text) = 0 Then
            nAbierta = 0
        Else
            nAbierta = txtBotAbierta.Text
        End If
        nDifPesos = _pesoCerrada - _pesoAbierta
        If nDifPesos > 0 Then
            nCantidad_c = nCerrada * nDifPesos
        Else
            nCantidad_c = nCerrada * _cantUnidad
        End If
        'If _pesoCerrada = _pesoAbierta Then
        '    nCantidad_a = 0
        'Else
        '    If nAbierta > 0 Then
        '        nCantidad_a = ((nAbierta * _cantUnidad) / nDifPesos) - nDifPesos
        '    Else
        '        nCantidad_a = 0
        '    End If
        'End If
        If _pesoCerrada = _pesoAbierta Then
            nCantidad_a = 0
        Else
            If nAbierta > 0 Then
                Do While (nAbierta >= _pesoCerrada)
                    nAbierta = nAbierta - _pesoCerrada
                    n = n + 1
                Loop
                m = IIf(nAbierta >= _pesoAbierta, 1, 0)
                nCantidad_a = ((n * nDifPesos) + nAbierta) - (m * _pesoAbierta)
            Else
                nCantidad_a = 0
            End If
        End If
        nCantidad = Round(nCantidad_c + nCantidad_a, 4)
        p_inventario.recCantidadBotella(nCantidad, True)
        p_inventario.actualizaDetalle(0, _aingreso, nCantidad, 0, _precio, pIGV, _saldo)
        Me.Close()
    End Sub
    Sub datosBotellas(ByVal cant_uni As Decimal, ByVal bot_cerrada As Decimal, ByVal bot_abierta As Decimal _
           , ByVal aingreso As Integer, ByVal aprecio As Decimal, ByVal saldo As Decimal)
        _cantUnidad = cant_uni
        _pesoCerrada = bot_cerrada
        _pesoAbierta = bot_abierta
        _aingreso = aingreso
        _precio = aprecio
        _saldo = saldo
        'If _pesoCerrada = _pesoAbierta Then
        '    txtBotAbierta.Enabled = False
        'Else
        '    txtBotCerrada.Enabled = True
        'End If
    End Sub

    Private Sub p_botellas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBotCerrada.Focus()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub
End Class
