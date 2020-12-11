using System;
using POO_Polimorfismo_Sobrecarga.Classes;
namespace POO_Polimorfismo_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionário fun = new Funcionário(); 
            fun.Mostrar();
            fun.Mostrar("Paulo");
            fun.Mostrar(2);

            Console.Beep(900, 5000);
        }
    }
}
