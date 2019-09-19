using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sistema.Domain
{
    public class Carrinho
    {
        public Compra Compra { get; } = new Compra();
        public List<ItemDoCarrinho> Itens = new List<ItemDoCarrinho>();

        public void Adicionar(int idSku)
        {
            Itens.Add(new ItemDoCarrinho { IdSku = idSku, Quantidade = 1 });
        }

        public void Atualizar(Frete frete)
        {

        }
    }
}
