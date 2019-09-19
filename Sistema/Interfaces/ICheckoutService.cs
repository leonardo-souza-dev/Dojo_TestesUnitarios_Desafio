using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sistema.Interfaces
{
    public interface ICheckoutService
    {
        void FazerCompra(string email, string senha, int idSku, string cep);
    }
}
