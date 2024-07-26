using DockerProdutos.Data;
using Microsoft.EntityFrameworkCore;

namespace DockerProdutos.Extensions
{
    public static class ProdutoExtensions
    {
        public static void ProdutoContextDb(this IServiceCollection services)
        {
            services.AddDbContext<ProdutoContext>(options =>
            {
                options.UseSqlServer("DATA source=db");

            });
        }
    }
}
