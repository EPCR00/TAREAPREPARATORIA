Public Class Form1

    Private Sub lino_CheckedChanged(sender As Object, e As EventArgs) Handles lino.CheckedChanged
        If lino.Checked = True Then
            txtlino.Enabled = True
            txtlino.Text = "0"
        Else
            txtlino.Enabled = False
            txtlino.Text = "0"
        End If
    End Sub

    Private Sub algodon_CheckedChanged(sender As Object, e As EventArgs) Handles algodon.CheckedChanged
        If algodon.Checked = True Then
            txtalgodon.Enabled = True
            txtalgodon.Text = "0"
        Else
            txtalgodon.Enabled = False
            txtalgodon.Text = "0"
        End If
    End Sub

    Private Sub seda_CheckedChanged(sender As Object, e As EventArgs) Handles seda.CheckedChanged
        If seda.Checked = True Then
            txtseda.Enabled = True
            txtseda.Text = "0"
        Else
            txtseda.Enabled = False
            txtseda.Text = "0"
        End If
    End Sub

    Private Sub hilocrudo_CheckedChanged(sender As Object, e As EventArgs) Handles hilocrudo.CheckedChanged
        If hilocrudo.Checked = True Then
            txthilocrudo.Enabled = True
            txthilocrudo.Text = "0"
        Else
            txthilocrudo.Enabled = False
            txthilocrudo.Text = "0"
        End If
    End Sub

    Private Sub aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
        sumayardas = Val(txtlino.Text) + Val(txtalgodon.Text) + Val(txtseda.Text) + Val(txthilocrudo.Text)

        costo.Text = "0.00"
        venta.Text = "0.00"
        totalalgodon.Text = "0.00"
        totalhilocrudo.Text = "0.00"
        totallino.Text = "0.00"
        totalseda.Text = "0.00"


        If king.Checked = True Then
            If sumayardas = matking Then
                preciocosto = precioking + Val(txtlino.Text) * preciolino + Val(txtalgodon.Text) * precioalgodon + Val(txtseda.Text) * precioseda + Val(txthilocrudo.Text) * preciohilocrudo

            Else
                MsgBox("Cantidad de Material Incorrecta", vbExclamation, "Advertencia")

            End If

        ElseIf queen.Checked = True Then
            If sumayardas = matqueen Then
                preciocosto = precioQueen + Val(txtlino.Text) * preciolino + Val(txtalgodon.Text) * precioalgodon + Val(txtseda.Text) * precioseda + Val(txthilocrudo.Text) * preciohilocrudo

            Else
                MsgBox("Cantidad de Material Incorrecta", vbExclamation, "Advertencia")

            End If

        ElseIf matrimonial.Checked = True Then
            If sumayardas = matmatrimonial Then
                preciocosto = precioMatrimonial + Val(txtlino.Text) * preciolino + Val(txtalgodon.Text) * precioalgodon + Val(txtseda.Text) * precioseda + Val(txthilocrudo.Text) * preciohilocrudo

            Else
                MsgBox("Cantidad de Material Incorrecta", vbExclamation, "Advertencia")

            End If

        ElseIf imperial.Checked = True Then
            If sumayardas = matimperial Then
                preciocosto = precioImperial + Val(txtlino.Text) * preciolino + Val(txtalgodon.Text) * precioalgodon + Val(txtseda.Text) * precioseda + Val(txthilocrudo.Text) * preciohilocrudo

            Else
                MsgBox("Cantidad de Material Incorrecta", vbExclamation, "Advertencia")

            End If

        End If

        costo.Text = Str(preciocosto)
        venta.Text = Val(costo.Text) + Val(costo.Text) * porcentajeganancia
        totallino.Text = Val(txtlino.Text) * preciolino
        totalalgodon.Text = Val(txtalgodon.Text) * precioalgodon
        totalseda.Text = Val(txtseda.Text) * precioseda
        totalhilocrudo.Text = Val(txthilocrudo.Text) * preciohilocrudo

    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        If MsgBox("¿Desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        txtlino.Clear()
        txtseda.Clear()
        txtalgodon.Clear()
        txthilocrudo.Clear()



    End Sub
End Class
