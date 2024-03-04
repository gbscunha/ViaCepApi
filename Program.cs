using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaCepApi;

namespace ViaCepApp
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("Digite o CEP para consulta: ");
            string cep = Console.ReadLine();

            var viaCepClient = new Class1();
            string result = await viaCepClient.ConsultarCepAsync(cep);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
