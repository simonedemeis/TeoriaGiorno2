using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaGiorno2.Models
{
    public class Libro
    {
        public virtual string Titolo { get; set; }
        public virtual string Autore {  get; set; }

        public Libro(string titolo, string autore)
        {
            Titolo = titolo;
            Autore = autore;
        }

        public virtual void Descrizione()
        {
            Console.WriteLine($"Titolo: {Titolo}, Autore: {Autore}");
        }
    }
}
