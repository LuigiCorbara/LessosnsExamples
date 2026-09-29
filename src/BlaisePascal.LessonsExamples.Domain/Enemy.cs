namespace BlaisePascal.LessonsExamples.Domain
{
    public class Enemy
    {
        // private: modificatore di acesso che indica che la variabile è accessibile solo all'interno della classe
        // int: tipo di dato intero
        // _helath: nome della variabile privata che rappresenta la salute del nemico
        private int _health;

        private const int maxHealth = 100; // costante che rappresenta la salute massima del nemico

        public Enemy() { }
    }
}
