using System;

namespace avaliação_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5]; ;
            double[] nota = new double[5]; ;
            double porcentagem = 0, soma = 0, soma2=0, porcentagem2 =0, media =0;

            for (int i = 0; i < 5; i ++)
            {
                Console.WriteLine("digite o nome do aluno:");
                    nome[i] = Console.ReadLine();
                Console.WriteLine("digite a nota do aluno");
                    nota[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                if (nota[i] >= 5)
                {
                    soma = soma + 1;
                    porcentagem = (soma * 100) / 5;
                    Console.WriteLine(nome[i] + "\n" + nota[i] + "\n" + "aluno aprovado." + "\n");
                }
                else
                {
                    soma2 = soma2 + 1;
                    porcentagem2 = (soma2 * 100) / 5;
                    Console.WriteLine(nome[i] + "\n" + nota[i] + "\n" + "aluno reprovado." + "\n" );
                }
                media = media + nota[i] / 5;
            }
            Console.WriteLine("media da turma: " + media);
            Console.WriteLine(porcentagem + "% de aprovados");
            Console.WriteLine(porcentagem2 + "% de reprovados");
        }
    }
}
