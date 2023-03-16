//using Microsoft.Maui.Controls.Shapes;

namespace MauiChart.Drawables
{
	internal class ChartDrawable : IDrawable
	{
		public void Draw(ICanvas canvas, RectF dirtyRect)
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

			for (int i = 0; i < lineCount; i++)
			{
				canvas.DrawLine(lines[i].start, lines[i].end);

			}
		}

	}

	internal class Line
	{
		public PointF start;
		public PointF end;
	}

}
