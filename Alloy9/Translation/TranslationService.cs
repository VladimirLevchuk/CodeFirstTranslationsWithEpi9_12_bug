using Creuna.EPiCodeFirstTranslations;
using EPiServer.ServiceLocation;

namespace Alloy9.Translation
{
    [ServiceConfiguration(typeof(ITranslationService), Lifecycle = ServiceInstanceScope.Singleton)]
    public class TranslationService : TranslationServiceBase<Translations>
    {
    }
}