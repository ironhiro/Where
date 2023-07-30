
using System;namespace WhereIsIt;

public partial class MainPage : ContentPage
{    public void SetCurrentLocation(object sender, EventArgs e)
    {
		map.IsShowingUser = true;
    }


	public MainPage()
	{
		InitializeComponent();
	}	
}

