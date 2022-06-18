using DryIoc.Microsoft.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Prism.DryIoc;
using Prism.Ioc;
using Shiny;
using System;
using DryIoc;


namespace PrismShinyIntegrationIssue.IoC
{
    public class Startup : ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services, IPlatform platform)
        {
            services.UseJobs(true);
            services.UseFirebaseMessaging<DefaultPushDelegate>();
        }

        public override IServiceProvider CreateServiceProvider(IServiceCollection services)
        {
            ContainerLocator.SetContainerExtension(() => new DryIocContainerExtension());
            IContainer container = ContainerLocator.Container.GetContainer();
            DryIocAdapter.Populate(container, services);
            return container.GetServiceProvider();
        }
    }
}
