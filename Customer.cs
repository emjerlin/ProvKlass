using System;

namespace ProvKlass
{
    public class Customers
    {
        public List<string> OwnedBooks = new List<string>();

        int budget;

        string interest;

        public string GetOwned(){
            for (int i = 0; i < OwnedBooks.length; i++)
            {
               return Console.WriteLine(OwnedBooks(i));
            }
            
        }
         public int AskBudget(){
            //gör en estimate på vad de kan tänka sig att betala - om de kan betala lite, mellan, eller mycket (deras budget kommer passa in i 1 av 3 if satser). 
            //Om ditt pris som du sedan föreslår går för mycket under denna budget kommer 
            //customer antingen bli arg för de tror att de är fattiga / inte kunna betala och tycka ni är för dyra och gå därifrån
        }
        public bool Deal(){
            //Avgör om customer kommer att köpa boken. Den kommer att jämföra ditt pris med budgeten, om den är för hög eller ALDELES för låg från budgeten
            //kommer customer ej att köpa. Om det är en genre (interest) som den inte är intresserad av är det bara 20% chans att de köper den. 
            //
        }
       
    }
}
