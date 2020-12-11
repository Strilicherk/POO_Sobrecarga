using System;

namespace POO_Polimorfismo_Sobrecarga.Classes
{
    public class Funcionário
    {
        private int myVar;
        public int MyProperty
        {
            get {return myVar; }
            set { myVar = value; }
        }

        public string [] lista = {"Paulo", "Tsuka", "Priscila", "Fernanda"};
            
        public void Mostrar(){
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public void Mostrar(int indice){
            Console.WriteLine( "Buscas por índice : " + lista [ indice ] ) ;
        }

        public void Mostrar(string busca){
            foreach (var item in lista)
            {
                if(item == busca){
                    Console.WriteLine("Resultado da busca : " + item);
                }
                
            }
        }
    }
}