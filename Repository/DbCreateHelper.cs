using ioc_di_dip.Context;

namespace ioc_di_dip.Repository
{
    public static class DbCreateHelper
    {
        public static async Task EnsureCreatedDb(IApplicationBuilder serviceScope)
        {
            var services = serviceScope.ApplicationServices.CreateScope().ServiceProvider;

            await EnsureSeedData(services);
        }

        public static async Task EnsureSeedData(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope();

            var env = scope.ServiceProvider.GetRequiredService<IWebHostEnvironment>();

            var context = scope.ServiceProvider.GetRequiredService<ExemploContext>();

            await context.Database.EnsureDeletedAsync();

            await context.Database.EnsureCreatedAsync();
        }

    }
}