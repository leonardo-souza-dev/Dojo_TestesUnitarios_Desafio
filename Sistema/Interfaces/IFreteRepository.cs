using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistema.Domain;

namespace Sistema.Interfaces
{
    public interface IFreteRepository
    {
        Frete Calcular(string cep);
    }
}
