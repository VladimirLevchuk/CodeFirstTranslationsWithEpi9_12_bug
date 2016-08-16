using Alloy9.Translation;
using Creuna.EPiCodeFirstTranslations;
using Creuna.EPiCodeFirstTranslations.KeyBuilder;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace Alloy9.App_Start
{
    [InitializableModule]
    [ModuleDependency(typeof(ServiceContainerInitialization))]
    public class EPiCodeFirstTranslationConfigurationModule : IConfigurableModule
    {
        public virtual void Initialize(InitializationEngine context)
        { }

        public virtual void Uninitialize(InitializationEngine context)
        { }

        public virtual void Preload(string[] parameters)
        { }

        public virtual void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Container.Configure(x => x.AddRegistry(new EPiCodeFirstTranslationsRegistry<Translations>()));

            var translatableEnums = new EnumRegistry();

            // add your translatable enums here
            // translatableEnums.Add<Gender>();
            // translatableEnums.Add<Enums2.Gender>("Gender 2");

            context.Container.Configure(x => x.For<IEnumRegistry>().Singleton().Use(translatableEnums));

            context.Container.Configure(x => x.AddRegistry(new EPiCodeFirstTranslationServiceRegistry<TranslationService, Translations>()));
        }
    }
}
