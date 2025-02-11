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
            set
            {
                _nome = value;
            }
        }

        public string Cognome { get; set; }


        public void StampaInfo()
        {
            Console.WriteLine("Ciao a tutti sono uno studente");
        }

        public string NomeCompleto()
        {
            return _nome + " " + Cognome;
        }

        public void MostraMessaggio(string messaggio, string nome = "Simone")
        {
            Console.WriteLine(messaggio);
            Console.WriteLine(nome);
        }

        public void MostraMessaggio(string messaggio)
        {
            var messaggioMaiuscolo = messaggio.ToUpper();
            Console.WriteLine(messaggioMaiuscolo);
        }
    }
}
