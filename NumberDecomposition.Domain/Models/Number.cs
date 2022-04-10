using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDecomposition.Domain.Models
{
    public class Number
    {
        public int Value { get; }

        public Number(int numero)
        {
            Value = numero;
        }
    }
}
