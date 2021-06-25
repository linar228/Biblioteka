using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BibliotekaLibrary
{
    public static class LibMaker
    {
        public static Lib Make(string Code, string Nazvanie)
        {
            Lib lib = null;

            switch (Code)
            {
                case "B":
                    lib = new Book(Nazvanie);
                    break;

                case "P":
                    lib = new Pazl(Nazvanie);
                    break;

                case "T":
                    lib = new Table(Nazvanie);
                    break;
            }
            return lib;
        }
    }


    public abstract class Lib
    {
        protected string Nazvanie;

        public Lib(string newNazvanie)
        {
            Nazvanie = newNazvanie;
        }
        public abstract void Save(string newNazvanie, List<string> details);
    }

    class Book : Lib
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

    class Pazl : Lib
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

    class Table : Lib
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

