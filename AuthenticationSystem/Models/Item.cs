namespace AuthenticationSystem.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string? Descricao { get; set; }
        public string? LinkImg { get; set; }
    }
}
