namespace WpfMvvmExample.ViewModel
{
    using System.Windows;
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Messaging;
    using Utilities;

    public class ApplicationViewModel : ViewModelBase
    {
        private ViewModelBase _displayedViewModel;
        public ViewModelBase DisplayedViewModel
        {
            get => _displayedViewModel;
            set { Set(() => DisplayedViewModel, ref _displayedViewModel, value); }
        }

        private string _titleBarText;
        public string TitleBarText
        {
            get => _titleBarText;
            set { Set(() => TitleBarText, ref _titleBarText, value); }
        }

        public ApplicationViewModel()
        {
            DisplayedViewModel = ViewModelLocator.GetInstance<HomeScreenViewModel>();
            TitleBarText = "Application";

            // Register for messages with the default messenger
            Messenger.Default.Register<GenericMessage<ViewModelBase>>(this, MessengerUtilities.NavigationToken, message => DisplayedViewModel = message.Content);
            Messenger.Default.Register<NotificationMessage>(this, MessengerUtilities.CloseApplicationToken, message =>
            {
                if (Application.Current.MainWindow != null) Application.Current.MainWindow.Close();
            });
        }

        ~ApplicationViewModel()
        {
            Messenger.Default.Unregister(this);
        }
    }
}
