namespace LojaGamesRetro.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
}