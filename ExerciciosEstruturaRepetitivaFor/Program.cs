using System.Globalization;
using System.Xml.Serialization;

namespace ExerciciosEstruturaRepetitivaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            //Exercicio5();
            //Exercicio6();
            Exercicio7();
        }

        static void Exercicio1()
        {
            int x;

            Console.Write("Digite um valor de 1 a 1000: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Exercicio2()
        {
            int n, x;
            int contIn = 0;
            int contOut = 0;

            Console.Write("Quantos valores serao digitados: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    contIn++;
                }
                else
                {
                    contOut++;
                }
            }

            Console.WriteLine($"{contIn} In");
            Console.WriteLine($"{contOut} Out");
        }

        static void Exercicio3()
        {
            int n;
            double mediaPonderada = 0;
            string relatorio = "";
            
            Console.Write("Quantos casos de teste serao digitados: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nDigite o {i + 1}º caso:");
                string[] valorDigitado = Console.ReadLine().Split(' ');                           

                double valor1 = double.Parse(valorDigitado[0], CultureInfo.InvariantCulture);
                double valor2 = double.Parse(valorDigitado[1], CultureInfo.InvariantCulture);
                double valor3 = double.Parse(valorDigitado[2], CultureInfo.InvariantCulture);

                mediaPonderada = (valor1 * 2 + valor2 * 3 + valor3 * 5) / (2 + 3 + 5);

                relatorio += "\n" + mediaPonderada.ToString("F1", CultureInfo.InvariantCulture);
            }

            Console.WriteLine($"\nMédia Ponderada: {relatorio}");
        }

        static void Exercicio4()
        {
            int n;
            double resultado = 0;
            string relatorio = "";

            Console.Write("Quantos casos serao digitados: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nDigite o {i + 1}º caso:");
                string[] numeroDigitado = Console.ReadLine().Split(' ');

                double valor1 = double.Parse(numeroDigitado[0], CultureInfo.InvariantCulture);
                double valor2 = double.Parse(numeroDigitado[1], CultureInfo.InvariantCulture);

                if (valor2 == 0)
                {
                    relatorio += "divisao impossivel\n";
                }
                else
                {
                    resultado = (valor1 / valor2);
                    relatorio += resultado.ToString("F1", CultureInfo.InvariantCulture) + "\n";
                }
            }

            Console.WriteLine($"\nDivisoes: \n{relatorio}");
        }

        static void Exercicio5()
        {
            int n;
            int fatorial = 1;

            Console.Write("Digite um valor: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine($"\nFatorial: {fatorial}");
        }

        static void Exercicio6()
        {
            int n;

            Console.Write("Digite um numero inteiro: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDivisores: ");

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i); ;
                }
            }
        }

        static void Exercicio7()
        {
            int n;

            Console.Write("Digite um numero inteiro positivo: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int quadrado = i * i;
                int cubo = i * i * i;
                Console.WriteLine(i + " " + quadrado + " " + cubo);
            }
        }
    }
}
