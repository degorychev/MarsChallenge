using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MarsChallengeWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int n;
        sandbox sndb;
        public MainWindow()
        {
            InitializeComponent();
            n = 3;
            sndb = new sandbox(n);
            paint();
        }

        private void paint()
        {
            MainCanvas.Children.Clear();
            var elements = sndb.render((int)MainCanvas.ActualWidth, (int)MainCanvas.ActualHeight);
            while (elements.Count != 0)
                MainCanvas.Children.Add(elements.Dequeue());
        }

        private void ClearTraekt_Click(object sender, RoutedEventArgs e)
        {
            sndb.clearPlayers();
            paint();
        }

        private void MainCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            paint();
        }

        private void LovushkiInit_Click(object sender, RoutedEventArgs e)
        {
            sndb = new sandbox(n);
            paint();
        }

        private void StartKoshka_Click(object sender, RoutedEventArgs e)
        {
            Point koord = new Point(n / 2, n / 2);
            player cat = new player(player.koshka, koord);
            sndb.playerStart(cat);
            paint();
        }

        private void StartVampus_Click(object sender, RoutedEventArgs e)
        {
            Point koord = new Point(n / 2, n / 2);
            player vampus = new player(player.vampus, koord);
            sndb.playerStart(vampus);
            paint();
        }

        private void StartPrivedenie_Click(object sender, RoutedEventArgs e)
        {
            Point koord = new Point(n / 2, n / 2);
            player privedenie = new player(player.privedenie, koord);
            sndb.playerStart(privedenie);
            paint();
        }
    }
}
