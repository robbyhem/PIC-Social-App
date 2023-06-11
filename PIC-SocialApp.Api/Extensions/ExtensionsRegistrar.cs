using PIC_SocialApp.Api.Registrar;

namespace PIC_SocialApp.Api.Extensions
{
    public static class ExtensionsRegistrar
    {
        public static void RegisterServices(this WebApplicationBuilder builder, Type scanningType)
        {
            var registrar = GetRegistrar<IWebApplicationBuilderRegistrar>(scanningType);

            foreach (var reg in registrar)
            {
                reg.RigisterServices(builder);
            }
        }

        public static void RegisterPipelineComponents(this WebApplication app, Type scanningType)
        {
            var registrar = GetRegistrar<IWebApplicationRegistrar>(scanningType);
            
            foreach (var reg in registrar)
            {
                reg.RegisterPipelineComponents(app);
            }
        }

        private static IEnumerable<T> GetRegistrar<T>(Type scanningType) where T : IRegistrar
        {
            return scanningType.Assembly.GetTypes()
                .Where(t => t.IsAssignableTo(typeof(T)) && !t.IsAbstract && !t.IsInterface)
                .Select(Activator.CreateInstance)
                .Cast<T>();
        }
    }
}
