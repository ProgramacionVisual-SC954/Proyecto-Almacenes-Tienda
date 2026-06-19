Public MustInherit Class Empleado

    Private _nombre As String
    Private _rfc As String
    Private _salarioBase As Decimal
    Private _departamento As String

    Private Shared _totalEmpleados As Integer = 0

    ' Propiedad Nombre
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)

            If Not ModuloValidaciones.EsNombreValido(value) Then
                Throw New Exception("Nombre inválido. No debe estar vacío, exceder 60 caracteres o contener números.")
            End If

            _nombre = value.Trim()

        End Set
    End Property

    ' Propiedad RFC
    Public Property RFC As String
        Get
            Return _rfc
        End Get
        Set(value As String)

            If Not ModuloValidaciones.EsRFCValido(value) Then
                Throw New Exception("RFC inválido. Debe tener 13 caracteres y estar en mayúsculas.")
            End If

            _rfc = value.Trim()

        End Set
    End Property

    ' Propiedad SalarioBase
    Public Property SalarioBase As Decimal
        Get
            Return _salarioBase
        End Get
        Set(value As Decimal)

            If Not ModuloValidaciones.EsSalarioValido(value) Then
                Throw New Exception("Salario inválido. Debe ser mayor a 0 y menor o igual a 500,000.")
            End If

            _salarioBase = value

        End Set
    End Property

    ' Propiedad Departamento
    Public Property Departamento As String
        Get
            Return _departamento
        End Get
        Set(value As String)

            Dim departamentosValidos As String() =
                {"Sistemas", "Ventas", "Administración", "Producción"}

            If String.IsNullOrWhiteSpace(value) OrElse Not departamentosValidos.Contains(value) Then
                Throw New Exception("Departamento inválido.")
            End If

            _departamento = value.Trim()

        End Set
    End Property

    ' Propiedad de solo lectura
    Public ReadOnly Property NombreCompleto As String
        Get
            Return $"{Nombre} ({RFC})"
        End Get
    End Property

    ' Constructor
    Public Sub New(nombre As String,
                   rfc As String,
                   salarioBase As Decimal,
                   departamento As String)

        Me.Nombre = nombre
        Me.RFC = rfc
        Me.SalarioBase = salarioBase
        Me.Departamento = departamento

        _totalEmpleados += 1

    End Sub

    ' Método abstracto
    Public MustOverride Function CalcularPagoMensual() As Decimal

    ' Método virtual
    Public Overridable Function ObtenerFicha() As String

        Return "===== EMPLEADO =====" & vbCrLf &
               $"Nombre: {Nombre}" & vbCrLf &
               $"RFC: {RFC}" & vbCrLf &
               $"Nombre Completo: {NombreCompleto}" & vbCrLf &
               $"Salario Base: {ModuloValidaciones.FormatearMoneda(SalarioBase)}" & vbCrLf &
               $"Departamento: {Departamento}" & vbCrLf

    End Function

    ' Método Shared
    Public Shared Function GetTotal() As Integer
        Return _totalEmpleados
    End Function

End Class