using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsChallengeWPF
{
    public class player
    {
        public const int vampus = 0;
        public const int koshka = 1;
        public const int privedenie = 2;
        public int _vid;
        public System.Windows.Point _koord;
        public List<System.Windows.Point> moves;
        public System.Windows.Media.Brush Tail;
        Random rnd;
        public player(int vid, System.Windows.Point koord)
        {
            _vid = vid;
            _koord = koord;
            rnd = new Random();
            moves = new List<System.Windows.Point>();
            moves.Add(_koord);
            ColorSelect();
        }
        private void ColorSelect()
        {
            if (_vid == vampus)
                Tail = System.Windows.Media.Brushes.Green;
            else if (_vid == koshka)
                Tail = System.Windows.Media.Brushes.Blue;
            else if (_vid == privedenie)
                Tail = System.Windows.Media.Brushes.Yellow;
            else
            {
                System.Windows.MessageBox.Show("Непонятное существо");
                Tail = System.Windows.Media.Brushes.Red;
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
