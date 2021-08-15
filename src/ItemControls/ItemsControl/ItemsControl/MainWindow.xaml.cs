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

namespace ItemsControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly List<Person> _persons = new List<Person>
        {
            new Person { Name = "Steve", Age = 34},
            new Person { Name = "Peggy", Age = 30},
            new Person { Name = "Dan", Age = 25}
        };

        public MainWindow()
        {
            InitializeComponent();

            itemsControl.ItemsSource = _persons;
            lstBoxPersonControl.ItemsSource = _persons;
        }

        private void LstBoxPersonControl_SelectionChanged(object sender, SelectionChangedEventArgs e) => 
            lblSelectedItem.Content = (lstBoxPersonControl.SelectedItem as Person)?.Name ?? "undef";
    }


    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
