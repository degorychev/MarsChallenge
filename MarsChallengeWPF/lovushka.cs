using Svg;
using System;
using System.Collections.Generic;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace MarsChallengeWPF
{
    public class lovushka
    {
        public const int nul = 0;
        public const int verevka = 1;
        public const int detektor = 2;

        int active;
        int _vid;
        public lovushka(int vid)
        {
            _vid = vid;
            active = 100;
        }
        public override string ToString()
        {
            switch (_vid)
            {
                case nul:
                    return "Пусто";
                case verevka:
                    return "Веревка";
                case detektor:
                    return "Детектор";
                default:
                    return "ERROR";
            }
        }

        public void atack(player _player)
        {
            if (_vid == verevka)
            {
                if (_player._vid == player.koshka)
                    active -= 50;
                else if (_player._vid == player.vampus)
                    active -= 100;
            }
            else if (_vid == detektor)
            {
                if (_player._vid == player.koshka)
                    active -= 50;
                else if (_player._vid == player.privedenie)
                    active -= 100;
            }
            if (active < 0)
                active = 0;
        }

        public bool activ()
        {
            if (active == 0)
                return false;
            return true;
        }

        private Line GeneratorLine(int _x1, int _y1, int _x2, int _y2)
        {
            Line output = new Line
            {
                X1 = _x1,
                X2 = _x2,
                Y1 = _y1,
                Y2 = _y2,
                Stroke = Brushes.Brown,
                StrokeThickness = 2
            };
            return output;
        }

        public Queue<UIElement> getImage(int startx, int starty, int _width, int _height)
        {
            Queue<UIElement> elements = new Queue<UIElement>();
            int width = startx + _width;
            int height = starty + _height;
            switch (_vid)
            {
                case nul:
                    break;
                case verevka:
                    elements.Enqueue(GeneratorLine(startx + _width / 2, starty, startx, starty + _height / 2));
                    elements.Enqueue(GeneratorLine(startx, starty + _height / 2, startx + _width / 2, height));
                    elements.Enqueue(GeneratorLine(startx + _width / 2, height, width, starty + _height / 2));
                    elements.Enqueue(GeneratorLine(width, starty + _height / 2, startx + _width / 2, starty));
                    break;
                case detektor:
                    elements.Enqueue(GeneratorLine(startx + _width / 2, starty, startx + _width / 2, height));
                    elements.Enqueue(GeneratorLine(startx, starty + _height / 2, width, starty + _height / 2));


                    break;
                default:
                    break;
            }
            return elements;
        }

            //public Bitmap getImage(int width, int height)
            //{
            //    string strsvg;
            //    switch (_vid)
            //    {
            //        case nul:
            //            strsvg = System.Text.Encoding.UTF8.GetString(images.zero);
            //            break;
            //        case verevka:
            //            strsvg = System.Text.Encoding.UTF8.GetString(images.romb);
            //            break;
            //        case detektor:
            //            strsvg = System.Text.Encoding.UTF8.GetString(images.star);
            //            break;
            //        default:
            //            strsvg = "ERROR";
            //            break;
            //    }
            //    var svg = SvgDocument.FromSvg<SvgDocument>(strsvg); ;
            //    return svg.Draw(width, height);
            //}
        }
}
