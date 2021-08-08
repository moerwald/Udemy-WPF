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

namespace Buton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_lblHelloWorld.Content?.Equals("Hello World") ?? false)
            {
                _lblHelloWorld.Content = "Bye World";
                return;
            }
            _lblHelloWorld.Content = "Hello World";
        }


        private void BtnRed_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Red;
        }

        private void BtnGreen_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Green;
        }

        private void BtnBlue_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Blue;
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            Background = Brushes.White;
        }
    }
}
