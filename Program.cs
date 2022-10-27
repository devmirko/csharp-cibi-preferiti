// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Xml.Schema;

Console.WriteLine("Hello, World!");


//string[] cibiPreferiti = { "Pasta", "Pizza", "Sushi", "Carne", "Panzerotto" };
////lunghezza cibi preferiti
//Console.WriteLine(cibiPreferiti.Length);

//Console.WriteLine("i miei cibi preferiti");

//for (int index = 0; index < cibiPreferiti.Length; index++)
//{

//    Console.WriteLine("numero." + (index + 1) + "=" + cibiPreferiti[index]);

//}

////i miei cibi preferiti e non troppo
//Console.WriteLine("Il mio cibo top" + cibiPreferiti[0]);
//Console.WriteLine("Il mio cibo preferito ma non troppo" + cibiPreferiti[cibiPreferiti.Length - 1]);

////mezza classifica
//if (cibiPreferiti.Length % 2 == 0)
//// Array di lunghezza Pari
//{
//    Console.WriteLine("Il cibo a metà classifica è: " + cibiPreferiti[cibiPreferiti.Length / 2]);
//    Console.WriteLine("il cibo a metà classifica è: " + cibiPreferiti[(cibiPreferiti.Length / 2) - 1]);
//} else {
//    // Array di lunghezza Dispari
//    Console.WriteLine("Il cibo a metà classifica è: " + cibiPreferiti[cibiPreferiti.Length / 2]);

//}



//L’utente inserisce due numeri in successione.
//Il software stampa il maggiore
//prendo il primo numero e lo converto
Console.WriteLine("inserisci il primo numero");
int number1 = Convert.ToInt16(Console.ReadLine());


//prendo il secondo numero e lo converto
Console.WriteLine("inserisci il secondo numero");
int number2 = Convert.ToInt16(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine(number1);
} else {
    Console.WriteLine(number2);
}


//L’utente inserisce due parole in successione.
//Il software stampa prima la parola più corta, poi la parola più lunga
Console.WriteLine("inserisci la prima parola");
string parola1 = Console.ReadLine();

Console.WriteLine("inserisci la seconda parola");
string parola2 = Console.ReadLine();

int stringLength1 = parola1.Length;

int stringLength2 = parola2.Length;

if (stringLength1 > stringLength2)
{
    Console.WriteLine(parola2);
    Console.WriteLine(parola1);



} else {

    Console.WriteLine(parola1);
    Console.WriteLine(parola2);

}


//Il software deve chiedere per 10 volte all’utente di inserire un numero.
//Il programma stampa la somma di tutti i numeri inseriti.

int numberAdd;
int totalAdd = 0;


for (int i = 0; i < 10; i++){

    Console.WriteLine("Inserisci un numero");
    numberAdd = Convert.ToInt16(Console.ReadLine());
    totalAdd +=  numberAdd;

}

Console.WriteLine("La somma dei numeri inseriti è: " + totalAdd);















