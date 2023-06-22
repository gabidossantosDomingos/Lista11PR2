using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11PR2
{
    internal class Program
    {

        static void ex1()
        {
            

            int[] numeros = new int[100];

            Random gerador = new Random();

            for (int indice = 0; indice < 100; indice++)
            {
                numeros[indice] = gerador.Next(10, 20);
            }

            bool naoAchei = true;
            do
            {
                Console.WriteLine("Digite o número a procurar:");
                int procurar = int.Parse(Console.ReadLine());

                for (int indice = 0; indice < 100; indice++)
                {
                    if (numeros[indice] == procurar)
                        Console.WriteLine("Achei na posição" + indice);
                    naoAchei = false;
                }
            } while (naoAchei);

          
        }
        static void ex2()
        {
            int[] vet;
            int cont = 0, i;

            vet = new int[20000];
            Random rand = new Random();

            for (i = 0; i < 20000; i++)
            {
                vet[i] = rand.Next(1, 20000);
            }
            Console.WriteLine("Digite um numero:");
            int n = int.Parse(Console.ReadLine());

            for (i = 0; i < 20000; i++)
            {
                if (n == vet[i])
                {
                    cont++;
                }
            }
            Console.WriteLine("a quantidade de vezes que aparece o numero " + n + "é " + cont);
        }

        static void ex3()
        {
            int[] vet;
            int[] vet2;
            int i;

            vet = new int[10];
            vet2 = new int[10];
            Random rand = new Random();

            for (i = 0; i < 10; i++)
            {
                vet[i] = rand.Next(1, 10);
            }
            for (i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    vet2[i] = vet[i] / 2;
                }
                else
                {
                    vet2[i] = vet[i] * 3;
                }
            }
            Console.WriteLine("vet1");
            for (i = 0; i < 10; i++)
            {

                Console.WriteLine("posição [{0}] = {1}", i, vet[i]);
            }
            Console.WriteLine("vet2");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("posição [{0}] = {1}", i, vet2[i]);
            }
        }

        static void ex4()
        {
            int[] numero;


            numero = new int[5000];
            Random rand = new Random();

            for (int i = 0; i < 5000; i++)
            {
                numero[i] = rand.Next(1, 5000);
            }
            for (int i = 0; i < 5000; i++)
            {
                if (numero[i] % 2 != 0 && numero[i] % 3 != 0 && numero[i] % 5 != 0)
                {
                    Console.WriteLine(numero[i] + " Nº primo");
                }
            }
        }


        static void Main(string[] args)
        {

            int opcao;

            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("Ex1 - 1");
                Console.WriteLine("Ex2 - 2");
                Console.WriteLine("Ex3 - 3");
                Console.WriteLine("Ex4 - 4");
                Console.WriteLine("sair - 0");
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        ex1();
                        break;
                    case 2:
                        ex2();
                        break;
                    case 3:
                        ex3();
                        break;
                    case 4:
                        ex4();
                        break;

                        
                    default:
                        Console.WriteLine("o numero não é um exercicio valido");
                        break;
                }





            } while (opcao != 0);

            Console.WriteLine("Digite 0 para sair");

        }
    }
}
