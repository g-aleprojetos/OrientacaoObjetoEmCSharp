﻿using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancias objeto da Classe Aluno
            Aluno a = new Aluno();
            a.nome = "Alexandre";
            a.nota1 = 8;
            a.nota2 = 10;
            a.mensagem();
        }
    }
}
