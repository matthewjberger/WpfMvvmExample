namespace WpfMvvmExample.ViewModel
{
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using Utilities;

    public class HomeScreenViewModel : ViewModelBase
    {
        public RelayCommand NavigateToNextScreen { get; }

        public HomeScreenViewModel()
        {
            NavigateToNextScreen = new RelayCommand(ExecuteNavigateToNextScreen);
        }

        private static void ExecuteNavigateToNextScreen()
        {
            MessengerUtilities.NavigateToViewModel<OtherScreenViewModel>();
        }
    }
}
