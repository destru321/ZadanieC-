using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe
{
    internal class FotoBook
    {
        protected int numPages;
        protected string albumName;
        protected string albumDesc;


        public FotoBook(string albumName, string albumDesc, int numPages = 16)
        {
            this.numPages = numPages;
            this.albumName = albumName;
            this.albumDesc = albumDesc;
        }

        public void getNumPages()
        {
            System.Console.WriteLine($"Twoja fotoksiazka ma {numPages} stron");
        }

        public override string ToString()
        {
            System.Console.WriteLine($"Nazwa twojej fotoksiazki to: {albumName}");
            getNumPages();
            System.Console.WriteLine($"Opis: {albumDesc}");
            return "";
        }
    }

    internal class BigFotoBook : FotoBook
    {
        public BigFotoBook(string albumName, string albumDesc, int numPages = 64) : base(albumName, albumDesc) 
        {
            this.numPages = numPages;
        }
    }
}