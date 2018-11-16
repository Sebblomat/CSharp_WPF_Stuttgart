using SexyBooks.Helpers;
using SexyBooks.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SexyBooks.ViewModels
{
    public class ErgebnisViewModel : ModelBase
    {
        #region Properties
        private string suchbegriff;

        public string Suchbegriff
        {
            get { return suchbegriff; }
            set { SetValue(ref suchbegriff, value); }
        }

        private ObservableCollection<Buch> buecher;

        public ObservableCollection<Buch> Buecher
        {
            get { return buecher; }
            set { SetValue(ref buecher, value); }
        }
        public DelegateCommand AddFavoriteCommand { get; set; }
        #endregion
        public ErgebnisViewModel(ObservableCollection<Buch> buecher, string suchbegriff)
        {
            AddFavoriteCommand = new DelegateCommand(AddFavorite);
            Buecher = buecher;
            Suchbegriff = suchbegriff;
        }

        public ErgebnisViewModel()
        {

        }

        private void AddFavorite(object obj)
        {
            MessageBox.Show("Favorit");
        }
    }
}
