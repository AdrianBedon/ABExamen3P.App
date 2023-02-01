using ABExamen3P.ABModels;

namespace ABExamen3P.ABViews;

public partial class ABListaLocal : ContentPage
{
	public ABListaLocal()
	{
		InitializeComponent();
		LoadPokemonLocal();
	}

    protected override void OnAppearing()
    {
        LoadPokemonLocal();
    }

    private void LoadPokemonLocal()
    {
        List<ABPokemonDataCompleta> pokemon = App.PokemonRepo.GetAllPokemons();
        ABPokemonListLocal.ItemsSource = pokemon;
    }

    private void pokemonCollectionLocal_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}