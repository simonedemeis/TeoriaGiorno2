﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaGiorno2.Models
{
    public class Studente : Persona
    {
        public override void Saluta()
        {
            Console.WriteLine("ciao sono uno studente");
        }
    }
}
