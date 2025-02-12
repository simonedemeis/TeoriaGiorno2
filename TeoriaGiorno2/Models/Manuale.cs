using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaGiorno2.Models
{
    public class Manuale
    {
        public static string Argomento { get; set; }

        //public Manuale(string titolo, string autore, string argomento) : base(titolo, autore) 
        //{  
        //    Argomento = argomento; 
        //}
        //il metodo sovrascritto deve avere stesso nome e stessa lista parametri e tipo di ritorno (firma)
        //public void Descrizione()
        //{ 
            
        //    Console.WriteLine($"Sono un manuale e ho il titolo: {base.Titolo}");
        //}

        public static void MostraArgomento()
        {
            Console.WriteLine(Argomento);
        }
    }
}
