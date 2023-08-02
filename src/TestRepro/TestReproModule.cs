using TestRepro.Applications.Worker;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Modularity;

namespace TestRepro;

[DependsOn(typeof(AbpAutofacModule), typeof(AbpBackgroundWorkersModule))]
public class TestReproModule : AbpModule
{
    public override void OnApplicationInitialization(Volo.Abp.ApplicationInitializationContext context)
    {
        base.OnApplicationInitialization(context);
        new PollSignalrConnectionStatusWorker();
        //context.AddBackgroundWorkerAsync<PollSignalrConnectionStatusWorker>();
    }
}
