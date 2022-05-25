using System;
using ProjetoElevador.Models;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean continuar = true; //declara uma variavel continuar com valor true
            Console.WriteLine("Bem vindo ao Elevador"); //Mensagem de inicio
            Elevador elevadornovo = new Elevador(); //inicia o objeto elevador
            elevadornovo.Inicializar(); //Inicia os valores do objeto elevadornovo criado
            while (continuar != false) //criei um loop que enquanto continuar for true,continua a execução do que ta dentro do while.
            {
               
                Console.WriteLine(@"Escolha uma opção:
                                      1 - Entrar no elevador
                                      2 - Sair do elavador
                                      3 - Subir um andar
                                      4 - Descer um andar
                                      5 - Sair
                          "); //Escrevemos esse texto na tela mostrando as opçoes
                string escolhar = Console.ReadLine(); //pegamos esse valor que foi digitado no console pelo usuario
                Console.Clear(); //limpa o console do usuario

                switch (escolhar) // pegamos o valor que foi digitado e fazemos o que a pessoa quis quando escolheu a opçao
                {
                    case "1":
                        elevadornovo.Entrar();  //entra uma nova pessoa no elevador
                        break;
                    case "2":
                        elevadornovo.Sair(); //sai uma pessoa do elevador
                        break;
                    case "3":
                        elevadornovo.Subir(); //sobe um andar com o elevador
                        break;
                    case "4":
                        elevadornovo.Descer(); //desce um andar com o elevador
                        break;
                    case "5":
                        continuar = false; //transforma continuar em false, encerrando assim a condiçao do while
                        break;

                    default:
                        Console.WriteLine("escolha invalida");// se a pessoa escolheu uma opçao nao listada aparece esse mensagem
                        break;

                }


            }
        }
    }
}
