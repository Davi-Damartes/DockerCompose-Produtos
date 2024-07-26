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
                options.UseSqlServer("");
                //docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=senhaProduto01" -e "MSSQL_PID=Express" -p 1200:1200 --name SqlServer-Docker -d mcr.microsoft.com/mssql/server:2019-latest 

            });
        }
    }
}
