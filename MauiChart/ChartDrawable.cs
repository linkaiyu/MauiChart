//using Microsoft.Maui.Controls.Shapes;

namespace MauiChart.Drawables
{
	internal class ChartDrawable : IDrawable
	{
		public Line[] lines { get; set; }

		public void Draw(ICanvas canvas, RectF dirtyRect)
		{
			if (lines == null)
				return;


			for (int i = 0; i < lines.Length; i++)
			{
				if (lines[i].start.Y > lines[i].end.Y)
					canvas.StrokeColor = Colors.Green;
				else
					canvas.StrokeColor = Colors.Red;

				canvas.StrokeSize = 3;
				canvas.DrawLine(lines[i].start, lines[i].end);

			}
		}

	}

	public class Line
	{
		public PointF start;
		public PointF end;
	}

}
