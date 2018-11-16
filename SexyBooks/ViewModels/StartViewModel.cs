using SexyBooks.Helpers;
using SexyBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SexyBooks.ViewModels
{
    public class StartViewModel : ModelBase
    {
        //Eigenschaften
        private string suchbegriff;

        public string Suchbegriff
        {
            get { return suchbegriff; }
            set { SetValue(ref suchbegriff, value); }
        }

        //Interaktionen (Commands)
        public DelegateCommand SucheCommand { get; set; }
        public DelegateCommand FavoritenCommand { get; set; }

        public StartViewModel()
        {
            SucheCommand = new DelegateCommand(SucheBuch,Suchbar);
            FavoritenCommand = new DelegateCommand(ZeigeFavoriten);

        }

        public bool Suchbar(object p)
        {
            return !string.IsNullOrWhiteSpace(Suchbegriff);
        }

        public void SucheBuch(object p)
        {
            BuchSucher.SucheBuecher(Suchbegriff);
        }

        public void ZeigeFavoriten(object p)
        {
            MessageBox.Show("Die Chabos wissen, wer der Favo ist!");
        }

    }
}
