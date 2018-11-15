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

namespace HelloWorld
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
            DerGriddler.Background = Brushes.ForestGreen;
            Button neu = new Button
            {
                Margin = new Thickness(10,20,40,70),
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Bottom,
                FontSize = 20,
                Content = "ICH BIN NEU!"
            };
            DerGriddler.Children.Add(neu);
            neu.Click += Neu_Click;
        }

        private void Neu_Click(object sender, RoutedEventArgs e)
        {
            DerGriddler.Background = Brushes.Gold;
            MessageBox.Show("Der neue Button wurde geklickt!");
        }
    }
}
