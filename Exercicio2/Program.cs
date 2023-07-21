using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Digite o valor de N1: ");
            int validValue1 = checkValidationsEntries(Console.ReadLine());

            Console.WriteLine("Olá! Digite o valor de N2: ");
            int validValue2 = checkValidationsEntries(Console.ReadLine());

            int resultMultiplicacion = 0;

            int multiplier = (validValue2 < 0) ? -1 : 1;

            for (int i = 0; i < Math.Abs(validValue2); i++)
            {
                resultMultiplicacion += validValue1 * multiplier;
            }

            Console.WriteLine($"O resultado da multiplicação é: {resultMultiplicacion}");

            int resultDivision = 0;

            int divisor = (validValue2 < 0) ? -1 : 1;
            int dividend = Math.Abs(validValue1);

            while (dividend >= Math.Abs(validValue2))
            {
                dividend -= Math.Abs(validValue2);
                resultDivision++;
            }

            int mult = (validValue1 < 0 && validValue2 > 0) || (validValue1 > 0 && validValue2 < 0) ? -1 : 1;
            if (dividend == 0)
            {
                Console.WriteLine($"O resultado da divisão é: {resultDivision * mult}");
            }
            else
            {
                Console.WriteLine("A divisão não é exata");
            }


        }

        static int checkValidationsEntries(string inputvalue)
        {
            int valueIntPositive;

            while (string.IsNullOrWhiteSpace(inputvalue) || !int.TryParse(inputvalue, out int intValue))
            {
                if (string.IsNullOrWhiteSpace(inputvalue))
                {
                    Console.WriteLine("Entrada inválida. Por favor, preencher corretamente o campo. Não pode conter espaço vazio ou nulo.");
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, preencher apenas com número inteiro.");
                }

                inputvalue = Console.ReadLine();
            }
            valueIntPositive = int.Parse(inputvalue);
            return valueIntPositive;

        }

    }
}
