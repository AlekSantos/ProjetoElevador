using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Models
{
    internal class Elevador{
        public int andarAtual;
        public int totalDeAndares;
        public int capacidadeElevador;
        public int quantidadeDePessoas;

        public void Inicializar()
        {
        
            Console.WriteLine("Digite a capacidade do elevador");
            capacidadeElevador = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de andares do predio");
            totalDeAndares = int.Parse(Console.ReadLine());

        }
        public void Entrar()
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
