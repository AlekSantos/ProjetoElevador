using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Models
{
    internal class Elevador{
        //declaraçao de variaveis
        public int andarAtual; 
        public int totalDeAndares;
        public int capacidadeElevador;
        public int quantidadeDePessoas;
        
        //declaraçao de metodo que vai iniciar 
        public void Inicializar()
        {
            //inicia os valores da capacidadeElevador e totalDeAndares pedindo ao usuario que digite eles
            Console.WriteLine("Digite a capacidade do elevador");
            capacidadeElevador = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de andares do predio");
            totalDeAndares = int.Parse(Console.ReadLine());
            //inicia andarAtual e quantidadeDePessoas como zero(0).
            andarAtual = 0;
            quantidadeDePessoas = 0;

        }
        public void Entrar()
            //metodo que faz uma pessoa entrar no elevador e retorna uma mensagem se foi sucesso ou não
        {
            if (quantidadeDePessoas < capacidadeElevador)
            {
                quantidadeDePessoas= quantidadeDePessoas +1;
                Console.WriteLine("Existem " +quantidadeDePessoas + " pessoas no elevador");

            }
            else
            {
                Console.WriteLine("Existem " + quantidadeDePessoas + " pessoas no elevador,limite esgotado");
            }

        }
        public void Sair()
        //metodo que faz uma pessoa sair do elevador e retorna uma mensagem se foi sucesso ou não
        {
            if (quantidadeDePessoas > 0)
            {
                quantidadeDePessoas = quantidadeDePessoas - 1;
                Console.WriteLine("Existem " + quantidadeDePessoas + " pessoas no elevador");

            }
            else
            {
                Console.WriteLine("Não tem ninguem no elevador ");
            }
        }
        public void Subir()
        //metodo que faz o elevador subir um andar e retorna uma mensagem se foi sucesso ou não
        {
            if (andarAtual < totalDeAndares)
            {
                andarAtual = andarAtual + 1;
                Console.WriteLine("Voce esta no " + andarAtual + " andar");
            }
            else
            {
                Console.WriteLine("Voce esta no ultimo andar");
            }
        }
        public void Descer()
        //metodo que faz o elevador descer um andar e retorna uma mensagem se foi sucesso ou não
        {
            if (andarAtual > 0)
            {
                andarAtual = andarAtual - 1;
                Console.WriteLine("Voce esta no " + andarAtual + " andar");

            }
            else
            {
                Console.WriteLine("Voce esta no Terreo");
            }
        }


    }
}
