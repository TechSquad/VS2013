Module modMaths
    Public Function StrToInteger(ByRef s As String, ByRef i As Integer) As Integer
        Integer.TryParse(s, i)
        Return (i)
    End Function
    Public Function BoolToMySql(bVal As Boolean) As Integer
        Dim retVal As Integer
        If bVal = True Then
            retVal = 1
        Else
            retVal = 0
        End If
        BoolToMySql = retVal
    End Function
End Module
