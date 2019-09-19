using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistema.Interfaces;

namespace Sistema.Services
{
    public class PagamentoService : IPagamentoService
    {
        public bool Pagar(decimal valor, string email)
        {
            return !email.EndsWith("@gmail.com");
        }
    }
}
