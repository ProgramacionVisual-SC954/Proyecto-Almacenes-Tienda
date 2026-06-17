Public Class Gerente
    Inherits Empleado

    Private _porcentajeBono As Decimal
    Private _personasACargo As Integer

    Public Property PorcentajeBono As Decimal
        Get
            Return _porcentajeBono
        End Get
        Set(value As Decimal)

            If value < 5 Or value > 40 Then
                Throw New Exception("El bono debe estar entre 5 y 40%.")
            End If

            _porcentajeBono = value

        End Set
    End Property

    Public Property PersonasACargo As Integer
        Get
            Return _personasACargo
        End Get
        Set(value As Integer)

            If value < 1 Or value > 50 Then
                Throw New Exception("Personas a cargo deben ser entre 1 y 50.")
            End If

            _personasACargo = value

        End Set
    End Property

    Public Sub New(nombre As String,
                   rfc As String,
                   salarioBase As Decimal,
                   departamento As String,
                   porcentajeBono As Decimal,
                   personasACargo As Integer)

        MyBase.New(nombre, rfc, salarioBase, departamento)

        Me.PorcentajeBono = porcentajeBono
        Me.PersonasACargo = personasACargo

    End Sub

    Public Overrides Function CalcularPagoMensual() As Decimal

        Return SalarioBase + (SalarioBase * PorcentajeBono / 100)

    End Function

    Public Overrides Function ObtenerFicha() As String

        Return MyBase.ObtenerFicha() &
               $"Porcentaje Bono: {PorcentajeBono}%" & vbCrLf &
               $"Personas a Cargo: {PersonasACargo}" & vbCrLf &
               $"Pago Mensual: {CalcularPagoMensual():C}" & vbCrLf &
               "====================="

    End Function

End Class