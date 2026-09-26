public class Program //This is a class
{
    // Entry method for the execution of the code
    public static void Main()
    {
        Console.WriteLine("Welcome in the BibbyFlex library");

        int singlePackageDeliveryCost = 5; // Declaration
        singlePackageDeliveryCost = 10; // Allocation

        int packageNumber = 2;

        string deliveryType = "Standard"; // Declaratiom

        int totalCost = singlePackageDeliveryCost * packageNumber;

        // Stampa a video con concatenazione di stringhe e variabili
        // $ è un carattere speciale per l'interpolazione di stringhe
        // che permette di inserire variabili all'interno di una stringa di messaggio
        Console.WriteLine($"The selected delivery type is: {deliveryType} and the total cost is: {totalCost}");

    }
}
