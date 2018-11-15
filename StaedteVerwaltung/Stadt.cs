using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaedteVerwaltung
{
    class Stadt
    {
        public enum Stadtart { Dorf, Kleinstadt, Grossstadt, Metropole}

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private bool kreisstadt;

        public bool Kreisstadt
        {
            get { return kreisstadt; }
            set { kreisstadt = value; }
        }

        private Stadtart typ;

        public Stadtart Typ
        {
            get { return typ; }
            set { typ = value; }
        }

        public Stadt(string name, bool kreisstadt, Stadtart typ)
        {
            Name = name;
            Kreisstadt = kreisstadt;
            Typ = typ;
        }



    }
}
