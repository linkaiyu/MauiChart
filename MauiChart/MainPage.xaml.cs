using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace MauiChart;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void btnDraw_Clicked(object sender, EventArgs e)
	{
		// need to pass draw data to the ChartDrable object
		// e.g. an array of stock price change into every 5 minutes
		//
		//	{
		//	"10:00", "200",
		//	"10:05", "210",
		//	"10:10", "206",
		//	"10:15", "210",
		//	"10:10", "206",
		//	"10:15", "220",
		//	"10:20", "223",
		//	}

		graphicsView.Invalidate();

	}
}

