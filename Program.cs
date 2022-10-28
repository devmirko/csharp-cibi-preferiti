// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
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

//Calcola la somma e la media dei numeri da 2 a 10.
int[] numeri = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sum = 0;
int average;

for (int i = 0; i < numeri.Length; i++)
{
    //somma dei numeri
    sum += numeri[i];

}

//media dei numeri
average = sum / numeri.Length;

Console.WriteLine("la somma dei numeri è " + sum);
Console.WriteLine("la media dei numeri è " + average);


// Il software chiede all’utente di inserire un numero. Se il numero inserito è pari,
// stampa il numero, se è dispari, stampa il numero successivo
int numberUser = Convert.ToInt16(Console.ReadLine());
int nextNumber = numberUser + 1;

if (numberUser % 2 == 0)
{
    Console.WriteLine(numberUser);
}
else {
    Console.WriteLine(nextNumber);
}

//in un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
//Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla
//festa

string[] invitatiFesta = { "paolo", "michele", "fabrizio", "gino", "lorenzo", "patrice" };

string invitato = Console.ReadLine();

int index = Array.IndexOf(invitatiFesta, invitato);

if (index > -1)
{
    Console.WriteLine("{0} Sei stato invitato", invitato);
}
else
{
    Console.WriteLine("Non sei stato invitato");
}


//Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo
//nell’array
int[] arrayVuoto = new int[6];
int index_ = 0;
for (int i = 0; i < arrayVuoto.Length; i++)
{
    Console.WriteLine("Inserisci un numero");
    int numero = Convert.ToInt16(Console.ReadLine());
    if(numero % 2 != 0) {
        arrayVuoto[index_] = numero;
        index_++;
    } 

}

//Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in
//posizione dispari
int[] numeriSomma = { 1, 2, 3, 4, 5, 6, 7, 8 };
int sommaNum = 0;

for (int i = 0; i < numeriSomma.Length; i += 2)
{
    sommaNum += numeriSomma[i];
}

Console.WriteLine("La somma è: " + sommaNum);

//Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
//Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la
//somma degli elementi è minore di 50;
int somma = 0;
while (somma < 50)
{
    Console.WriteLine("Inserisci un numero");
    somma += Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("La somma è: " + somma);
}























