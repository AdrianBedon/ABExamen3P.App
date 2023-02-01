namespace ABExamen3P;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(ABViews.ABEditPokemon), typeof(ABViews.ABEditPokemon));
    }
}
