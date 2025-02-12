using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaGiorno2.Models
{
    public abstract class Persona
    {
        public abstract string Nome { get; set; }
        public abstract string Cognome { get; set; }

        public abstract void Saluta();
    }
}
