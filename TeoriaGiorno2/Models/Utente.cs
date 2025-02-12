using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaGiorno2.Models
{
    internal class Utente
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public void Saluta(string messaggio)
        {
            //if(messaggio != "" && messaggio != null && messaggio != " ")
            //{
            //    Console.WriteLine(messaggio);
            //}
            //else
            //{
            //    Console.WriteLine("Il messaggio ha un formato non corretto!");
            //}

            //if(messaggio == null || messaggio == "" || messaggio == " ")
            //{
            //    Console.WriteLine("Il messaggio ha un formato non corretto!");
            //    //early return;
            //    return;
            //}

            //if (messaggio == null)
            //{
            //    Console.WriteLine("Il messaggio ha un formato non corretto!");
            //    //early return;
            //    return;
            //}

            //if (messaggio == "")
            //{
            //    Console.WriteLine("Il messaggio è vuoto!");
            //    //early return;
            //    return;
            //}

            //if (messaggio == " ")
            //{
            //    Console.WriteLine("Il messaggio contiene solo spazi!");
            //    //early return;
            //    return;
            //}

            Console.WriteLine(messaggio);
        }
    }
}
