namespace DockerProdutos.Models
{
    public class Produto
    {
        public Produto(Guid id, string nome, decimal valor)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
        }
         public Produto(string nome, decimal valor)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Valor = valor;
        }

        public Guid Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public decimal Valor { get; set; }
    }
}
