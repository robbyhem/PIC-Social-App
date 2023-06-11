namespace PIC_SocialApp.Api.Registrar
{
    public interface IWebApplicationBuilderRegistrar : IRegistrar
    {
        void RigisterServices(WebApplicationBuilder builder);
    }
}
