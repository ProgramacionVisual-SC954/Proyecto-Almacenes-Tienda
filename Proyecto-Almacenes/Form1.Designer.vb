<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnAG = New Button()
        lblnombre = New Label()
        lblrfc = New Label()
        lblsalario = New Label()
        lbldepto = New Label()
        lblbono = New Label()
        Label2 = New Label()
        nd = New Label()
        lblprscargo = New Label()
        txtnombre = New TextBox()
        txtsalario = New TextBox()
        txtrfc = New TextBox()
        txtdepto = New TextBox()
        txtbono = New TextBox()
        txtprscargo = New TextBox()
        txthorase = New TextBox()
        txtturno = New TextBox()
        txtdeptoO = New TextBox()
        txtrfcO = New TextBox()
        txtsalarioP = New TextBox()
        txtnombreO = New TextBox()
        lblhorasextra = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblturno = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        btnoperador = New Button()
        Label1 = New Label()
        ListView1 = New ListView()
        Button1 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        SuspendLayout()
        ' 
        ' btnAG
        ' 
        btnAG.BackColor = SystemColors.AppWorkspace
        btnAG.Font = New Font("Century", 12F, FontStyle.Bold)
        btnAG.Location = New Point(193, 342)
        btnAG.Name = "btnAG"
        btnAG.Size = New Size(189, 36)
        btnAG.TabIndex = 0
        btnAG.Text = "+ Agregar Gerente"
        btnAG.UseVisualStyleBackColor = False
        ' 
        ' lblnombre
        ' 
        lblnombre.AutoSize = True
        lblnombre.BorderStyle = BorderStyle.Fixed3D
        lblnombre.Font = New Font("Century", 12F, FontStyle.Bold)
        lblnombre.Location = New Point(76, 95)
        lblnombre.Name = "lblnombre"
        lblnombre.Size = New Size(81, 22)
        lblnombre.TabIndex = 1
        lblnombre.Text = "Nombre:"
        ' 
        ' lblrfc
        ' 
        lblrfc.AutoSize = True
        lblrfc.BorderStyle = BorderStyle.Fixed3D
        lblrfc.Font = New Font("Century", 12F, FontStyle.Bold)
        lblrfc.Location = New Point(76, 126)
        lblrfc.Name = "lblrfc"
        lblrfc.Size = New Size(54, 22)
        lblrfc.TabIndex = 2
        lblrfc.Text = "RFC:"
        ' 
        ' lblsalario
        ' 
        lblsalario.AutoSize = True
        lblsalario.BorderStyle = BorderStyle.Fixed3D
        lblsalario.Font = New Font("Century", 12F, FontStyle.Bold)
        lblsalario.Location = New Point(76, 159)
        lblsalario.Name = "lblsalario"
        lblsalario.Size = New Size(94, 22)
        lblsalario.TabIndex = 3
        lblsalario.Text = "Salario B:"
        ' 
        ' lbldepto
        ' 
        lbldepto.AutoSize = True
        lbldepto.BorderStyle = BorderStyle.Fixed3D
        lbldepto.Font = New Font("Century", 12F, FontStyle.Bold)
        lbldepto.Location = New Point(76, 192)
        lbldepto.Name = "lbldepto"
        lbldepto.Size = New Size(64, 22)
        lbldepto.TabIndex = 4
        lbldepto.Text = "Depto:"
        ' 
        ' lblbono
        ' 
        lblbono.AutoSize = True
        lblbono.BorderStyle = BorderStyle.Fixed3D
        lblbono.Font = New Font("Century", 12F, FontStyle.Bold)
        lblbono.Location = New Point(76, 225)
        lblbono.Name = "lblbono"
        lblbono.Size = New Size(63, 22)
        lblbono.TabIndex = 5
        lblbono.Text = " Bono:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century", 12F, FontStyle.Bold)
        Label2.Location = New Point(89, 247)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 6
        ' 
        ' nd
        ' 
        nd.AutoSize = True
        nd.Font = New Font("Impact", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nd.Location = New Point(187, 31)
        nd.Name = "nd"
        nd.Size = New Size(198, 34)
        nd.TabIndex = 7
        nd.Text = "Nuevo Gerente:"
        ' 
        ' lblprscargo
        ' 
        lblprscargo.AutoSize = True
        lblprscargo.BackColor = SystemColors.GrayText
        lblprscargo.BorderStyle = BorderStyle.Fixed3D
        lblprscargo.Font = New Font("Century", 12F, FontStyle.Bold)
        lblprscargo.Location = New Point(76, 259)
        lblprscargo.Name = "lblprscargo"
        lblprscargo.Size = New Size(113, 22)
        lblprscargo.TabIndex = 8
        lblprscargo.Text = "Pers. Cargo:"
        ' 
        ' txtnombre
        ' 
        txtnombre.Location = New Point(193, 96)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(192, 23)
        txtnombre.TabIndex = 9
        ' 
        ' txtsalario
        ' 
        txtsalario.Location = New Point(193, 160)
        txtsalario.Name = "txtsalario"
        txtsalario.Size = New Size(192, 23)
        txtsalario.TabIndex = 10
        ' 
        ' txtrfc
        ' 
        txtrfc.Location = New Point(193, 127)
        txtrfc.Name = "txtrfc"
        txtrfc.Size = New Size(192, 23)
        txtrfc.TabIndex = 11
        ' 
        ' txtdepto
        ' 
        txtdepto.Location = New Point(193, 193)
        txtdepto.Name = "txtdepto"
        txtdepto.Size = New Size(192, 23)
        txtdepto.TabIndex = 12
        ' 
        ' txtbono
        ' 
        txtbono.Location = New Point(193, 228)
        txtbono.Name = "txtbono"
        txtbono.Size = New Size(192, 23)
        txtbono.TabIndex = 13
        ' 
        ' txtprscargo
        ' 
        txtprscargo.Location = New Point(193, 260)
        txtprscargo.Name = "txtprscargo"
        txtprscargo.Size = New Size(192, 23)
        txtprscargo.TabIndex = 14
        ' 
        ' txthorase
        ' 
        txthorase.Location = New Point(556, 260)
        txthorase.Name = "txthorase"
        txthorase.Size = New Size(192, 23)
        txthorase.TabIndex = 29
        ' 
        ' txtturno
        ' 
        txtturno.Location = New Point(556, 226)
        txtturno.Name = "txtturno"
        txtturno.Size = New Size(192, 23)
        txtturno.TabIndex = 28
        ' 
        ' txtdeptoO
        ' 
        txtdeptoO.Location = New Point(556, 192)
        txtdeptoO.Name = "txtdeptoO"
        txtdeptoO.Size = New Size(192, 23)
        txtdeptoO.TabIndex = 27
        ' 
        ' txtrfcO
        ' 
        txtrfcO.Location = New Point(556, 127)
        txtrfcO.Name = "txtrfcO"
        txtrfcO.Size = New Size(192, 23)
        txtrfcO.TabIndex = 26
        ' 
        ' txtsalarioP
        ' 
        txtsalarioP.Location = New Point(556, 160)
        txtsalarioP.Name = "txtsalarioP"
        txtsalarioP.Size = New Size(192, 23)
        txtsalarioP.TabIndex = 25
        ' 
        ' txtnombreO
        ' 
        txtnombreO.Location = New Point(556, 96)
        txtnombreO.Name = "txtnombreO"
        txtnombreO.Size = New Size(192, 23)
        txtnombreO.TabIndex = 24
        ' 
        ' lblhorasextra
        ' 
        lblhorasextra.AutoSize = True
        lblhorasextra.BackColor = SystemColors.GrayText
        lblhorasextra.BorderStyle = BorderStyle.Fixed3D
        lblhorasextra.Font = New Font("Century", 12F, FontStyle.Bold)
        lblhorasextra.Location = New Point(432, 259)
        lblhorasextra.Name = "lblhorasextra"
        lblhorasextra.Size = New Size(118, 22)
        lblhorasextra.TabIndex = 23
        lblhorasextra.Text = "Horas Extra:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Impact", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(550, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(220, 34)
        Label3.TabIndex = 22
        Label3.Text = "Nuevo Operativo:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century", 12F, FontStyle.Bold)
        Label4.Location = New Point(452, 247)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 21
        ' 
        ' lblturno
        ' 
        lblturno.AutoSize = True
        lblturno.BorderStyle = BorderStyle.Fixed3D
        lblturno.Font = New Font("Century", 12F, FontStyle.Bold)
        lblturno.Location = New Point(432, 227)
        lblturno.Name = "lblturno"
        lblturno.Size = New Size(67, 22)
        lblturno.TabIndex = 20
        lblturno.Text = "Turno:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BorderStyle = BorderStyle.Fixed3D
        Label6.Font = New Font("Century", 12F, FontStyle.Bold)
        Label6.Location = New Point(432, 192)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 22)
        Label6.TabIndex = 19
        Label6.Text = "Depto:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.Font = New Font("Century", 12F, FontStyle.Bold)
        Label7.Location = New Point(432, 159)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 22)
        Label7.TabIndex = 18
        Label7.Text = "Salario B:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BorderStyle = BorderStyle.Fixed3D
        Label8.Font = New Font("Century", 12F, FontStyle.Bold)
        Label8.Location = New Point(432, 127)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 22)
        Label8.TabIndex = 17
        Label8.Text = "RFC:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BorderStyle = BorderStyle.Fixed3D
        Label9.Font = New Font("Century", 12F, FontStyle.Bold)
        Label9.Location = New Point(432, 95)
        Label9.Name = "Label9"
        Label9.Size = New Size(81, 22)
        Label9.TabIndex = 16
        Label9.Text = "Nombre:"
        ' 
        ' btnoperador
        ' 
        btnoperador.BackColor = SystemColors.AppWorkspace
        btnoperador.Font = New Font("Century", 12F, FontStyle.Bold)
        btnoperador.Location = New Point(556, 342)
        btnoperador.Name = "btnoperador"
        btnoperador.Size = New Size(189, 36)
        btnoperador.TabIndex = 15
        btnoperador.Text = "+ Agregar Operador"
        btnoperador.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(47, 411)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 34)
        Label1.TabIndex = 31
        Label1.Text = "Listado de Empleados:"
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(57, 460)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(271, 192)
        ListView1.TabIndex = 32
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.AppWorkspace
        Button1.Font = New Font("Century", 12F, FontStyle.Bold)
        Button1.Location = New Point(361, 576)
        Button1.Name = "Button1"
        Button1.Size = New Size(189, 36)
        Button1.TabIndex = 33
        Button1.Text = "Eliminar  x"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.AppWorkspace
        Button2.Font = New Font("Century", 12F, FontStyle.Bold)
        Button2.Location = New Point(361, 493)
        Button2.Name = "Button2"
        Button2.Size = New Size(189, 36)
        Button2.TabIndex = 34
        Button2.Text = "Ver Detalles:"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Impact", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(601, 460)
        Label5.Name = "Label5"
        Label5.Size = New Size(349, 34)
        Label5.TabIndex = 35
        Label5.Text = "Resumen de Nomina Global:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.GrayText
        Label10.BorderStyle = BorderStyle.Fixed3D
        Label10.Font = New Font("Century", 12F, FontStyle.Bold)
        Label10.Location = New Point(613, 507)
        Label10.Name = "Label10"
        Label10.Size = New Size(179, 22)
        Label10.TabIndex = 36
        Label10.Text = "Total de Empleados:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.GrayText
        Label11.BorderStyle = BorderStyle.Fixed3D
        Label11.Font = New Font("Century", 12F, FontStyle.Bold)
        Label11.Location = New Point(613, 562)
        Label11.Name = "Label11"
        Label11.Size = New Size(230, 22)
        Label11.TabIndex = 37
        Label11.Text = "Total de Nomina Mensual:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = SystemColors.GrayText
        Label12.BorderStyle = BorderStyle.Fixed3D
        Label12.Font = New Font("Century", 12F, FontStyle.Bold)
        Label12.Location = New Point(821, 507)
        Label12.Name = "Label12"
        Label12.Size = New Size(71, 22)
        Label12.TabIndex = 38
        Label12.Text = "412554"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = SystemColors.GrayText
        Label13.BorderStyle = BorderStyle.Fixed3D
        Label13.Font = New Font("Century", 12F, FontStyle.Bold)
        Label13.Location = New Point(861, 562)
        Label13.Name = "Label13"
        Label13.Size = New Size(71, 22)
        Label13.TabIndex = 39
        Label13.Text = "412554"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(956, 715)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListView1)
        Controls.Add(Label1)
        Controls.Add(txthorase)
        Controls.Add(txtturno)
        Controls.Add(txtdeptoO)
        Controls.Add(txtrfcO)
        Controls.Add(txtsalarioP)
        Controls.Add(txtnombreO)
        Controls.Add(lblhorasextra)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(lblturno)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(btnoperador)
        Controls.Add(txtprscargo)
        Controls.Add(txtbono)
        Controls.Add(txtdepto)
        Controls.Add(txtrfc)
        Controls.Add(txtsalario)
        Controls.Add(txtnombre)
        Controls.Add(lblprscargo)
        Controls.Add(nd)
        Controls.Add(Label2)
        Controls.Add(lblbono)
        Controls.Add(lbldepto)
        Controls.Add(lblsalario)
        Controls.Add(lblrfc)
        Controls.Add(lblnombre)
        Controls.Add(btnAG)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAG As Button
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblrfc As Label
    Friend WithEvents lblsalario As Label
    Friend WithEvents lbldepto As Label
    Friend WithEvents lblbono As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nd As Label
    Friend WithEvents lblprscargo As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtsalario As TextBox
    Friend WithEvents txtrfc As TextBox
    Friend WithEvents txtdepto As TextBox
    Friend WithEvents txtbono As TextBox
    Friend WithEvents txtprscargo As TextBox
    Friend WithEvents txthorase As TextBox
    Friend WithEvents txtturno As TextBox
    Friend WithEvents txtdeptoO As TextBox
    Friend WithEvents txtrfcO As TextBox
    Friend WithEvents txtsalarioP As TextBox
    Friend WithEvents txtnombreO As TextBox
    Friend WithEvents lblhorasextra As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblturno As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnoperador As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label

End Class
