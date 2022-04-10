using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDecomposition.Application.DTOs
{
    public class NumberDTO
    {
        public int value { get; set; }
        public List<int> Dividers { get; set; }
        public List<int> PrimeDivisors { get; set; }

        public string Error { get; set; }

        public NumberDTO(int numero)
        {
            value = numero;
        }

    }
}
