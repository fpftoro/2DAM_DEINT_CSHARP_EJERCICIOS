using System;


delegate int Operacion(int x,int y);

class Program
{

    // son en realidad métodos de la clase Program
    // C# es puro objeto y no existen funciones definidas independientes
    // como en C,Python o Javascript.
    // estas funciones están definidas con el método simplificado
    // la definición no simplificada sería
    //  static int Sumar(int a, int b) {
    //   return a+b;
    // }
    // la flecha no indica que sea una función lambda
    // en realidad es una simplificación.

    static int Sumar(int a, int b) => a + b;
    static int Restar(int a, int b) => a - b;


    static void Main()
    {

        Operacion op = Sumar;
        Console.WriteLine("Suma: " + op(5, 3));

        //op = Restar;

        // aquí hacemos multicasting
        op += Restar;
        Console.WriteLine("resta: " + op(5, 3));

        // se ejecutan en el orden que se han añadido

        foreach (Operacion metodo in op.GetInvocationList())
        {
            Console.WriteLine(metodo(5, 3));
        }
    }
}
