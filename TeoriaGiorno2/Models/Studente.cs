using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaGiorno2.Models
{
    public class Studente : Persona
    {
        public override string Nome { get; set; }
        public override string Cognome { get; set; }

        public override void Saluta()
        {
            Console.WriteLine("ciao");
        }
    }
}
