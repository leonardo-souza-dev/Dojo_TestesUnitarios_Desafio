using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sistema.Interfaces
{
    public interface IAutenticacaoService
    {
        bool Autenticar(string email, string senha);
    }
}
