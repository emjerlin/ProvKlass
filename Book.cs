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

        }
        public int Evaluate(){

        }
        public string GetCategory(){

        }
        public string GetName(){

        }
        public bool IsCursed(){

        }
    }
}
