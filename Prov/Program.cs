using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();//Visual studio är sur det här ska funka :(   )
            int game = 1;
            Console.WriteLine("It's a new day.. Before heading to work, you go past your favorite reseller of books! Maybe you could find something for your antiquary here..?");
            Console.WriteLine("Is that..? Yes it is! It's the book you've been looking for, it's...");
            Console.WriteLine("[Please come up with a name for the book you found]");

            string x = Console.ReadLine();

            Console.WriteLine("Nice! You found ´" + x + "´ and it isn't even after noon yet!");
            while(game == 1){
            Console.WriteLine("[Write ]");
            //skulle ge instruktioner om hur man skulle kunna köpa böcker, och kunna se ungefärligt värde

// Kunna ge möjlighet för spelare att Evaluata pris av bok, gissa curse, visa rarity och visa category

            Console.WriteLine("Set a price for the book you just bought");
            string i = Console.ReadLine();
            int o;
            bool lyckad = int.TryParse(i, out o);
            b1.price = o;
            } //sätter pris på din bok, alltså det du kommer att sälja boken för. Inte affected by ActualPrice




        }
    }
}
