using Microsoft.Practices.Unity;

namespace MyApp.Infrastructure
{
    public static class ServiceLocator
    {
        private const string PARAM_VIEW = "view";
        private static readonly UnityContainer unityContainer = new UnityContainer();

        public static void Register<I, T>() where T : I
        {
            unityContainer.RegisterType<I, T>(new PerResolveLifetimeManager());
        }

        public static I RetrievePresenter<I, T>(T paramView)
        {
            return unityContainer.Resolve<I>(new ParameterOverride(PARAM_VIEW, paramView));
        }
    }
}