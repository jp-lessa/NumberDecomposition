using System.Collections.Generic;

namespace NumberDecomposition.Application.DTOs
{
    public class NumberDTO
    {
        public int Value { get; set; }
        public List<int> Dividers { get; set; }
        public List<int> PrimeDivisors { get; set; }

        public string Error { get; set; }
        public NumberDTO(int numero)
        {
            Value = numero;
        }
        public NumberDTO()
        {
                
        }

        public override string ToString()
        {
            return string.Format("Decomposição do Número {0}: \n" +
                                 "Divisores: {1} \n" +
                                 "Divisores Primos: {2} \n" +
                                "", Value, string.Join(", ", Dividers), string.Join(",", PrimeDivisors));
        }
    }
}
