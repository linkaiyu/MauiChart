using MauiChart.Drawables;
using Microsoft.Maui.Controls;

namespace MauiChart;

public partial class ChatDrawPage : ContentPage
{
	public ChatDrawPage()
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

		// for now, we just pass the line info 
		var chartDrawable = graphicsView.Drawable as ChartDrawable;
		if (chartDrawable != null)
		{
			int lineCount = 5;
			Line[] lines = new Line[lineCount];


			for (int i = 0; i < lineCount; i++)
			{
				lines[i] = new Line() { start = new PointF(i * 40, 0), end = new PointF((i + 1) * 40, 0) };

			}

			lines[0].start.Y = 0;
			lines[0].end.Y = 30;

			lines[1].start.Y = 30;
			lines[1].end.Y = 20;

			lines[2].start.Y = 20;
			lines[2].end.Y = 60;

			lines[3].start.Y = 60;
			lines[3].end.Y = 20;

			lines[4].start.Y = 20;
			lines[4].end.Y = 70;

			chartDrawable.lines = lines;

			graphicsView.Invalidate();
		}

	}

}