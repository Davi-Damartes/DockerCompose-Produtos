using DockerProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerProdutos.Data
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Produto[ ] Produtos =
                [
                    new Produto(new Guid("7268705e-2444-4be5-b68e-f126c6c20178"), "Televisão", 1299.00M),
                    new Produto(new Guid("7268705e-2444-4be5-b68e-f126c6c20178"), "Computador", 899.00M)
                ];

            modelBuilder.Entity<Produto>().HasData(Produtos);


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Produto> Produtos { get; set; }
    }
}
