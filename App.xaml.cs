using ABExamen3P.ABData;

namespace ABExamen3P;

public partial class App : Application
{
	public static ABDatabase PokemonRepo { get; set; }
	public App(ABDatabase repo)
	{
		InitializeComponent();

		MainPage = new AppShell();
		PokemonRepo= repo;
	}
}
