' ***********************************************************************************************************************************
' * ClassRoundingFunctions created by Roger Whitfield on 11/11/2014                                                                 *
' * This class includes functions round prices to hit specific price points                                                         *
' *                                                                                                                                 *
' * This class is ready to be compiled as a DLL file to be used in any project                                                      *
' * Dim classSql As New ClassMySQL_Basic                                                                                            *
' * Dim MyTable As New DataTable                                                                                                    *
' *                                                                                                                                 *
' * Simple error handling is included in the class so this class will throw a MessageBox with error information                     *
' *                                                                                                                                 *
' * Exposes the following public functions/Subs                                                                                     *
' * Public Sub roundit()                                                                                                         *
' * You must set:-                                                                                                                  *
' *                lv_number = number without vat                                                                                   *
' *                nearest = 0.5, 1 or any whole number                                                                             *
' *                vatRate = 0.2 for 20%                                                                                            *
' *                deductor = the amount to be deducted from the final price -0.1 = ?.99                                            *
' * You will get:-                                                                                                                  *
' *                resultLessVat = to 4 decimal places                                                                              *
' *                resultPlusVat = to 2 decimal places                                                                              *
' *                                                                                                                                 *
' * Uses the follwing Private functions/subs                                                                                        *
' * Private Function roundup()                                                                                                      *
' * Private Function fn_plusvat()                                                                                                   *
' * Private Function fn_lessvat()                                                                                                   *
' ***********************************************************************************************************************************
Public Class classRoundingFunctions
    Private _lv_number As Double        'Less Vat Number
    Private _pv_number As Double        'Plus Vat Number
    Private _significance As Double     'can be 0.5 nearest 50p, 1 nearest £1 or any whole number to take you to the nearest £
    Private _vatRate As Double          '0.2 = 20%
    Private _resultLessVat As Double    ' to 4 decimal places
    Private _resultPlusVat As Double    'to 2 decimal places
    Private _deductor As Double         ' if you want it to the nearest £0.99 significance = 1 and deductor =0.01, nearest .49 sig=.5 deductor =0.01
    Public WriteOnly Property lv_number() As Double 'Less Vat Number
        Set(ByVal value As Double)
            _lv_number = value
        End Set
    End Property
    Public WriteOnly Property nearest() As Double
        Set(ByVal value As Double)
            _significance = value
        End Set
    End Property
    Public WriteOnly Property vatRate() As Double
        Set(ByVal value As Double)
            _vatRate = value
        End Set
    End Property
    Public WriteOnly Property deductor() As Double 'Less Vat Number
        Set(ByVal value As Double)
            _deductor = value
        End Set
    End Property
    Public ReadOnly Property resultLessVat() As Double
        Get
            Return _resultLessVat
        End Get
    End Property
    Public ReadOnly Property resultPlusVat() As Double
        Get
            Return _resultPlusVat
        End Get
    End Property
    Private Function roundup()
        ' if number and significance is numeric (1 by default) - divide number by significance, times by significance and round up
        roundup = (Math.Ceiling(_pv_number / _significance)) * _significance
    End Function
    Public Sub roundit()  ' rounding functions
        _pv_number = fn_plusvat()
        _resultPlusVat = (roundup()) - _deductor
        _resultLessVat = fn_lessvat()
        vatRate = FormatNumber(_resultPlusVat, 2)
        _resultLessVat = FormatNumber(_resultLessVat, 4)
    End Sub
    Private Function fn_plusvat()    ' Add VAT
        fn_plusvat = _lv_number * (_vatRate + 1)    'if vat is 20% then it is 0.2 + 1 = 1.2
    End Function
    Private Function fn_lessvat()   ' Remove VAT
        fn_lessvat = _resultPlusVat / (_vatRate + 1)
    End Function
End Class
