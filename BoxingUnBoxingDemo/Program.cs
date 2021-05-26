using System;

namespace BoxingUnBoxingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoBoxingUnboxing_1();
            Console.ReadLine();

        }

        static void DemoBoxingUnboxing_1()
        {
            int miNumero = 20;

            object miObjeto = miNumero; 

            int suma = miNumero + (int)miObjeto;

            //1. Lo que hacemos es explícitamente hacer la conversión a un tipo _string_ que es un valor por referencia,
            //en este método _WriteLine_ en particular lo que se pide es un _object_ que es un valor por referencia.
            //De esta forma evitamos que el compilador haga el _Boxing_  

            Console.WriteLine("El resultado es {0}", miNumero.ToString());
        }
    }
}

