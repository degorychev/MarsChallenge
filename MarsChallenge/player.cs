using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsChallenge
{
    public class player
    {
        public const int vampus = 0;
        public const int koshka = 1;
        public const int privedenie = 2;
        public int _vid;
        public Point _koord;
        public List<Point> moves;
        public Color Tail;
        Random rnd;
        public player(int vid, Point koord)
        {
            _vid = vid;
            _koord = koord;
            rnd = new Random();
            moves = new List<Point>();
            moves.Add(_koord);
            ColorSelect();
        }
        private void ColorSelect()
        {
            if (_vid == vampus)
                Tail = Color.Green;
            else if (_vid == koshka)
                Tail = Color.Blue;
            else if (_vid == privedenie)
                Tail = Color.Yellow;
            else
            {
                MessageBox.Show("Непонятное существо");
                Tail = Color.Red;
            }
        }
        public void tick()
        {
            int napr = rnd.Next(3);
            switch (napr)
            {
                case 0:
                    _koord.X -= 1;
                    break;
                case 1:
                    _koord.X += 1;
                    break;
                case 2:
                    _koord.Y -= 1;
                    break;
                case 3:
                    _koord.Y += 1;
                    break;
            }
            moves.Add(_koord);
        }
        public bool proverka(int _size)
        {
            if ((_koord.X < 0) || (_koord.X == _size))
                return false;
            if ((_koord.Y < 0) || (_koord.Y == _size))
                return false;
            return true;
        }
    }
}
