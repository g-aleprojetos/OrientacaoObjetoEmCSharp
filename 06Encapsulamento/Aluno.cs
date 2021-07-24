using System;


namespace _06Encapsulamento
{
    public class Aluno
    {
        //Atributos
        private double nota1, nota2;
        
        
        //média
        private double media()
        {
            return (nota1 + nota2) / 2;
        }

        //Mensagem
        public void mensagem()
        {
            Console.Write("Informe a primeira nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a segunda nota: " );
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A média é {media()}." );
        }

    }
}