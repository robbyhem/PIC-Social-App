using Microsoft.EntityFrameworkCore;
using PIC_SocialApp.Infrastructure;

namespace PIC_SocialApp.Api.Registrar
{
    public class DbRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RigisterServices(WebApplicationBuilder builder)
        {
            var cs = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(cs));
        }
    }
}
