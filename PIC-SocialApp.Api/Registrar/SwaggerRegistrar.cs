using PIC_SocialApp.Api.Options;

namespace PIC_SocialApp.Api.Registrar
{
    public class SwaggerRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RigisterServices(WebApplicationBuilder builder)
        {
            builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
            builder.Services.AddSwaggerGen();
        }
    }
}
