namespace TestRepro;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell(new ViewModel.AppShellViewModel());
	}
}
