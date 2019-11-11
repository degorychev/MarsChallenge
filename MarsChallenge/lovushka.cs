using Svg;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsChallenge
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

        public Bitmap getImage(int width, int height)
        {
            string strsvg;
            switch (_vid)
            {
                case nul:
                    strsvg = System.Text.Encoding.UTF8.GetString(images.zero);
                    break;
                case verevka:
                    strsvg = System.Text.Encoding.UTF8.GetString(images.romb);
                    break;
                case detektor:
                    strsvg = System.Text.Encoding.UTF8.GetString(images.star);
                    break;
                default:
                    strsvg = "ERROR";
                    break;
            }
            var svg = SvgDocument.FromSvg<SvgDocument>(strsvg); ;
            return svg.Draw(width, height);
        }
    }
}
