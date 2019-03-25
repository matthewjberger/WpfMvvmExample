using CommonServiceLocator;

namespace WpfMvvmExample.ViewModel
{
    using GalaSoft.MvvmLight.Ioc;

    public class ViewModelLocator
    {
        public ApplicationViewModel ApplicationViewModel => GetInstance<ApplicationViewModel>();
        public HomeScreenViewModel HomeScreenViewModel => GetInstance<HomeScreenViewModel>();
        public OtherScreenViewModel OtherScreenViewModel => GetInstance<OtherScreenViewModel>();

        public ViewModelLocator()
        {
            // Register the default service locator
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            // Register all view models
            RegisterType<ApplicationViewModel>();
            RegisterType<HomeScreenViewModel>();
            RegisterType<OtherScreenViewModel>();
        }

        public static void Cleanup()
        {
            UnregisterType<ApplicationViewModel>();
            UnregisterType<HomeScreenViewModel>();
            UnregisterType<OtherScreenViewModel>();
        }

        public static T GetInstance<T>() where T : class
        {
            return SimpleIoc.Default.GetInstance<T>();
        }

        public static void RegisterType<T>() where T : class
        {
            SimpleIoc.Default.Register<T>();
        }

        public static void UnregisterType<T>() where T : class
        {
            if (SimpleIoc.Default.IsRegistered<T>()) SimpleIoc.Default.Unregister<T>();
        }
    }
}
