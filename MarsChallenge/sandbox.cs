using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsChallenge
{
    public class sandbox
    {
        int _n;
        lovushka[,] _pole;
        List<player> players;

        public void clearPlayers()
        {
            players.Clear();
        }
        public sandbox(int n)
        {
            _n = n;
            _pole = new lovushka[n, n];
            players = new List<player>();
            generator();
        }
        public void playerStart(player _pl)
        {
            do
            {
                _pole[_pl._koord.X, _pl._koord.Y].atack(_pl);
                _pl.tick();
            } while (_pl.proverka(_n));

            players.Add(_pl);
        }
        private void generator()
        {
            Queue<lovushka> listtypes = new Queue<lovushka>();
            listtypes.Enqueue(new lovushka(lovushka.verevka));
            listtypes.Enqueue(new lovushka(lovushka.verevka));
            listtypes.Enqueue(new lovushka(lovushka.verevka));
            listtypes.Enqueue(new lovushka(lovushka.detektor));
            listtypes.Enqueue(new lovushka(lovushka.detektor));
            listtypes.Enqueue(new lovushka(lovushka.detektor));
            if (_n * _n < listtypes.Count)
            {
                MessageBox.Show("Количество ловушек превышает количество клеток");
                return;
            }
            Random rnd = new Random();
            while (listtypes.Count > 0)
            {
                var current = listtypes.Dequeue();
                int x;
                int y;
                do
                {
                    x = rnd.Next(_n);
                    y = rnd.Next(_n);
                } while (_pole[x, y] != null);
                _pole[x, y] = current;
            }
            for (int x = 0; x < _n; x++)
                for (int y = 0; y < _n; y++)
                    if (_pole[x, y] == null)
                        _pole[x, y] = new lovushka(lovushka.nul);
        }

        public Image render(int _width, int _height)
        {
            Pen black_pen = new Pen(Color.Black);
            Pen red_pen = new Pen(Color.Red);


            Bitmap bm = new Bitmap(_width, _height);
            Graphics gr = Graphics.FromImage(bm);

            int width = _width / _n;
            int height = _height / _n;

            //Сетка
            for (int x = 1; x < _n; x++)
                gr.DrawLine(black_pen, width * x, 0, width * x, _height);
            for (int y = 1; y < _n; y++)
                gr.DrawLine(black_pen, 0, height * y, _width, height * y);
            //Ловушки
            for (int x = 0; x < _n; x++)
                for (int y = 0; y < _n; y++)
                {
                    if (!_pole[x, y].activ())
                    {
                        int border = 3;
                        Brush br = red_pen.Brush;
                        gr.FillRectangle(br, new Rectangle(width * x + border, height * y + border, width - border * 2, height - border * 2));
                    }
                    gr.DrawImage(_pole[x, y].getImage(width, height), new Rectangle(width * x, height * y, width, height));
                }
            //Ходы
            for (int i = 0; i < players.Count; i++)
            {
                var player = players[i];
                var moves = player.moves;
                Point koord = moves[0];
                for (int j = 1; j < moves.Count; j++)
                {
                    Point newkoord = moves[j];
                    gr.DrawLine(new Pen(player.Tail), getCenter(koord, width, height), getCenter(newkoord, width, height));
                    koord = newkoord;
                }
            }
            gr.Save();
            return bm;
        }

        private Point getCenter(Point koord, int _width, int _height)
        {
            int x = (koord.X + 1) * _width - _width / 2;
            int y = (koord.Y + 1) * _height - _height / 2;
            Point output = new Point(x, y);
            return output;
        }
    }
}
