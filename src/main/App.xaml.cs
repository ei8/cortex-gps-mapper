
namespace ei8.Cortex.Gps.Mapper;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window =base.CreateWindow(activationState);
        window.Created += (e, s) =>
        {
            Console.WriteLine("PassXYZ.Vault.App: 1. Created event");
        };
		return window;
    }
}
