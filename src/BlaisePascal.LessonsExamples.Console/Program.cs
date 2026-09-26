public class Program //This is a class
{
    // Entry method for the execution of the code
    public static void Main()
    {
        

        Console.WriteLine("Insert client name");

        // Console.ReadLine() allow me to read the user's input frome the console
        // After that, I can assign the value to a clientName
        string clientName = Console.ReadLine(); // dichiarazione + assegnazione

        Console.WriteLine($"Welcome,{clientName}, in the BibbyFlex library");
        
        Console.WriteLine("Insert he delivery type");

        string deliveryType = Console.ReadLine(); // dichiarazione + assegnazione

        Console.WriteLine("Insert the number of buought package");

        int packageNumber = int.Parse(Console.ReadLine());


        int singlePackageDeliveryCost = 5; // Declaration
        singlePackageDeliveryCost = 10; // Allocation

        int totalCost = singlePackageDeliveryCost * packageNumber;

        // Stampa a video con concatenazione di stringhe e variabili
        // $ è un carattere speciale per l'interpolazione di stringhe
        // che permette di inserire variabili all'interno di una stringa di messaggio
        Console.WriteLine($"The selected delivery type is: {deliveryType} and the total cost is: {totalCost}");

    }
}
