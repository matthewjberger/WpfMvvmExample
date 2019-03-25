namespace WpfMvvmExample.Utilities
{
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Messaging;
    using ViewModel;

    public static class MessengerUtilities
    {
        public const string NavigationToken = "Navigation";
        public const string CloseApplicationToken = "CloseApplication";

        public static void NavigateToViewModel<T>() where T : ViewModelBase
        {
            Messenger.Default.Send(
                new GenericMessage<ViewModelBase>(ViewModelLocator.GetInstance<T>()), NavigationToken);
        }

        public static void CloseApplication()
        {
            Messenger.Default.Send<NotificationMessage>(null, CloseApplicationToken);
        }
    }
}
