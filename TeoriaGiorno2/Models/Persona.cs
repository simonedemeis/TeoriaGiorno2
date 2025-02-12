using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaGiorno2.Models
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public virtual void Saluta()
        {
            Console.WriteLine("ciao sono una persona");
        }
        public void Cammina()
        {
            Console.WriteLine("Sto camminando");
        }
    }
}
