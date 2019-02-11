using Azure.DependencyInjection.Bindings;
using Microsoft.Azure.WebJobs.Host.Config;

namespace Azure.DependencyInjection.Configurations
{
    internal class InjectConfiguration : IExtensionConfigProvider
    {
        public readonly InjectBindingProvider _injectBindingProvider;

        public InjectConfiguration(InjectBindingProvider injectBindingProvider) =>
            _injectBindingProvider = injectBindingProvider;

        public void Initialize(ExtensionConfigContext context) => context
            .AddBindingRule<InjectAttribute>()
            .Bind(_injectBindingProvider);
    }
}