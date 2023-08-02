using TestRepro.ViewModel;

namespace TestRepro;

public partial class AppShell : Shell
{
    public AppShell(AppShellViewModel viewModel )
    {
        InitializeComponent();
        BindingContext = viewModel;

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        //Routing.RegisterRoute(nameof(AppShell), typeof(AppShell));
    }
}
