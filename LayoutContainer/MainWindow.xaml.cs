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

namespace LayoutContainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string _farbe;
        public MainWindow()
        {
            InitializeComponent();
            cbGeschlecht.Items.Add(Geschlechter.männlich);
            cbGeschlecht.Items.Add(Geschlechter.weiblich);
            cbGeschlecht.SelectedIndex = 0;
        }

        private void AddPerson_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            Geschlechter geschlecht = (Geschlechter) cbGeschlecht.SelectedItem;
            //? steht für nullable types
            DateTime? gb = dpGeburtsdatum.SelectedDate;
            string haircolor = _farbe;
            MessageBox.Show($"Der Name der Person ist {name} ({geschlecht}).\nDer Geburtstag ist am {gb:d} und seine Haarfarbe ist {haircolor}.");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is RadioButton rb)
            {
                _farbe = rb.Content.ToString();
            }
        }
    }
    public enum Geschlechter {männlich, weiblich};
}
