using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;

namespace UWPStrangeBindingBehavior.ViewModels
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            var serviceLocator = new UnityServiceLocator(ConfigureUnityContainer());
            ServiceLocator.SetLocatorProvider(() => serviceLocator);
        }

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

        private static IUnityContainer ConfigureUnityContainer()
        {
            var unityContainer = new UnityContainer();

            unityContainer.RegisterType<MainViewModel>();

            return unityContainer;
        }
    }
}