
using System.Collections.Generic;
using System.Linq;
using LojaGamesRetro.Models;

namespace LojaGamesRetro.Services
{
    public class ServicesJogos
    {
        private readonly List<Jogo> jogos = new List<Jogo>
        {
            new Jogo
            {
                Id = 1,
                Nome = "Super Mario World",
                Preco = 149.90m,
                Estoque = 10
            },
            new Jogo
            {
                Id = 2,
                Nome = "Sonic the Hedgehog",
                Preco = 99.90m,
                Estoque = 8
            },
            new Jogo
            {
                Id = 3,
                Nome = "The Legend of Zelda",
                Preco = 179.90m,
                Estoque = 5
            },
            new Jogo
            {
                Id = 4,
                Nome = "Street Fighter II",
                Preco = 119.90m,
                Estoque = 7
            },
            new Jogo
            {
                Id = 5,
                Nome = "Donkey Kong Country",
                Preco = 139.90m,
                Estoque = 6
            },
            new Jogo
            {
                Id = 6,
                Nome = "Pac-Man",
                Preco = 79.90m,
                Estoque = 12
            }
        };

        // Retorna todos os jogos cadastrados
        public List<Jogo> ListarTodos()
        {
            return jogos;
        }

        // Busca um jogo pelo ID
        public Jogo BuscarPorId(int id)
        {
            return jogos.FirstOrDefault(jogo => jogo.Id == id);
        }

        // Busca um jogo pelo nome
        public Jogo BuscarPorNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                return null;

            return jogos.FirstOrDefault(jogo =>
                jogo.Nome.Equals(
                    nome.Trim(),
                    System.StringComparison.OrdinalIgnoreCase));
        }

        // Cadastra um novo jogo
        public bool CadastrarJogo(Jogo novoJogo)
        {
            if (novoJogo == null ||
                string.IsNullOrWhiteSpace(novoJogo.Nome) ||
                novoJogo.Preco < 0 ||
                novoJogo.Estoque < 0)
            {
                return false;
            }

            if (jogos.Any(jogo => jogo.Id == novoJogo.Id))
                return false;

            jogos.Add(novoJogo);
            return true;
        }

        // Atualiza o preço de um jogo
        public bool AtualizarPreco(int id, decimal novoPreco)
        {
            Jogo jogo = BuscarPorId(id);

            if (jogo == null || novoPreco < 0)
                return false;

            jogo.Preco = novoPreco;
            return true;
        }

        // Atualiza o estoque de um jogo
        public bool AtualizarEstoque(int id, int novoEstoque)
        {
            Jogo jogo = BuscarPorId(id);

            if (jogo == null || novoEstoque < 0)
                return false;

            jogo.Estoque = novoEstoque;
            return true;
        }

        // Dá baixa no estoque após uma venda
        public bool BaixarEstoque(int id, int quantidade)
        {
            Jogo jogo = BuscarPorId(id);

            if (jogo == null ||
                quantidade <= 0 ||
                jogo.Estoque < quantidade)
            {
                return false;
            }

            jogo.Estoque -= quantidade;
            return true;
        }

        // Remove um jogo do catálogo
        public bool RemoverJogo(int id)
        {
            Jogo jogo = BuscarPorId(id);

            if (jogo == null)
                return false;

            jogos.Remove(jogo);
            return true;
        }
    }
}
