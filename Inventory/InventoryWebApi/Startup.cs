using BusinessLogics.Bal;
using BusinessLogics.TransactionBal;
using DalAccess.IDal;
using DalAccess.PgsqlDal;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace InventoryWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<IItemCategory, ItemCategoryDal>();
            services.AddSingleton<ItemCategoryBal, ItemCategoryBal>();

            services.AddSingleton<IItem, ItemDal>();
            services.AddSingleton<ItemBal, ItemBal>();

            services.AddSingleton<IItemCostDetails, ItemCostDetailsDal>();
            services.AddSingleton<ItemCostDetailsBal, ItemCostDetailsBal>();

            services.AddSingleton<ILogin, LoginDal>();
            services.AddSingleton<LoginBal, LoginBal>();

            services.AddSingleton<ItemStockTransaction, ItemStockTransaction>();
            


        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
