﻿#region first

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




