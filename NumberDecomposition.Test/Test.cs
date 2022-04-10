﻿using NumberDecomposition.Domain.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace NumberDecomposition.Test
{
    public class Test
    {

        [Fact]
        public void CriarNumero()
        {
            int _numero = 45;
            Number numero = new Number(_numero);

            Assert.True(numero.Value > 0);
        }

        [Fact]
        public void RetonarDivisores()
        {
            int numero = 45;
            Number numeroValido = new Number(numero);

            List<int> DivisoresEsperados = new List<int> { 1, 3, 5, 9, 15, 45 };
            List<int> DivisoresPrimosEsperados = new List<int> { 3, 5 };

            var result = new
            {
                Divisores = new List<int> { 1, 3, 5, 9, 15, 45 },
                DivisoresPrimos = new List<int> { 3, 5 }
            };

            Assert.Equal(DivisoresEsperados, result.Divisores);
            Assert.Equal(DivisoresPrimosEsperados, result.DivisoresPrimos);

        }
    }
}
