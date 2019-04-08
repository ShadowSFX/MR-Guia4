Public Class CuentaBancaria
    Private numeroCuenta As Integer
    Private balance As Double

    Public Sub New(numeroCuenta, balance)
        Me.numeroCuenta = numeroCuenta
        Me.balance = balance
    End Sub

    Public Sub Depositar(monto As Double)
        balance = balance + monto
    End Sub

    Public Sub Retirar(monto As Double)
        balance = balance - monto
    End Sub

    Public Sub MostrarBalance()
        Console.WriteLine("Balance: " & balance)
        Console.ReadLine()
    End Sub

End Class
