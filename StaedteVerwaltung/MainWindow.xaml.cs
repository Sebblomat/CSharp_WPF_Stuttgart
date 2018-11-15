using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace StaedteVerwaltung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Stadt> stadtliste;


        public MainWindow()
        {
            InitializeComponent();
            stadtliste = new ObservableCollection<Stadt>() {
                new Stadt("Stuttgart", true, Stadt.Stadtart.Grossstadt),
                new Stadt("Heidelberg", true, Stadt.Stadtart.Kleinstadt),
                new Stadt("Tokyo", false, Stadt.Stadtart.Metropole),
            };
            Staedte.ItemsSource = stadtliste;
        }
    }
}
