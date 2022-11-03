using System;

namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Boas vindas a melhor calculadora em desenvolvimento do mundo!");
            Console.WriteLine("");
            Console.WriteLine("Qual função deseja utilizar?");
            Console.WriteLine("");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Potência");
            Console.WriteLine("6 - Porcentagem");
            Console.WriteLine("7 - Equação de 2º grau");
            Console.WriteLine("8 - Sair");

            Console.WriteLine("-------------------------");
            Console.WriteLine("Selecione uma das opções: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Potencia(); break;
                case 6: Porcentagem(); break;
                case 7: Equacao(); break;
                case 8: Sair(); break;
                default: Menu(); break;
            }

        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Função Soma");
            Console.WriteLine("");
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;

            Console.WriteLine($"O resultado da soma é: {resultado}");

            /* Outros exemplos de realizar a soma:
            Console.WriteLine("O resultado da some é " + resultado);
            Console.WriteLine($"O resultado da soma é {v1 + v2}");
            Console.WriteLine("O resultado da soma é " + (v1 + v2));*/
            Console.WriteLine("Pressione 'Enter' para voltar ao Menu");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Função Subtração");
            Console.WriteLine("");
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");

            /* Outros exemplos de realizar a subtração:
            Console.WriteLine("O resultado da some é " + resultado);
            Console.WriteLine($"O resultado da soma é {v1 - v2}");
            Console.WriteLine("O resultado da soma é " + (v1 - v2));*/
            Console.WriteLine("Pressione 'Enter' para voltar ao Menu");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Função Divisão");
            Console.WriteLine("");
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");

            /* Outros exemplos de realizar a divisão:
            Console.WriteLine("O resultado da divisão é " + resultado);
            Console.WriteLine($"O resultado da divisão é {v1 / v2}");
            Console.WriteLine("O resultado da divisão é " + (v1 / v2)); */
            Console.WriteLine("Pressione 'Enter' para voltar ao Menu");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Função Multiplicação");
            Console.WriteLine("");
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");


            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");

            /* Outros exemplos de realizar a multiplicação: 
            Console.WriteLine("O resultado da multiplicação é " + resultado);
            Console.WriteLine($"O resultado da multiplicação é {v1 * v2}");
            Console.WriteLine("O resultado da multiplicação é " + (v1 * v2)); */
            Console.WriteLine("Pressione 'Enter' para voltar ao Menu");
            Console.ReadKey();
            Menu();
        }
        public static void Potencia()
        {
            Console.Clear();

            Console.WriteLine("Função Potência");
            Console.WriteLine("");

            Console.WriteLine("Primeiro valor: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Potência: ");
            int v2 = int.Parse(Console.ReadLine());

            /* Console.WriteLine("");

            double resultado = Math.Pow(v1, v2);
            Console.WriteLine($"O resultado da Potência é {resultado}"); */

            int aux = 1;

            Console.WriteLine("");
            for (int i = 1; i <= v2; i++)
            {
                aux *= v1;
            }

            Console.WriteLine($"O resultado da Potência é {aux}");

            Console.WriteLine("");
            Console.WriteLine("Pressione 'Enter' para voltar ao Menu");
            Console.ReadKey();
            Menu();
        }
        static void Porcentagem()
        {
            Console.Clear();

            Console.WriteLine("Função Porcentagem");
            Console.WriteLine("");
            Console.WriteLine("Valor total: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Valor da porcentagem: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            const short VALOR = 100;
            float resultado = (v1 * v2 / VALOR);
            // float resultado = ((v2 / VALOR) * v1); 

            Console.WriteLine($"O resultado da Porcentagem é {resultado}");

            Console.WriteLine("Pressione 'Enter' para voltar ao Menu");
            Console.ReadKey();
            Menu();
        }
        static void Equacao()
        {
            Console.Clear();

            Console.WriteLine("Função Equação de 2º grau");
            Console.WriteLine("");
            Console.WriteLine("Digite o valor de A: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2) - 4 * a * c;

            Console.WriteLine("O valor de Delta é: " + delta);

            double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
            double x2 = (-b - Math.Sqrt(delta)) / 2 * a;

            if (delta > 0)
            {
                Console.WriteLine("Existem 2 raízes reais diferentes. x1= " + x1 + " e x2= " + x2);
            }
            else if (delta == 0)
            {
                Console.WriteLine("Existem 2 raízes reais iguais. x1= " + x1 + " e x2= " + x2);
            }
            else
            {
                Console.WriteLine("Não existem raízes reais.");
            }

            Console.WriteLine("Pressione 'Enter' para voltar ao Menu");
            Console.ReadKey();
            Menu();
        }
        static void Sair()
        {
            Console.Clear();

            Console.WriteLine("Obrigado por utilizar o nosso sistema. Até logo!");

        }
    }
}