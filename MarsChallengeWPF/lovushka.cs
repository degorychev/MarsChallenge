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
            return !(active == 0);
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
            int border = 3;
            startx += border;
            starty += border;
            _width -= border * 2;
            _height -= border * 2;

            Queue<UIElement> elements = new Queue<UIElement>();
            int width = startx + _width;
            int height = starty + _height;
            switch (_vid)
            {
                case nul:
                    break;
                case verevka:
                    elements.Enqueue(GeneratorLine(findcenter(startx, _width), starty, startx, findcenter(starty, _height)));
                    elements.Enqueue(GeneratorLine(startx, findcenter(starty, _height), findcenter(startx, _width), height));
                    elements.Enqueue(GeneratorLine(findcenter(startx, _width), height, width, findcenter(starty, _height)));
                    elements.Enqueue(GeneratorLine(width, findcenter(starty, _height), findcenter(startx, _width), starty));
                    break;
                case detektor:
                    elements.Enqueue(GeneratorLine(findcenter(startx, _width), starty, findcenter(startx, _width) - 5, findcenter(starty, _height) - 5));
                    elements.Enqueue(GeneratorLine(findcenter(startx, _width) - 5, findcenter(starty, _height) - 5, startx, findcenter(starty, _height)));
                    elements.Enqueue(GeneratorLine(startx, findcenter(starty, _height), findcenter(startx, _width) - 5, findcenter(starty, _height) + 5));
                    elements.Enqueue(GeneratorLine(findcenter(startx, _width) - 5, findcenter(starty, _height) + 5, findcenter(startx, _width), height));
                    elements.Enqueue(GeneratorLine(findcenter(startx, _width), height, findcenter(startx, _width) + 5, findcenter(starty, _height) + 5));
                    elements.Enqueue(GeneratorLine(findcenter(startx, _width) + 5, findcenter(starty, _height) + 5, width, findcenter(starty, _height)));
                    elements.Enqueue(GeneratorLine(width, findcenter(starty, _height), findcenter(startx, _width) + 5, findcenter(starty, _height) - 5));
                    elements.Enqueue(GeneratorLine(findcenter(startx, _width) + 5, findcenter(starty, _height) - 5, findcenter(startx, _width), starty));

                    break;
                default:
                    break;
            }
            return elements;
        }

        private int findcenter(int x, int width)
        {
            return x + width / 2;
        }
    }
}
