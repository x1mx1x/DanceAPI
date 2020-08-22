using DanceAPIServices.Services;
using DanceAPIServices.Services.Interfaces;
using Ninject.Modules;

public class NinjectRegistrations : NinjectModule
{
    public override void Load()
    {
        Bind<ICompetitionService>().To<CompetitionService>();
    }
}