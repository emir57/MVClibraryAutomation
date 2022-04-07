using libraryMVC_.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace libraryMVC.Data.DataSeed
{
    public class DataSeed
    {
        public DataSeed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<AppDbContext>();
        }
    }
}