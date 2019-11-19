using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MarsChallengeWPF
{
    class ColorCell
    {
        List<Brush> colors;
        public ColorCell()
        {
            colors = new List<Brush>();
        }
        public void addcolor(Brush color)
        {
            colors.Add(color);
        }
        public Brush getColor()
        {
            if (colors.Count == 0)
                return new SolidColorBrush(Colors.White);
            byte R = 0;
            byte G = 0;
            byte B = 0;
                for (int i = 0; i < colors.Count; i++)
                {
                    var color = ((SolidColorBrush)colors[i]).Color;
                    R += (byte)(color.R * (1.0 / colors.Count));
                    G += (byte)(color.G * (1.0 / colors.Count));
                    B += (byte)(color.B * (1.0 / colors.Count));
                }
            Color output = Color.FromRgb(R, G, B);
            Brush brush = new SolidColorBrush(output);
            return brush;
        }
    }
}
