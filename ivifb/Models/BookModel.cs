using System;

namespace FreeBook.Models
{
    public class BookModel
    {
        public int IDCarte { get; set; }
        public int Index { get; set; }
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public DateTime DataImprumut { get; set; }
        public DateTime DataExpirare { get; set; }
        public bool Expirat { get; set; }
    }

}