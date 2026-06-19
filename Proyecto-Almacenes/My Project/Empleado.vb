Public MustInherit Class Empleado

    Private _nombre As String
    Private _rfc As String
    Private _salarioBase As Decimal
    Private _departamento As String

    Private Shared _totalEmpleados As Integer = 0

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)

            If String.IsNullOrWhiteSpace(value) Then
                Throw New Exception("El nombre no puede estar vacío.")
            End If

            If value.Length > 60 Then
                Throw New Exception("El nombre no puede exceder 60 caracteres.")
            End If

            _nombre = value.Trim()

        End Set
    End Property

    Public Property RFC As String
        Get
            Return _rfc
        End Get
        Set(value As String)

            If Not ModuloValidaciones.ValidarRFC(value) Then
                Throw New Exception("RFC inválido (13 caracteres y en mayúsculas).")
            End If

            _rfc = value

        End Set
    End Property

    Public Property SalarioBase As Decimal
        Get
            Return _salarioBase
        End Get
        Set(value As Decimal)

            If value <= 0 Or value > 500000 Then
                Throw New Exception("El salario debe estar entre 1 y 500,000.")
            End If

            _salarioBase = value

        End Set
    End Property

    Public Property Departamento As String

    Public ReadOnly Property NombreCompleto As String
        Get
            Return $"{Nombre} ({RFC})"
        End Get
    End Property

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

    Public MustOverride Function CalcularPagoMensual() As Decimal

    Public Overridable Function ObtenerFicha() As String

        Return "===== EMPLEADO =====" & vbCrLf &
               $"Nombre: {Nombre}" & vbCrLf &
               $"RFC: {RFC}" & vbCrLf &
               $"Nombre Completo: {NombreCompleto}" & vbCrLf &
               $"Salario Base: {SalarioBase:C}" & vbCrLf &
               $"Departamento: {Departamento}" & vbCrLf

    End Function

    Public Shared Function GetTotal() As Integer
        Return _totalEmpleados
    End Function

End Class