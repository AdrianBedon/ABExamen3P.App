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

    private async void pokemonCollectionLocal_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            var pokemon = (ABModels.ABPokemonDataCompleta)e.CurrentSelection[0];

            string action = await DisplayActionSheet("Seleccione la acción que desea realizar:", "Cancel", null, "Editar", "Borrar");

            if (action == "Editar")
            {
                await Shell.Current.GoToAsync($"{nameof(ABEditPokemon)}?{nameof(ABEditPokemon.ItemId)}={pokemon.ABId}");
            }
            else if (action == "Borrar")
            {
                App.PokemonRepo.DeletePokemon(pokemon);
                LoadPokemonLocal();
            }
            else
            {
                LoadPokemonLocal();
            }
        }

        ABPokemonListLocal.SelectedItem = null;
    }
}