using System;
using ProjetoElevador.Models;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean continuar = true;
            Console.WriteLine("Bem vindo ao Elevador");
            Elevador elevadornovo = new Elevador();
            elevadornovo.Inicializar();
            while (continuar != false)
            {
               
                Console.WriteLine(@"Escolha uma opção:
                                      1 - Entrar no elevador
                                      2 - Sair do elavador
                                      3 - Subir um andar
                                      4 - Descer um andar
                                      5 - Sair
                          ");
                string escolhar = Console.ReadLine();
                Console.Clear();

                switch (escolhar)
                {
                    case "1":
                        elevadornovo.Entrar();  
                        break;
                    case "2":
                        elevadornovo.Sair();
                        break;
                    case "3":
                        elevadornovo.Subir();
                        break;
                    case "4":
                        elevadornovo.Descer();
                        break;
                    case "5":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("escolha invalida");
                        break;

                }


            }
        }
    }
}
