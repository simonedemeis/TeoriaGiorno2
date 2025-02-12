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
            //string res = "";

            //switch (messaggio)
            //{
            //    case "":
            //        res = "Il messaggio è vuoto!";
            //        Console.WriteLine(res);
            //        break;
            //    case " ":
            //        Console.WriteLine("Il messaggio contiene solo spazi!");
            //        break;
            //    default:
            //        Console.WriteLine("Condizione di default");
            //        break;
            //}

            //var result = messaggio switch
            //{
            //    "" => "Il messaggio è vuoto!",
            //    " " => "Il messaggio contiene solo spazi!",
            //    _ => "default"
            //};

            //Console.WriteLine(result);

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
