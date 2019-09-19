using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sistema.Interfaces
{
    public interface IPagamentoService
    {
        bool Pagar(decimal valor, string email);
    }
}
