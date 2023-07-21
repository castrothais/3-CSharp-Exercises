using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, seja bem-vindo. Para verificar se um número é triangular, informe-o: ");
            string inputValue = Console.ReadLine();

            int validValue = checkValidations(inputValue);

            bool isTriangle = false;
            for (int i = 1; (i * (i + 1) * (i + 2)) <= validValue; i++)
            {
                if (i * (i + 1) * (i + 2) == validValue)
                {
                    isTriangle = true;
                }
            }
            if (isTriangle)
            {
                Console.WriteLine($"O número “{validValue}” é triangular.");
            }
            else
            {
                Console.WriteLine($"“O número “{validValue}” NÃO é triangular");
            }
        }


        static int checkValidations(string inputvalue)
        {
            int valueIntPositive;

            while (string.IsNullOrWhiteSpace(inputvalue) || !int.TryParse(inputvalue, out int intValue) || intValue <= 0)
            {
                if (string.IsNullOrWhiteSpace(inputvalue))
                {
                    Console.WriteLine("Entrada inválida. Por favor, preencher corretamente o campo. Não pode conter espaço vazio ou nulo.");
                }
                else if (!int.TryParse(inputvalue, out int _)) // o "_" é utilizado para ignorar o valor. Ou seja, para não ser armazenado em uma variável.
                {
                    Console.WriteLine("Entrada inválida. Por favor, preencher apenas com número inteiro.");
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, preencher apenas com número positivo.");
                }
                inputvalue = Console.ReadLine();
            }
            valueIntPositive = int.Parse(inputvalue);
            return valueIntPositive;

        }
    }
}

