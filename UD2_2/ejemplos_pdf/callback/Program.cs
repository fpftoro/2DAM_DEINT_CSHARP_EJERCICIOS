using System;
using System.Data;



delegate int OperacionCallback(int x, int y);


class Program
{
    static int Sumar(int a, int b) => a + b;

    static int EjecutarOperacion(OperacionCallback op, int x, int y)
    { return op(x, y); }

    static void Main()
    {
        Console.WriteLine("Suma: "+EjecutarOperacion(Sumar,5,3));
    }

}
