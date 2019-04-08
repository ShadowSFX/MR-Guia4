Public Class Calculadora

    Public Sub Sumar(a As Double, b As Double)
        Console.WriteLine(a + b)
    End Sub

    Public Sub Restar(a As Double, b As Double)
        Console.WriteLine(a - b)
    End Sub

    Public Sub Multiplicar(a As Double, b As Double)
        Console.WriteLine(a * b)
    End Sub

    Public Sub Dividir(a As Double, b As Double)
        Console.WriteLine(a / b)
    End Sub

    Public Sub Todas(a As Double, b As Double)
        Console.Write("La suma de esos números es: ")
        Sumar(a, b)
        Console.Write("La resta de esos números es: ")
        Restar(a, b)
        Console.Write("La multiplicacion de esos números es: ")
        Multiplicar(a, b)
        Console.Write("La division de esos números es: ")
        Dividir(a, b)
    End Sub

End Class
