using TeoriaGiorno2.Models;

Studente studente1 = new Studente()
{
    Matricola = 246796
};

Console.WriteLine(studente1.Nome);

studente1.Cognome = "De Meis";

Console.WriteLine(studente1.Cognome);

studente1.StampaInfo();

var nomeCompleto = studente1.NomeCompleto();

Console.WriteLine(nomeCompleto);

studente1.MostraMessaggio("messaggio");





