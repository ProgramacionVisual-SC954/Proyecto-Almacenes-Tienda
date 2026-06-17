Module ModuloValidaciones

    ' Valida si el RFC es válido
    Public Function EsRFCValido(rfc As String) As Boolean
        If String.IsNullOrEmpty(rfc) OrElse rfc.Length <> 13 Then
            Return False
        End If
        Return rfc.ToUpper() = rfc
    End Function

    ' Valida si el nombre es válido
    Public Function EsNombreValido(nombre As String) As Boolean
        If String.IsNullOrEmpty(nombre) OrElse nombre.Length > 60 Then
            Return False
        End If
        For Each c As Char In nombre
            If Char.IsDigit(c) Then
                Return False
            End If
        Next
        Return True
    End Function


    Public Function EsSalarioValido(salario As Decimal) As Boolean
        Return salario > 0 AndAlso salario <= 500000
    End Function


    Public Function EsTurnoValido(turno As String) As Boolean
        Dim turnosValidos As String() = {"Matutino", "Vespertino", "Nocturno"}
        Return turnosValidos.Contains(turno)
    End Function


    Public Function EsBonoValido(pct As Integer) As Boolean
        Return pct >= 5 AndAlso pct <= 40
    End Function

    Public Function FormatearMoneda(valor As Decimal) As String
        Return valor.ToString("C2")
    End Function

End Module
