using JuneHomeWork;
using JuneHomeWork.Helpers;
using static System.Console;

/*
* 1. dopo ogni stampa il programma deve chiedere all'utente se desidera continuare proponendo Y/N come scelta
*    Y -> ripropone all'utente da domanda di inserire il primo numero, poi il secondo ecc...
*      N -> termina il programma
* 2. correggere gli errori nel programma
* 3. fare refactoring separando i ruoli di ogni classe e metodo, utilizzando classi e interfacce
* 4. scrivere gli Unit Test che verifichino
*      I. che la somma dei due numeri sia corretta (ad esempio 5+6 fa 11)
*      II. quando eseguiamo una stampa, questa venga effettivamente invocata
=================================================================================================
*/
string? continueInput = string.Empty;
do
{
    decimal result = UserInput.NumbersToAdd();
    UserInput.PrintResult(result.ToString());
    Write("Do you want to continue? Y/N: ");
    continueInput = ReadLine();
}
while (!String.Equals(continueInput.Trim(), "n", StringComparison.InvariantCultureIgnoreCase));
