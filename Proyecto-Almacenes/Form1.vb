Public Class Form1

    ' Lista interna que guarda todos los empleados creados
    Private listaEmpleados As New List(Of Empleado)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarListView()
        ConfigurarAutoCompletado()
        ActualizarResumen()

        Button1.Enabled = False ' Eliminar  x
        Button2.Enabled = False ' Ver Detalles:
    End Sub

    ' ---------- Configuración inicial ----------

    Private Sub ConfigurarListView()
        If ListView1.Columns.Count = 0 Then
            ListView1.View = View.Details
            ListView1.FullRowSelect = True
            ListView1.GridLines = True
            ListView1.Columns.Add("Nombre", 150)
            ListView1.Columns.Add("RFC", 100)
            ListView1.Columns.Add("Departamento", 120)
            ListView1.Columns.Add("Tipo", 80)
            ListView1.Columns.Add("Pago Mensual", 100)
        End If
    End Sub

    Private Sub ConfigurarAutoCompletado()
        Dim deptos As New AutoCompleteStringCollection()
        deptos.AddRange({"Sistemas", "Ventas", "Administración", "Producción"})

        txtdepto.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtdepto.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtdepto.AutoCompleteCustomSource = deptos

        txtdeptoO.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtdeptoO.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtdeptoO.AutoCompleteCustomSource = deptos

        Dim turnos As New AutoCompleteStringCollection()
        turnos.AddRange({"Matutino", "Vespertino", "Nocturno"})

        txtturno.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtturno.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtturno.AutoCompleteCustomSource = turnos
    End Sub

    ' ---------- Resumen de nómina global ----------
    ' Se basa en listaEmpleados (no en Empleado.GetTotal) para que al
    ' eliminar un empleado los totales bajen correctamente.

    Private Sub ActualizarResumen()
        ' Label12 = valor de "Total de Empleados:" (control vacío junto a esa etiqueta)
        Label12.Text = listaEmpleados.Count.ToString()

        ' lblvalornomina = valor de "Total de Nomina Mensual:"
        Dim totalNomina As Decimal = listaEmpleados.Sum(Function(emp) emp.CalcularPagoMensual())
        Label13.Text = ModuloValidaciones.FormatearMoneda(totalNomina)
    End Sub

    ' ---------- Refresco público ----------
    ' Lo invoca Verdetalles después de guardar un cambio de salario,
    ' para que la lista y los totales se actualicen sin cerrar la ficha.

    Public Sub RefrescarListView()
        ListView1.Items.Clear()
        For Each empleado In listaEmpleados
            Dim tipo As String = If(TypeOf empleado Is Gerente, "Gerente", "Operario")
            AgregarAListView(empleado, tipo)
        Next
        ActualizarResumen()
    End Sub

    ' ---------- Alta de Gerente ----------

    Private Sub btnAG_Click(sender As Object, e As EventArgs) Handles btnAG.Click
        Try
            Dim salario As Decimal
            If Not Decimal.TryParse(txtsalario.Text, salario) Then
                Throw New Exception("El salario debe ser un valor numérico.")
            End If

            Dim bono As Decimal
            If Not Decimal.TryParse(txtbono.Text, bono) Then
                Throw New Exception("El porcentaje de bono debe ser un valor numérico.")
            End If

            Dim prscargo As Integer
            If Not Integer.TryParse(txtprscargo.Text, prscargo) Then
                Throw New Exception("Las personas a cargo deben ser un número entero.")
            End If

            Dim nuevoGerente As New Gerente(
                txtnombre.Text,
                txtrfc.Text.ToUpper(),
                salario,
                txtdepto.Text.Trim(),
                bono,
                prscargo)

            listaEmpleados.Add(nuevoGerente)
            AgregarAListView(nuevoGerente, "Gerente")
            ActualizarResumen()
            LimpiarCamposGerente()

            MessageBox.Show("Gerente agregado correctamente.", "Éxito",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al agregar Gerente",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub LimpiarCamposGerente()
        txtnombre.Clear()
        txtrfc.Clear()
        txtsalario.Clear()
        txtdepto.Clear()
        txtbono.Clear()
        txtprscargo.Clear()
        txtnombre.Focus()
    End Sub

    ' ---------- Alta de Operario ----------

    Private Sub btnoperador_Click(sender As Object, e As EventArgs) Handles btnoperador.Click
        Try
            Dim salario As Decimal
            If Not Decimal.TryParse(txtsalarioP.Text, salario) Then
                Throw New Exception("El salario debe ser un valor numérico.")
            End If

            Dim horasExtras As Decimal
            If Not Decimal.TryParse(txthorase.Text, horasExtras) Then
                Throw New Exception("Las horas extras deben ser un valor numérico.")
            End If

            Dim nuevoOperario As New Operario(
                txtnombreO.Text,
                txtrfcO.Text.ToUpper(),
                salario,
                txtdeptoO.Text.Trim(),
                txtturno.Text.Trim(),
                horasExtras)

            listaEmpleados.Add(nuevoOperario)
            AgregarAListView(nuevoOperario, "Operario")
            ActualizarResumen()
            LimpiarCamposOperario()

            MessageBox.Show("Operario agregado correctamente.", "Éxito",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al agregar Operario",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub LimpiarCamposOperario()
        txtnombreO.Clear()
        txtrfcO.Clear()
        txtsalarioP.Clear()
        txtdeptoO.Clear()
        txtturno.Clear()
        txthorase.Clear()
        txtnombreO.Focus()
    End Sub

    ' ---------- ListView: mostrar, seleccionar, ver detalles y eliminar ----------

    Private Sub AgregarAListView(empleado As Empleado, tipo As String)
        Dim item As New ListViewItem(empleado.Nombre)
        item.SubItems.Add(empleado.RFC)
        item.SubItems.Add(empleado.Departamento)
        item.SubItems.Add(tipo)
        item.SubItems.Add(ModuloValidaciones.FormatearMoneda(empleado.CalcularPagoMensual()))
        item.Tag = empleado ' guardamos el objeto completo para recuperarlo después
        ListView1.Items.Add(item)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim haySeleccion As Boolean = ListView1.SelectedItems.Count > 0
        Button1.Enabled = haySeleccion
        Button2.Enabled = haySeleccion
    End Sub

    ' Button2 = "Ver Detalles:" -> abre Verdetalles con el empleado seleccionado
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListView1.SelectedItems.Count = 0 Then
            MessageBox.Show("Selecciona un empleado de la lista primero.", "Aviso",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim empleadoSeleccionado As Empleado = CType(ListView1.SelectedItems(0).Tag, Empleado)

        Dim frmDetalle As New Verdetalles()
        frmDetalle.EmpleadoSeleccionado = empleadoSeleccionado
        frmDetalle.FormPadre = Me
        frmDetalle.Show()
    End Sub

    ' Button1 = "Eliminar  x" -> quita al empleado seleccionado de la lista
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListView1.SelectedItems.Count = 0 Then
            MessageBox.Show("Selecciona un empleado de la lista primero.", "Aviso",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim item As ListViewItem = ListView1.SelectedItems(0)
        Dim empleado As Empleado = CType(item.Tag, Empleado)

        Dim confirmacion As DialogResult = MessageBox.Show(
            $"¿Eliminar a {empleado.Nombre} de la lista?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If confirmacion = DialogResult.Yes Then
            listaEmpleados.Remove(empleado)
            ListView1.Items.Remove(item)
            ActualizarResumen()
            Button1.Enabled = False
            Button2.Enabled = False
        End If
    End Sub

    ' ---------- RFC en mayúsculas mientras se escribe ----------

    Private Sub txtrfc_TextChanged(sender As Object, e As EventArgs) Handles txtrfc.TextChanged
        Dim posicion As Integer = txtrfc.SelectionStart
        txtrfc.Text = txtrfc.Text.ToUpper()
        txtrfc.SelectionStart = posicion
    End Sub

    Private Sub txtrfcO_TextChanged(sender As Object, e As EventArgs) Handles txtrfcO.TextChanged
        Dim posicion As Integer = txtrfcO.SelectionStart
        txtrfcO.Text = txtrfcO.Text.ToUpper()
        txtrfcO.SelectionStart = posicion
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class