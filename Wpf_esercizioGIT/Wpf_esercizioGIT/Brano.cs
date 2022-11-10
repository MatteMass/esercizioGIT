using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_esercizioGIT
{
    internal class Brano
    {
        internal string Titolo { get; set; }
        internal string Autore { get; set; }

        internal int Durata { get; set; }

        internal Brano()
        {
            this.Titolo = Titolo;
            this.Autore = Autore;
            this.Durata = Durata;
        }
       internal string toString()
        {
            return Titolo + " " + Autore + " " + Durata.ToString();
        }
        internal bool shortSong()
        {
            int durataData = Console.ReadLine(); //non ho fatto in tempo perché sono lento
        }

    }
}
