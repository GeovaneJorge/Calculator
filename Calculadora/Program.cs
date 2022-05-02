using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("Geovane Corp");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Informe a opção desejada ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Selecione uma opção ou digite 5 para sair: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Metodo Soma -->");
            Console.WriteLine("Primeiro valor : ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor : ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("O resultado é " + (v1 + v2));
            Console.ReadKey();
            Menu();

        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Metodo Subtração -->");
            Console.WriteLine("Primeiro valor : ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor : ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("O resultado é " + (v1-v2));
            Console.ReadKey();
            Menu();

        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Metodo Divisão -->");
            Console.WriteLine("Primeiro valor : ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor : ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("O resultado é " + (v1 / v2));
            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Metodo Multiplicação -->");
            Console.WriteLine("Primeiro valor : ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor : ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("O resultado é " + (v1 * v2));
            Console.ReadKey();
            Menu();

        }

    }
}
