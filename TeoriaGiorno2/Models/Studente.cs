using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaGiorno2.Models
{
    public class Studente
    {
        private int _matricola;
        private string _nome = "simone";
        private string _cognome;
        private string _facolta;

        public int Matricola
        {
            get
            {
                return _matricola;
            }
            set
            {
                _matricola = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }
        }
    }
}
