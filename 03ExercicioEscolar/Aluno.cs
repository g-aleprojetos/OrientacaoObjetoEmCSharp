using System;

namespace _03ExercicioEscolar
{
    public class Aluno
    {
       //Atributo
        public string nome;
        public double nota1, nota2;

        //Métodos
        //Média
        public double media()
        {
            return (nota1 + nota2)/2;
        }
        
        //Situação
        public string situação(double media)
        {
            return media >= 7 ? "aprovado" : "reprovado"; 
        }
        //mensagem
        public void mensagem()
        {
            //Obter média
            double obterMedia = media();

            //Obter a situação
            string obterSituacao = situação(obterMedia);

            //mensagem
            System.Console.WriteLine($"{nome} está {obterSituacao} com média {obterMedia}");
        }
    }
}