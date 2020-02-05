using System;
namespace curs2
{
    public class Draw
    {
        public enum LineStyle
        {
            Solid,
            Dotted,
            DotDash
        }

        public void DrawLine(int x1, int y1, int x2, int y2, LineStyle lineStyle)
        {
            if(lineStyle == LineStyle.Solid)
            {
                // cod desenare linie continua
            }
            else if(lineStyle == LineStyle.Dotted)
            {
                // cod desenare linie punctata
            }
            else if (lineStyle == LineStyle.DotDash)
            {
                // cod desenare secventa linie punct
            }
            else
            {
                throw new ArgumentException("Invalid line style");
            }
        }
    }

    class Test
    {
        public static void Main()
        {
            Draw draw = new Draw();
            draw.DrawLine(0, 0, 10, 10, Draw.LineStyle.Solid);
            draw.DrawLine(0, 0, 10, 10, (Draw.LineStyle)100); 
        }
    }
}
