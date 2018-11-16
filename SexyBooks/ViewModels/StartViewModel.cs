using SexyBooks.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
