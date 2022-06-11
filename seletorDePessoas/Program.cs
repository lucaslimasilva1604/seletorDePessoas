using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seletorDePessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char escolha;

            int homens = 0;
            int mulheres = 0;

            do
            {
                Console.WriteLine("==========================");
                Console.WriteLine("    SELETOR DE PESSOAS    ");
                Console.WriteLine("==========================");

                Console.Write("Qual o Sexo? [M/F] ");
                char sexo = char.Parse(Console.ReadLine());
                Console.Write("Qual a idade? ");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual a cor do Cabelo?");
                Console.WriteLine("---------------------");
                Console.WriteLine("[1] Preto");
                Console.WriteLine("[2] Castanho");
                Console.WriteLine("[3] Loiro");
                Console.WriteLine("[4] Ruivo");

                int corCabelo = int.Parse(Console.ReadLine());

                if (sexo == 'M' && idade > 18 && corCabelo == 2)
                {
                    homens++;
                }
                if (sexo == 'F' && idade >= 25 && idade <= 30 && corCabelo == 3)
                {
                    mulheres++;
                }

                Console.Write("Quer continuar? [S/N] ");
                escolha = char.Parse(Console.ReadLine());

                Console.Clear();

            } while (escolha == 'S');

            Console.WriteLine("------------------------------------");
            Console.WriteLine(" RESULTADO FINAL");
            Console.WriteLine("------------------------------------");

            Console.WriteLine($"Total de homens com mais de 18 e cabelos castanhos {homens}");
            Console.WriteLine($"Total de mulheres entre 25 e 30 e cabelos loiros {mulheres}");
            Console.ReadKey();
        }
    }
}
