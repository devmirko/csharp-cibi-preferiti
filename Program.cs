// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");


string[] cibiPreferiti = { "Pasta", "Pizza", "Sushi", "Carne", "Panzerotto" };
//lunghezza cibi preferiti
Console.WriteLine(cibiPreferiti.Length);

Console.WriteLine("i miei cibi preferiti");

for (int index = 0; index < cibiPreferiti.Length; index++)
{

    Console.WriteLine("numero." + index + "=" + cibiPreferiti[index]);

}

//i miei cibi preferiti e non troppo
Console.WriteLine("Il mio cibo top" + cibiPreferiti[0]);
Console.WriteLine("Il mio cibo preferito ma non troppo" + cibiPreferiti[4]);




