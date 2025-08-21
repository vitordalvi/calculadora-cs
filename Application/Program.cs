using calculadora_cs.Services;

namespace calculadora_cs.Application
{
    class Program
    {
        public static void Main(string[] args)
        {
            Methods calc = new Methods();

            bool status = true;

            while (status)
            {
                Console.WriteLine("CALCULADORA | SELECIONE UMA OPÇÃO!" +
                "\n(1) - Adição\n(2) - Subtração\n(3) - Multiplicação\n(4) - Divisão");

                Console.Write("\nDigite a sua opção: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int op))
                {
                    Console.Write("\nOpção inválida.\nEscolha uma das opções (1 - 2 - 3 - 4): ");
                    Console.ReadLine();
                    continue;
                }

                double n1;
                double n2;
                double res;

                switch (op)
                {
                    case 1:
                        Console.Write("\nDigite o primeiro número: ");
                        if (!double.TryParse(Console.ReadLine(), out n1))
                        {
                            Console.Write("\nPrimeiro número inválido.");
                            Console.Write("\nInsira um número válido: ");
                            Console.ReadLine();
                            continue;
                        }

                        Console.Write("Digite o segundo número: ");
                        if (!double.TryParse(Console.ReadLine(), out n2))
                        {
                            Console.WriteLine("\nSegundo número inválido.");
                            Console.Write("\nInsira um número válido: ");
                            Console.ReadLine();
                            continue;
                        }

                        res = calc.Sum(n1, n2);

                        Console.WriteLine("\nO resultado da soma é: " + res);
                        status = false;
                        break;

                    case 2:
                        Console.Write("\nDigite o primeiro número: ");
                        if (!double.TryParse(Console.ReadLine(), out n1))
                        {
                            Console.WriteLine("\nPrimeiro número inválido.");
                            Console.Write("\nInsira um número válido: ");
                            Console.ReadLine();
                            continue;
                        }

                        Console.Write("Digite o segundo número: ");
                        if (!double.TryParse(Console.ReadLine(), out n2))
                        {
                            Console.WriteLine("\nSegundo número inválido.");
                            Console.Write("\nInsira um número válido: ");
                            Console.ReadLine();
                            continue;
                        }

                        res = calc.Subtration(n1, n2);

                        Console.WriteLine("\nO resultado da subtração é: " + res);
                        status = false;
                        break;

                    case 3:
                        Console.Write("\nDigite o primeiro número: ");
                        if (!double.TryParse(Console.ReadLine(), out n1))
                        {
                            Console.WriteLine("\nPrimeiro número inválido.");
                            Console.Write("\nInsira um número válido: ");
                            Console.ReadLine();
                            continue;
                        }

                        Console.Write("Digite o segundo número: ");
                        if (!double.TryParse(Console.ReadLine(), out n2))
                        {
                            Console.WriteLine("\nSegundo número inválido.");
                            Console.Write("\nInsira um número válido: ");
                            Console.ReadLine();
                            continue;
                        }

                        res = calc.Multiply(n1, n2);

                        Console.WriteLine("\nO resultado da multiplicação é: " + res);
                        status = false;
                        break;

                    case 4:
                        Console.Write("\nDigite o primeiro número: ");
                        if (!double.TryParse(Console.ReadLine(), out n1))
                        {
                            Console.WriteLine("\nPrimeiro número inválido.");
                            Console.Write("\nInsira um número válido: ");
                            Console.ReadLine();
                            continue;
                        }

                        Console.Write("Digite o segundo número: ");
                        if (!double.TryParse(Console.ReadLine(), out n2))
                        {
                            Console.WriteLine("\nSegundo número inválido.");
                            Console.Write("\nInsira um número válido: ");
                            Console.ReadLine();
                            continue;
                        }

                        res = calc.Divide(n1, n2);

                        Console.WriteLine("\nO resultado da divisão é: " + res);
                        status = false;
                        break;

                    default: Console.WriteLine("\nOpção inválida.\n");
                        break;
                }
            }
            
        }
    }
}