using NumberDecomposition.Application.DTOs;
using NumberDecomposition.Domain.Core.Interfaces;
using NumberDecomposition.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDecomposition.Domain.Services.Services
{
   public  class NumberDecompositionService : INumberDecompositionService
    {
        public NumberDTO RetornarDivisores(Number number)
        {
            NumberDTO numberDTO = new NumberDTO();

            try
            {
                if (number.Value <= 0)
                {
                    throw new Exception("Número inválido! Informe um número maior que zero.");
                }

                numberDTO.Dividers = AcharDivisores(number.Value);
                numberDTO.PrimeDivisors = AcharDivisoresPrimos(numberDTO.Dividers);

            }
            catch (Exception ex)
            {
                numberDTO.Error = ex.Message;
            }

            return numberDTO;
        }


        private List<int> AcharDivisores(int numero)
        {
            List<int> divisores = new List<int>();
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores.Add(i);
                }
            }

            return divisores;
        }

        private List<int> AcharDivisoresPrimos(List<int> divisores)
        {
            List<int> primos = new List<int>();

            foreach (var item in divisores)
            {
                int i, quantDivisores = 0;

                for (i = 1; i <= item; i++)
                {
                    if (item % i == 0)
                    {
                        quantDivisores++;
                    }
                }

                if (quantDivisores == 2)
                {
                    primos.Add(item);
                }
            }
            return primos;
        }
    }
}

