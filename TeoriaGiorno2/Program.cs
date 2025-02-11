#region first

//using TeoriaGiorno2.Models;

//Studente studente1 = new Studente()
//{
//    Matricola = 246796,
//    Cognome = "De Meis"
//};

//Console.WriteLine(studente1.Nome);

//studente1.Cognome = "De Meis";

//Console.WriteLine(studente1.Cognome);

//studente1.StampaInfo();

//var nomeCompleto = studente1.NomeCompleto();

//Console.WriteLine(nomeCompleto);

//studente1.MostraMessaggio("messaggio");

#endregion

#region second
using TeoriaGiorno2.Models;

int numero1 = 5;
int numero2 = numero1;

Studente studente2 = new Studente()
{
    Matricola = 246796
};

var studente4 = new Studente();

Studente studente3 = studente2;

studente3.Matricola = 333333;

Console.WriteLine(studente2.Matricola);
Console.WriteLine(studente3.Matricola);

var nome = "true";

Console.WriteLine(nome);

var numero5 = 5.0m;
#endregion


