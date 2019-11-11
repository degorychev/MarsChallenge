using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using Svg;

namespace MarsChallenge
{
    public partial class Form1 : Form
    {
        int n;
        sandbox sndb;
        public Form1()
        {
            InitializeComponent();
            n = 3;
            sndb = new sandbox(n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sndb = new sandbox(n);
            paint();
        }

        private void paint()
        {
            pictureBox1.Image = sndb.render(pictureBox1.Width, pictureBox1.Height);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //paint();
        }

        private void CatStart_Click(object sender, EventArgs e)
        {
            Point koord = new Point(n / 2, n / 2);
            player cat = new player(player.koshka, koord);
            sndb.playerStart(cat);
            paint();
        }

        private void VampusStart_Click(object sender, EventArgs e)
        {
            Point koord = new Point(n / 2, n / 2);
            player vampus = new player(player.vampus, koord);
            sndb.playerStart(vampus);
            paint();
        }

        private void PrivedenieStart_Click(object sender, EventArgs e)
        {
            Point koord = new Point(n / 2, n / 2);
            player privedenie = new player(player.privedenie, koord);
            sndb.playerStart(privedenie);
            paint();
        }

        private void TailClear_Click(object sender, EventArgs e)
        {
            sndb.clearPlayers();
            paint();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            paint();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            paint();
        }
    }
    
    
    
}
