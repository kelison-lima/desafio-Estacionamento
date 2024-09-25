using Microsoft.Win32.SafeHandles;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
    
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
        
            string placa="";
            Console.WriteLine($"Digite a placa{placa} do veículo para estacionar:");
            placa = Console.ReadLine();
            veiculos.Add($"{placa}");
        }

        public void RemoverVeiculo()
        {
            string placa = "";
            Console.WriteLine($"Digite a placa {placa} do veículo para remover:");    
            placa = Console.ReadLine();
            

             int horas = 0;
                Console.WriteLine($"Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());
            
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                
                decimal valorTotal = 0;
                valorTotal = (precoInicial + precoPorHora) * horas;
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                int contador=0;
                foreach(string carros in veiculos){
                    Console.WriteLine($"{contador} - {carros}");
                    contador++;
                }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
