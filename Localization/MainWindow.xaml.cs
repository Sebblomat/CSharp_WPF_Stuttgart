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

namespace Localization
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sender is Slider slider)
            {
                this.Resources["globalFontSize"] = slider.Value;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            sliderSize.Value = (double)this.Resources["globalFontSize"];
            sliderSize.ValueChanged += Slider_ValueChanged;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox cb)
            {
                string lang = ((ComboBoxItem) cb.SelectedItem).Content.ToString();
                if (lang == "Deutsch")
                {
                    Application.Current.Resources.MergedDictionaries[0].Source = new Uri("pack://application:,,,/Languages/German.xaml");
                }
                if (lang == "Français")
                {
                    Application.Current.Resources.MergedDictionaries[0].Source = new Uri("pack://application:,,,/Languages/French.xaml");
                }
                new MainWindow().Show();
                this.Close();
            }
        }
    }
}
