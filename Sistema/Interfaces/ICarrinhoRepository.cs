using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistema.Domain;

namespace Sistema
{
    public interface ICarrinhoRepository
    {
        Carrinho Obter();
    }
}
