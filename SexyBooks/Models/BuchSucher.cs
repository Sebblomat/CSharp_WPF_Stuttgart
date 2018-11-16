using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SexyBooks.Models
{
    public class BuchSucher
    {
        public static ObservableCollection<Buch> SucheBuecher(string suchbegriff)
        {
            try
            {

            HttpClient client = new HttpClient();
            string json = client.GetStringAsync("https://www.googleapis.com/books/v1/volumes?q=" + suchbegriff).Result;

            //json->c#
            BuchErgebnis ergebnis = JsonConvert.DeserializeObject<BuchErgebnis>(json);

            ObservableCollection<Buch> buecher = new ObservableCollection<Buch>(ergebnis.items);

            return buecher;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new ObservableCollection<Buch>();
            }

        }
    }
}
