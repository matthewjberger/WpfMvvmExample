namespace WpfMvvmExample.View
{
    using System.ComponentModel;
    using System.Windows;

    /// <summary>
    /// Interaction logic for ApplicationView.xaml
    /// </summary>
    public partial class ApplicationView : Window
    {
        public ApplicationView()
        {
            InitializeComponent();
        }

        private void ApplicationView_OnClosing(object sender, CancelEventArgs e)
        {
            ViewModel.ViewModelLocator.Cleanup();
        }
    }
}
