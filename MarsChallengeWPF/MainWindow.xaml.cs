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

        private void koshka_example_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            koshka_example.Children.Clear();
            koshka_example.Children.Add(GeneratorLine(0, (int)koshka_example.ActualHeight / 2, (int)koshka_example.ActualWidth, (int)koshka_example.ActualHeight / 2, player.koshka_tail));
        }

        private void vampus_example_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            vampus_example.Children.Clear();
            vampus_example.Children.Add(GeneratorLine(0, (int)vampus_example.ActualHeight / 2, (int)vampus_example.ActualWidth, (int)vampus_example.ActualHeight / 2, player.vampus_tail));
        }

        private void privedenie_example_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            privedenie_example.Children.Clear();
            privedenie_example.Children.Add(GeneratorLine(0, (int)privedenie_example.ActualHeight / 2, (int)privedenie_example.ActualWidth, (int)privedenie_example.ActualHeight / 2, player.privedenie_tail));
        }

        private Line GeneratorLine(int _x1, int _y1, int _x2, int _y2, Brush color)
        {
            Line output = new Line
            {
                X1 = _x1,
                X2 = _x2,
                Y1 = _y1,
                Y2 = _y2,
                Stroke = color,
                StrokeThickness = 2
            };
            return output;
        }
    }
}
