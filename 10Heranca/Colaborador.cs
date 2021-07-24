using System;

namespace _10Heranca
{
    public class Colaborador : Pessoa
    {
        //Atributos
        private double salario;

        //Construtor
        public Colaborador(string nome, int idade, double salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;

            mensagemPessoa();
            mensagemColaborador();
        }

        //Método
        private void mensagemColaborador()
        {
            System.Console.WriteLine("Salário: " + salario);
        }
    }
}