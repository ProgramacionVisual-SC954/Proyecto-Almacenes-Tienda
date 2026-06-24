Public Class Verdetalles

    ' Empleado cuya ficha se muestra/edita en esta pantalla
    Public Property EmpleadoSeleccionado As Empleado

    ' Referencia al Form1 que abrió esta ficha, para refrescar su ListView al guardar
    Public Property FormPadre As Form1

    Private Sub Verdetalles(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarFicha()
    End Sub

    ' ---------- Carga inicial de la ficha ----------

    Private Sub CargarFicha()
        If EmpleadoSeleccionado Is Nothing Then
            MessageBox.Show("No se recibió ningún empleado para mostrar.", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        Label6.Text = EmpleadoSeleccionado.Nombre        ' Empleado:
        Label7.Text = EmpleadoSeleccionado.Departamento  ' Departamento:

        If TypeOf EmpleadoSeleccionado Is Gerente Then
            Dim gerente As Gerente = CType(EmpleadoSeleccionado, Gerente)

            Label8.Text = "Gerente"                      ' Puesto:
            Label4.Text = "Porcentaje de Bono:"
            Label9.Text = $"{gerente.PorcentajeBono}%"
            Label5.Text = "Personas a cargo:"
            Label10.Text = gerente.PersonasACargo.ToString()

            Label16.Enabled = False ' "solo operador" no aplica a este empleado
            Label17.Enabled = True  ' "solo gerente" sí aplica

        ElseIf TypeOf EmpleadoSeleccionado Is Operario Then
            Dim operario As Operario = CType(EmpleadoSeleccionado, Operario)

            Label8.Text = "Operario"                     ' Puesto:
            Label4.Text = "Turno:"
            Label9.Text = operario.Turno
            Label5.Text = "Horas Extra:"
            Label10.Text = operario.HorasExtras.ToString()

            Label16.Enabled = True  ' "solo operador" sí aplica
            Label17.Enabled = False ' "solo gerente" no aplica a este empleado
        End If

        TextBox1.Text = EmpleadoSeleccionado.SalarioBase.ToString("0.00")

        ActualizarPagoCalculado()
    End Sub

    Private Sub ActualizarPagoCalculado()
        Label18.Text = ModuloValidaciones.FormatearMoneda(EmpleadoSeleccionado.CalcularPagoMensual())
    End Sub

    ' ---------- Botón Guardar: aplica el nuevo salario ----------

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim nuevoSalario As Decimal
            If Not Decimal.TryParse(TextBox1.Text, nuevoSalario) Then
                Throw New Exception("El salario debe ser un valor numérico.")
            End If

            EmpleadoSeleccionado.SalarioBase = nuevoSalario
            ActualizarPagoCalculado()

            If FormPadre IsNot Nothing Then
                FormPadre.RefrescarListView()
            End If

            MessageBox.Show("Salario actualizado correctamente.", "Éxito",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al actualizar salario",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' ---------- Botón Cancelar: descarta lo escrito y restaura el salario actual ----------

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If EmpleadoSeleccionado IsNot Nothing Then
            TextBox1.Text = EmpleadoSeleccionado.SalarioBase.ToString("0.00")
        End If
    End Sub

    ' ---------- Botón Regresar: cierra la ficha y vuelve a Form1 ----------

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class