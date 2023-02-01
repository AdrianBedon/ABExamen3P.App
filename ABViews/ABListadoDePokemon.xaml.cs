using ABExamen3P.ABModels;
using Newtonsoft.Json;

namespace ABExamen3P.ABViews;

public partial class ABListadoDePokemon : ContentPage
{
	public ABListadoDePokemon()
	{
		InitializeComponent();
        LoadPokemon();
	}

    protected override void OnAppearing()
    {
        LoadPokemon();
    }

    private async void LoadPokemon()
    {
        var request = new HttpRequestMessage();
        request.RequestUri = new Uri("https://pokeapi.co/api/v2/pokemon?limit=1000");
        request.Method = HttpMethod.Get;
        request.Headers.Add("Accept", "application/json");

        var client =  new HttpClient();

        HttpResponseMessage response = await client.SendAsync(request);

        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            String content = await response.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<Root>(content);
            ABPokemonList.ItemsSource = resultado.results;
        }
    }

    private void pokemonCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}