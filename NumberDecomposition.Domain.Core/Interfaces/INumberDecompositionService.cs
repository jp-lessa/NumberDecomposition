using NumberDecomposition.Application.DTOs;
using NumberDecomposition.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDecomposition.Domain.Core.Interfaces
{
    public interface INumberDecompositionService
    {
        NumberDTO RetornarDivisores(Number number);

    }
}
