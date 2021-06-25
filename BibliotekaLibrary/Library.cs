using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BibliotekaLibrary
{
    public static class ChillMaker
    {
        public static Chill Make(string chillCode, string Nazvanie)
        {
            Chill chill = null;

            switch (chillCode)
            {
                case "B":
                    chill = new Book(Nazvanie);
                    break;

                case "P":
                    chill = new Pazl(Nazvanie);
                    break;

                case "T":
                    chill = new Table(Nazvanie);
                    break;
            }
            return chill;
        }
    }


    public abstract class Chill
    {
        protected string Nazvanie;

        public Chill(string newNazvanie)
        {
            Nazvanie = newNazvanie;
        }
        public abstract void Save(string newNazvanie, List<string> details);
    }

    class Book : Chill
    {
        string bookPath = @"H:\book.txt";

        public Book(string newNazvanie) : base(newNazvanie)
        {
        }

        public override void Save(string newNazvanie, List<string> details)
        {
            using (StreamWriter sw = new StreamWriter(bookPath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(newNazvanie);
                foreach (var det in details)
                    sw.WriteLine(det);
            }
        }
    }

    class Pazl : Chill
    {
        string pazlPath = @"H:\pazl.txt";

        public Pazl(string newNazvanie) : base(newNazvanie)
        {
        }

        public override void Save(string newNazvanie, List<string> details)
        {
            using (StreamWriter sw = new StreamWriter(pazlPath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(newNazvanie);
                foreach (var det in details)
                    sw.WriteLine(det);
            }
        }
    }

    class Table : Chill
    {
        string tablePath = @"H:\table.txt";

        public Table(string newNazvanie) : base(newNazvanie)
        {
        }

        public override void Save(string newNazvanie, List<string> details)
        {
            using (StreamWriter sw = new StreamWriter(tablePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(newNazvanie);
                foreach (var det in details)
                    sw.WriteLine(det);
            }
        }
    }
}

