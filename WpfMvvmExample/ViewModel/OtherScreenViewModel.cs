namespace WpfMvvmExample.ViewModel
{
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using Utilities;

    public class OtherScreenViewModel : ViewModelBase
    {
        public OtherScreenViewModel()
        {
            Abort = new RelayCommand(ExecuteAbort);
            NavigateHome = new RelayCommand(ExecuteNavigateHome);
        }

        public RelayCommand Abort { get; }
        private static void ExecuteAbort()
        {
            MessengerUtilities.CloseApplication();
        }

        public RelayCommand NavigateHome { get; }
        private void ExecuteNavigateHome()
        {
            MessengerUtilities.NavigateToViewModel<HomeScreenViewModel>();
        }
    }
}
