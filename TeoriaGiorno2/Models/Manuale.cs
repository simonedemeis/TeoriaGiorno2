using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaGiorno2.Models
{
    public class Manuale : Libro
    {
        public string Argomento { get; set; }

        public static bool Consigliato { get; set; }

        public Manuale(string titolo, string autore, string argomento) : base(titolo, autore)
        {
            Argomento = argomento;
        }
        //il metodo sovrascritto deve avere stesso nome e stessa lista parametri e tipo di ritorno(firma)
        public override void Descrizione()
        {
            Console.WriteLine($"Sono un manuale e ho il titolo: {base.Titolo}");
        }

        public void MostraConsigliato()
        {
            if (!Consigliato) {
                Console.WriteLine("Non è consigliato.");
                return;
            }

            Console.WriteLine("E' consigliato");
        }
    }
}
