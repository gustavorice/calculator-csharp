using System;
using System.IO.Pipelines;
using System.Numerics;
using System.Runtime.Intrinsics;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {


            Menu();

        }


        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Selecione a operação desejada:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione uma opção: ");


            short res = short.Parse(Console.ReadLine());


            switch (res)
            {
                case 1: Soma(); break;
                case 2: Substracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }


        }


        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("O resultado da soma é " + (num1 + num2));

        }


        static void Substracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 - v2;
            Console.WriteLine("");
            Console.WriteLine("O resultado da subtração é: " + result);
            Console.ReadKey();


        }


        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 / v2;

            Console.WriteLine("O resultado da divisão é: " + result);

            Console.ReadKey();

        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro número: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;

            Console.WriteLine("");

            Console.WriteLine("O Resultado da multiplicação é: " + result);

            Console.ReadKey();

        }

    }



}