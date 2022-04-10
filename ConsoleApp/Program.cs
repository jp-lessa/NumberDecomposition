
namespace ConsoleApp
{
    using Microsoft.Extensions.DependencyInjection;
    using NumberDecomposition.Application.DTOs;
    using NumberDecomposition.Domain.Core.Interfaces;
    using NumberDecomposition.Domain.Models;
    using NumberDecomposition.Infrastructure.IOC;
    using System;
    class Program
    {
        private static INumberDecompositionService _serviceDecompsition;

        static void Main(string[] args)
        {

            var serviceCollection = new ServiceCollection();
            var serviceProvider = NativeInjection.GetProvider(serviceCollection);

            _serviceDecompsition = serviceProvider.GetService<INumberDecompositionService>();

            try
            {

                int numero = 0;
                string valorDigitado;
                bool parse;

                do
                {
                    Console.Clear();
                    if (numero < 0)
                    {
                        Console.WriteLine("Informe um número maior que zero!");
                    }
                    Console.WriteLine("Informe um número inteiro: ");
                    valorDigitado = Console.ReadLine();
                    parse = int.TryParse(valorDigitado, out numero);


                } while (!parse || numero <= 0);

                Number number = new Number(numero);

                NumberDTO res = _serviceDecompsition.RetornarDivisores(number);

                Console.WriteLine(res.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
