using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistema.Interfaces;

namespace Sistema.Repositories
{
    public class AutenticacaoService : IAutenticacaoService
    {
        public bool Autenticar(string email, string senha)
        {
            return true;
        }
    }
}
