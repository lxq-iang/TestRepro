using CommunityToolkit.Mvvm.ComponentModel;
using TestRepro.Domain;

namespace TestRepro.ViewModel
{
    public partial class AppShellViewModel: ObservableObject
    {
        [ObservableProperty]
        private bool _isConnected;
        [ObservableProperty]
        private string _userName;
        [ObservableProperty]
        private string _role;

        
        public void ChangeConnectionStatus()
        {
            MainThread.InvokeOnMainThreadAsync(() =>
            {
                IsConnected = _AppConfig.GetConfig.IsConnected;
            });
        }

    }
}
