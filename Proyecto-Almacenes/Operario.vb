Public Class Operario
    Inherits Empleado

    Private _turno As String
    Private _horasExtras As Decimal

    Public Property Turno As String
        Get
            Return _turno
        End Get
        Set(value As String)
            If Not ModuloValidaciones.EsTurnoValido(value) Then
                Throw New Exception("El turno debe ser 'Matutino', 'Vespertino' o 'Nocturno'.")
            End If
            _turno = value
        End Set
    End Property

    Public Property HorasExtras As Decimal
        Get
            Return _horasExtras
        End Get
        Set(value As Decimal)
            If value < 0 Or value > 80 Then
                Throw New Exception("Las horas extras deben estar entre 0 y 80 horas al mes.")
            End If
            _horasExtras = value
        End Set
    End Property

    Public Sub New(nombre As String,
                   rfc As String,
                   salarioBase As Decimal,
                   departamento As String,
                   turno As String,
                   horasExtras As Decimal)
        MyBase.New(nombre, rfc, salarioBase, departamento)
        Me.Turno = turno
        Me.HorasExtras = horasExtras
    End Sub

    Public Overrides Function CalcularPagoMensual() As Decimal
        Return SalarioBase + (HorasExtras * (SalarioBase / 160) * 1.5D)
    End Function

    Public Overrides Function ObtenerFicha() As String
        Dim ficha As String = MyBase.ObtenerFicha()
        ficha &= $"Turno: {Turno}" & vbCrLf &
                 $"Horas Extras: {HorasExtras}" & vbCrLf &
                 $"Pago Mensual: {ModuloValidaciones.FormatearMoneda(CalcularPagoMensual())}" & vbCrLf
        Return ficha
    End Function

End Class