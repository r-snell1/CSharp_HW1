using System;

namespace Chapter1
{

    class Chapter1
    {
        
        public static void Main()
        {

            PersonalInfo();
            Lyrics();

        }//end main
        static void PersonalInfo()
        {
            string name = "Ryan Snell";
            string birthday = "06 Dec 1982";
            string cellPhoneNumber = "4041441-3523";
            
            Console.WriteLine(name + " " + birthday + " " + cellPhoneNumber);
            
        }//end method

        static void Lyrics()
        {
            
            Console.WriteLine("Do you have the time, to listen to me whine?");
            Console.WriteLine("about nothing and everything all at once.");
            Console.WriteLine("I am one of those, melodramtic fools,");
            Console.WriteLine("neurotic to the bone.");
            
        }
    }//end class
    
}//end namespace

