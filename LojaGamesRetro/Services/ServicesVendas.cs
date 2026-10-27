
using System;
using System.Collections.Generic;
using System.Linq;

namespace LojaGamesRetro.Services
{
    public class ServicesVendas
    {
        private static readonly List<Venda> vendas = new List<Venda>();
        private static int proximoId = 1;

        public class ItemVendido
        {
            public string Nome { get; set; }
            public decimal PrecoUnitario { get; set; }
            public int Quantidade { get; set; }

            public decimal Subtotal => PrecoUnitario * Quantidade;
        }

        public class Venda
        {
            public int Id { get; set; }
            public DateTime Data { get; set; }
            public List<ItemVendido> Itens { get; set; }

            public decimal Total => Itens.Sum(item => item.Subtotal);

            public string ResumoItens =>
                string.Join(", ", Itens.Select(item =>
                    $"{item.Nome} (x{item.Quantidade})"));
        }

        public bool RegistrarVenda(Dictionary<Models.Jogo, int> pedido)
        {
            if (pedido == null || pedido.Count == 0)
                return false;

            if (pedido.Any(item =>
                item.Key == null || item.Value <= 0))
                return false;

            Venda novaVenda = new Venda
            {
                Id = proximoId++,
                Data = DateTime.Now,
                Itens = pedido.Select(item => new ItemVendido
                {
                    Nome = item.Key.Nome,
                    PrecoUnitario = item.Key.Preco,
                    Quantidade = item.Value
                }).ToList()
            };

            vendas.Add(novaVenda);
            return true;
        }

        public List<Venda> ListarVendas()
        {
            return vendas.ToList();
        }

        public decimal CalcularFaturamento()
        {
            return vendas.Sum(venda => venda.Total);
        }

        public int ContarVendas()
        {
            return vendas.Count;
        }

        public int ContarItensVendidos()
        {
            return vendas.Sum(venda =>
                venda.Itens.Sum(item => item.Quantidade));
        }
    }
}
