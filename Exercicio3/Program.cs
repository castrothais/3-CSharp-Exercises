using System;
using System.Collections.Generic;

namespace Exercicio3
{
    class Program
    {
        static int priorityPwNumber = 0;
        static int defaultPwNumber = 0;
        static List<string> priorityPasswords = new List<string>();
        static List<string> defaultPasswords = new List<string>();

        static string PriorityPassword()
        {
            priorityPwNumber++;
            string newPassword = "P" + priorityPwNumber.ToString().PadLeft(3, '0');
            priorityPasswords.Add(newPassword);
            return priorityPasswords[priorityPasswords.Count - 1];
        }

        static string DefaultPassword()
        {
            defaultPwNumber++;
            string newPassword = "C" + defaultPwNumber.ToString().PadLeft(3, '0');
            defaultPasswords.Add(newPassword);
            return defaultPasswords[defaultPasswords.Count - 1];
        }

        static void NextCustomer()
        {
            if (priorityPasswords.Count > 0)
            {
                Console.WriteLine("\nPróximo cliente: " + priorityPasswords[0] + "\n");
                priorityPasswords.RemoveAt(0);
            }
            else if (defaultPasswords.Count > 0)
            {
                Console.WriteLine("\nPróximo cliente: " + defaultPasswords[0] + "\n");
                defaultPasswords.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("\nNão há clientes na fila\n");
            }
        }

        static void HandleOption(string option)
        {
            switch (option)
            {
                case "1":
                    Console.WriteLine("\nSenha Preferencial criada: " + PriorityPassword() + "\n");
                    Menu();
                    InputOption();
                    break;
                case "2":
                    Console.WriteLine("\nSenha Comum criada: " + DefaultPassword() + "\n");
                    Menu();
                    InputOption();
                    break;
                case "3":
                    NextCustomer();
                    Menu();
                    InputOption();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nOpção inválida!\n");
                    Menu();
                    InputOption();
                    break;
            }
        }

        static void Menu()
        {
            Console.WriteLine("Olá, seja bem-vindo ao Banco BTG Ada! Por favor, informe sua opção: ");
            Console.WriteLine("1 - Emitir Senha Preferencial");
            Console.WriteLine("2 - Emitir Senha Comum");
            Console.WriteLine("3 - Chamar Próxima Senha");
            Console.WriteLine("4 - Sair");
        }

        static void InputOption()
        {
            Console.Write("Escolha uma opção: ");
            string option = Console.ReadLine();
            HandleOption(option);
        }
        static void Main()
        {
            Menu();
            InputOption();
        }
    }
}
