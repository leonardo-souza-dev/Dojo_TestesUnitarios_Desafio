using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistema.Interfaces;

namespace Sistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        private ICheckoutService _checkoutService;

        public CheckoutController(ICheckoutService usuarioService)
        {
            _checkoutService = usuarioService;
        }

        [HttpGet("email/{email}/senha/{senha}/produto/{produto}/cep/{cep}")]
        public ActionResult<BaseResponse> Get(string email, string senha, int idSku, string cep)
        {
            _checkoutService.FazerCompra(email, senha, idSku, cep);

            return new BaseResponse { Mensagem = "Compra realizada com sucesso!", Dados = new object() };
        }
    }
}
