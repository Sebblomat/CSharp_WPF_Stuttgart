using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplateÜbung
{
    public class Serie
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public enum Genre { Krimi, Action, Drama, Comedy}
        public Genre SerienGenre { get; set; }

        public Serie(string name, int rating, Genre genre)
        {
            Name = name;
            Rating = rating;
            SerienGenre = genre;
        }
    }
}
