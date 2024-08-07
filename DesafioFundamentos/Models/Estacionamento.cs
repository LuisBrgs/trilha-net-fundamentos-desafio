using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public List<string> veiculos = new List<string>();

        public void DisplayMenu()
       {
            Console.Clear();
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Adicionar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");
            Console.Write("Opção: ");
       }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("\nDigite a placa do veículo:");
            this.veiculos.Add(Console.ReadLine());
            Console.WriteLine("Veículo adicionado com sucesso!");
            Console.ReadLine();
        }
        public void RemoverVeiculo(decimal precoInicial, decimal precoPorHora)
        {
            Console.WriteLine("\nDigite a placa do veículo a ser removido:");
            string placa = Console.ReadLine();
            if (this.veiculos.Contains(placa))
            {
                Console.WriteLine("\nDigite a quantidade de horas que o veículo permaneceu estacionado:");
                decimal horas = 0;
                try
                {
                    horas = Convert.ToDecimal(Console.ReadLine());
                    decimal valorTotal = precoInicial + (precoPorHora * horas);
                    Console.WriteLine($"O valor total a ser pago é de: R$ {valorTotal}");
                    this.veiculos.Remove(placa);
                    Console.WriteLine("Veículo removido com sucesso!");
                }
                catch
                {
                    Console.WriteLine("\nValor inválido, tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("\nEste veículo não está estacionado aqui, verifique se digitou corretamente a placa.");
            }
            Console.ReadLine();
        }

        public void ListarVeiculos()
        {
            if (this.veiculos.Count == 0)
            {
                Console.WriteLine("\nNão há veículos estacionados.");
            }
            else
            {
                Console.WriteLine("\nLista de veículos estacionados:");
                foreach (string veiculo in this.veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            Console.ReadLine();
        }
    }
}