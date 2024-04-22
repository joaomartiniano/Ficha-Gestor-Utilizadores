using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorUtilizadores
{
    internal class Program
    {
        // Escrever código aqui: definir struct 

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Title = "Gestor de Utilizadores";

            // Completar código aqui: declarar dicionário utilizadores
            // Dictionary<______, ______> utilizadores = new Dictionary<______, ______>();

            // Escrever código aqui: inserir utilizadores no dicionário

            string comando;

            do
            {
                Console.WriteLine("Gestor de Utilizadores\n");
                Console.WriteLine("Comandos disponíveis:");
                Console.WriteLine("1: Mostrar lista de utilizadores");
                Console.WriteLine("2: Apagar utilizador");
                Console.WriteLine("3: Apagar todos os utilizadores");
                Console.WriteLine("4: Sair");

                Console.Write("\n> ");
                comando = Console.ReadLine();

                switch (comando)
                {
                    case "1":
                        Console.WriteLine();

                        // Escrever código aqui: percorrer dicionário de utilizadores e mostrar os dados de cada utilizador

                        //foreach (KeyValuePair<______, ______> u in ______)
                        //{
                        //  Console.WriteLine($"ID: {u.Key}  Username: {u.Value.Username}\nPassword: {u.Value.Password}  Email: {u.Value.Email}  Telefone: {u.Value.Telefone}\n");
                        //}

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("(pressione qualquer tecla para voltar ao menu)");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;

                    case "2":
                        int id = -1;

                        Console.Write("ID do utilizador a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out id) == true)
                        {
                            // Verificar se existe algum utilizador com o id introduzido
                            //if (utilizadores.______(______))
                            //{
                            //    Console.ForegroundColor = ConsoleColor.Green;
                            //    Console.WriteLine("O utilizador foi removido com sucesso.\n");
                            //    Console.ForegroundColor = ConsoleColor.White;
                            //}
                            //else
                            //{
                            //    Console.ForegroundColor = ConsoleColor.Red;
                            //    Console.WriteLine("Não foi encontrado o utilizador com o id especificado.\n");
                            //    Console.ForegroundColor = ConsoleColor.White;
                            //}
                        }

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("(pressione qualquer tecla para voltar ao menu)");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;

                    case "3":
                        string confirmacao = string.Empty;

                        Console.WriteLine("Confirma que deseja apagar todos os utilizadores?");
                        Console.Write("Escreva \"sim\" para confirmar: ");
                        confirmacao = Console.ReadLine();

                        if (confirmacao == "sim")
                        {
                            //utilizadores.______();
                        }
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;
                }

                Console.Clear();

            } while (1 == 1);
        }
    }
}
