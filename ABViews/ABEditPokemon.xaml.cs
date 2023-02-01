using ABExamen3P.ABModels;
using ABExamen3P.ABViewModel;
namespace ABExamen3P.ABViews;

[QueryProperty(nameof(ItemId), nameof(ItemId))]
public partial class ABEditPokemon : ContentPage
{
	ABPokemonDataCompleta ABItem = new ABPokemonDataCompleta();
	public ABEditPokemon()
	{
		InitializeComponent();
		LoadPokemonData();
	}

    protected override void OnAppearing()
    {
        LoadPokemonData();
    }

    private void LoadPokemonData(int value = -1)
    {
        if (value > -1)
        {
            ABItem = App.PokemonRepo.GetPokemon(value);
            ABSaveButton.Text = "Editar";
        }

        BindingContext = ABItem;
    }

    private async void CancelButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        ABItem.ABNombre = ABName.Text;
        ABItem.ABTipo = ABTypo.Text;
        ABItem.ABDescripcion = ABDescription.Text;
        ABItem.ABFecha = DateTime.ParseExact(ABDate.Text, "dd/MM/yyyy HH:mm:ss", null);

        App.PokemonRepo.UpdatePokemon(ABItem);

        await Shell.Current.GoToAsync("..");

    }

    public int ItemId
    {
        set { LoadPokemonData(value); }
    }
}