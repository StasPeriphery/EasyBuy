using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using EasyBuyShop.Models;
using EasyBuyShop.Interface;

namespace EasyBuyShop
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup( IWebHostEnvironment hostEnv)
        {
            Configuration = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();

        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<ShopDBContent>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                //options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=shopdb;Trusted_Connection=True;MultipleActiveResultSets=true");
            });

            services.AddTransient<IProduct, GetDataFromDB>();
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHsts();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            ShopDBContent shopDBContent;

            using (var scope = app.ApplicationServices.CreateScope())
            {
                shopDBContent = scope.ServiceProvider.GetRequiredService<ShopDBContent>();
                DbObject.InitiallDb(shopDBContent);
            }

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}");
            });
        }
    }
}
