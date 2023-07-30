
using Microsoft.Maui.Maps;
using System;
using WhereIsIt.ViewModel;

namespace WhereIsIt;

public partial class MainPage : ContentPage
{    public async void SetCurrentLocation(object sender, EventArgs e)
    {
		map.IsShowingUser = true;
		var dataContext = this.BindingContext as TestViewModel;
		var location = await dataContext.GetCurrentLocation();
		if(location != null)
		{
			map.MoveToRegion(MapSpan.FromCenterAndRadius(location, Distance.FromKilometers(3)));
			map.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin
			{
				Label = "현재 위치",
				Location = location,
				Type = Microsoft.Maui.Controls.Maps.PinType.Generic
			});
		}
		else
		{
			await DisplayAlert("Error", "There is Error at saving Location", "OK");
		}
    }

	public MainPage()
	{
		InitializeComponent();
	}	
}

