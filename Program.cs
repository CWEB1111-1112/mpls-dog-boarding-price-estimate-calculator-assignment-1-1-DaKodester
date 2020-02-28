using System;

namespace assignment_one
{
    public class program
    {
        public static void Main(string[] args)
        {  

           estimate one = new estimate(); 
 
           Console.WriteLine("Enter Owners Name:  ");
           one.dog_owner = Console.ReadLine();
           
           //Getting Dogs Name 
           Console.Write("Enter Dogs Name: "); //asking for user input
           one.dog_name = Console.ReadLine(); // getting user input
           
           //Getting Dogs Weight
           Console.Write("Enter Dogs Weight: ");
           one.dog_weight = Console.ReadLine();

           //Getting Days Of stay
    
           Console.Write("Please Enter The number of days the dog is staying:  ");
           one.dog_stay = Console.ReadLine();
           one.dog_nights = Convert.ToInt32(one.dog_stay);

           //Getting User Code
           Console.WriteLine(" No Add-On Code N: $75 Per Night | Bathing And Grooming Code A: $169 Per Night | Bathing Only Code C: $112 Dollars Per Night ");
           Console.Write("Please Enter the Code you wish to Recieve: ( N | A | C ):   ");
           one.dog_code = Console.ReadLine();

           if (one.dog_code == "N"){
               one.total = 75 * one.dog_nights;
               Console.WriteLine("Your Total Estimated Amount is '{0}'", one.total.ToString());
           }

           else if (one.dog_code == "A"){
               one.total = 169 * one.dog_nights;
               Console.WriteLine("Your Total Estimated Amount is '{0}'", one.total.ToString());
           }

           else if (one.dog_code == "C"){
               one.total = 112 * one.dog_nights;
               Console.WriteLine("Your Total Estimated Amount is '{0}'", one.total.ToString());
           }

           else if (one.dog_code != "N" || one.dog_code != "A" || one.dog_code != "C" ){
               Console.WriteLine("Your Total Estimated Amount is Invalid, Because Code Does Not exist, Sorry!");
           }


        }

    }
    public class estimate
    {
        public string dog_owner {get; set;}

        public string dog_name {get; set;}

        public string dog_weight {get; set;}

        public int dog_nights {get; set;}

        public string dog_stay {get; set;}

        public string dog_code {get; set;}

        public int total {get; set;}
    }
}
