using System;

namespace ProvKlass
{
    public class Books
    {
        public int price;
        string name;
        bool cursed;
        int rarity;
        string category;
        int actualValue;
        Random generator = new Random();

        List<string> bookNames = new List<string>(){"Ex Altiora", "The Boneturner's Tale", "The Key of Solomon", "Biggest Mistake","Winnie The Pooh","Fazbear Frights"};
        //spelaren kan lägga till namn på böcker i denna
        List<string> cathegoryList = new List<string>(){"Mystery", "Romance", "Occult","Autobiography"};
        public Book(){
            actualValue = generator.Next(1,101);
            rarity = generator.Next(1,11);
            int b = generator.Next(2);
            if (b = 0){
                cursed = true;
            }
            else{
                cursed = false;
            }

            
        }
        public void PrintInfo(){
            Console.WriteLine(name);
            Console.WriteLine("Rarity level: " + rarity);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Price: " + price);
        }
        public int Evaluate(){
            int rightPrice = actualValue * rarity;
            float r = generator.Next(0.5,1.5);

            int evaluatedPrice = rightPrice * r;

            return evaluatedPrice;

            
        }
        public string GetCategory(){
            return Console.WriteLine("Category: " + category);
        }
        public string GetName(){
            return Console.WriteLine("Name of book:" + name);
        }
        public bool IsCursed(){
            bool curseCheck;
            int r = generator.Next(5); 
            //Då det är 1/5 chans att det inte är rätt svar som den returnerar, om random = 0 då returnerar den motsatta värdet dvs fel
            if (r = 0){
                curseCheck = !cursed;
                //gör att curseCheck är motsatsen av vad cursed faktiskt är
            }
            else{
                curseCheck = cursed;
            }
            return curseCheck;
        }
    }
}
