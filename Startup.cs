using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City.Service;
using City.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using City.Domain.Repositories.Abstract;
using City.Domain.Repositories.EntityFramework;

namespace City
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //���������� ����� ������������ ����� ����� config
            Configuration.Bind("Project", new Config());

            services.AddTransient<ICardRepository, EFCardRepository>();
            services.AddTransient<IContractorRepository, EFContractorRepository>();
            services.AddTransient<IStatusRepository, EFStatusRepository>();
            services.AddTransient<ITypeCardRepository, EFTypeCardRepository>();
            services.AddTransient<IRoleRepository, EFRoleRepository>();
            services.AddTransient<IUserRepository, EFUserRepository>();
            services.AddTransient<DataManager>();

            //����������� ��������� ���� ������
            services.AddDbContext<AppDBContext>(x => x.UseSqlServer(Config.ConnectionString));

            //��������� ������� ��� ������������ � ������������� (MVC)
            services.AddControllersWithViews()
               //���������� ������������� � asp.net core 3.0
               .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
