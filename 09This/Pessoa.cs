using System;

namespace _09This
{
    public class Pessoa
    {
        //Atributo
        private string nome = "Gláucia";


        //Construtor
        public Pessoa(string nome)
        {
            System.Console.WriteLine(nome);
            System.Console.WriteLine(this.nome);
        }
    }
}