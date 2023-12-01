using MauiPlanets.Models;

namespace MauiPlanets.Views;

public partial class PlanetsPage : ContentPage
{
	public PlanetsPage()
    {
        InitializeComponent();
	}

	async void ApiPic_Clicked(System.Object sender, System.EventArgs e)
	{

	}

    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {

    }

    async void Planets_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new PlanetDetailsPage(e.CurrentSelection.First() as Planet));
    }
}