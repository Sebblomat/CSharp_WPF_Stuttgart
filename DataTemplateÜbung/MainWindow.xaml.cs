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

namespace DataTemplateÜbung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Serie> serienListe;

        public MainWindow()
        {
            InitializeComponent();
            serienListe = new ObservableCollection<Serie>() {
                new Serie("Breaking Bad", 8, Serie.Genre.Drama),
                new Serie("Game of Thrones", 9, Serie.Genre.Drama),
                new Serie("Archer", 9, Serie.Genre.Comedy),
                new Serie("Preacher", 10, Serie.Genre.Action),
            };
            newgenre.Items.Add(Serie.Genre.Action);
            newgenre.Items.Add(Serie.Genre.Comedy);
            newgenre.Items.Add(Serie.Genre.Drama);
            newgenre.Items.Add(Serie.Genre.Krimi);
            this.DataContext = serienListe;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int myrating;
            if (int.TryParse(newrating.Text, out myrating))
            {
                var neu = new Serie(newname.Text, myrating, (Serie.Genre)newgenre.SelectedItem);
                serienListe.Add(neu);

            }
            else { MessageBox.Show("Bitte gib einen ganzzahligen Wert an!"); }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            serienListe.Remove((Serie)lbSerie.SelectedItem);
            //MessageBox.Show(lbSerie.SelectedItem.ToString());
            //serienListe.Remove();
        }
    }
}
