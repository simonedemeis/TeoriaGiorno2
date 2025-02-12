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
//using TeoriaGiorno2.Models;

//int numero1 = 5;
//int numero2 = numero1;

//Studente studente2 = new Studente()
//{
//    Matricola = 246796
//};

//var studente4 = new Studente();

//Studente studente3 = studente2;

//studente3.Matricola = 333333;

//Console.WriteLine(studente2.Matricola);
//Console.WriteLine(studente3.Matricola);

//var nome = "true";

//Console.WriteLine(nome);

//var numero5 = 5.0m;
#endregion

#region third

//int[] numbers = { 1, 2, 3, 4, 5, 6 };

//foreach(int number in numbers)
//{
//    Console.WriteLine(number);
//}

//for (int i = 0; i <= numbers.Length - 1; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//int counter = numbers.Length - 1;

//while(counter >= 0)
//{
//    Console.WriteLine(numbers[counter]);
//    counter--;
//}

//do
//{
//    Console.WriteLine(numbers[counter]);
//    counter--;
//}
//while (counter >= 0);

//List<string> words = new List<string>();

//words.Add("1");
//words.Remove("2");
//words.Clear();

//Console.WriteLine(words.Count);

//List<int> numbers = new List<int>() { 1, 2, 3, 6, 12, 20, 40 };

//Definiamo una lista di appoggi perchè non possiamo modificare la lista originale durante i cicli iterativi, pena eccezioni o errori di calcolo.
//List<int> filteredNumbers = new List<int>();

//for (int i = 0; i <= numbers.Count - 1; i++)
//{
//    if (numbers[i] <= 6)
//    {
//        filteredNumbers.Add(numbers[i]);
//    }
//}

//numbers = filteredNumbers;

//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}

//foreach (int numero in numbers)
//{
//    Console.WriteLine(numero);
//}

//Dictionary<Guid, string> utenti = new Dictionary<Guid, string>();

//utenti.Add(Guid.NewGuid(), "Simone");
//utenti.Add(Guid.NewGuid(), "Mario");

//foreach (int key in utenti.Keys)
//{
//    Console.WriteLine(key);
//}

//foreach (string value in utenti.Values)
//{
//    Console.WriteLine(value);
//}

//List<Utente> newList = new List<Utente>();

//foreach (var utente in utenti)
//{
//    newList.Add(
//        new Utente() { Id = utente.Key, Name = utente.Value}
//        );
//}

//foreach (var utente in newList)
//{
//    Console.WriteLine(utente.Id);
//    Console.WriteLine(utente.Name);
//}

#endregion


using TeoriaGiorno2.Models;

//Libro libro1 = new Libro();

//Libro manuale = new Manuale();

//Manuale manuale2 = new Manuale();

//manuale.Descrizione();

//Manuale manuale = new Manuale("Un titolo", "Un autore", "OOP");

//manuale.Descrizione();

Utente utente1 = new Utente();


Manuale.Argomento = "OOP";

Manuale.MostraArgomento();

