using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistema.Interfaces;

namespace Sistema.Services
{
    public class CheckoutService : ICheckoutService
    {
        ICarrinhoRepository _carrinhoRepository;
        IFreteRepository _freteRepository;
        IAutenticacaoService _autenticacaoService;
        IPagamentoService _pagamentoService;
        IMensageriaService _mensageriaService;
        ILoggerService _loggerService;

        public CheckoutService(
            ICarrinhoRepository carrinhoRepository,
            IFreteRepository freteRepository,
            IAutenticacaoService autenticacaoService,
            IPagamentoService pagamentoService,
            IMensageriaService mensageriaService,
            ILoggerService loggerService)
        {
            _carrinhoRepository = carrinhoRepository;
            _freteRepository = freteRepository;
            _autenticacaoService = autenticacaoService;
            _pagamentoService = pagamentoService;
            _mensageriaService = mensageriaService;
            _loggerService = loggerService;
        }

        public void FazerCompra(string email, string senha, int idSku, string cep)
        {
            var carrinho = _carrinhoRepository.Obter();
            carrinho.Adicionar(idSku);

            var frete = _freteRepository.Calcular(cep);

            carrinho.Atualizar(frete);

            if (!_autenticacaoService.Autenticar(email, senha))
                return;

            if (!_pagamentoService.Pagar(carrinho.Compra.Valor, email))
            {
                _loggerService.Log("pagamento não validado");
                return;
            }

            _mensageriaService.Enviar(new { Compra = carrinho.Compra, Usuario = email });
        }
    }
}
