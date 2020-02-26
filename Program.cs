using System;

namespace assignment_one
{
    class estimate
    {
        public static void Main(string[] args)
        {   
           //Getting Owners Name
           string dog_owner;
           Console.Write("Enter Owners Name:  ");
           dog_owner = Console.ReadLine();
           
           //Getting Dogs Name 
           string dog_name; //Declaring Object
           Console.Write("Enter Dogs Name: "); //asking for user input
           dog_name = Console.ReadLine(); // getting user input
           
           //Getting Dogs Weight
           string dog_weight;
           Console.Write("Enter Dogs Weight: ");
           dog_weight = Console.ReadLine();

           //Getting Days Of stay
           string dog_stay;
           int dog_nights;     
           Console.Write("Please Enter The number of days the dog is staying:  ");
           dog_stay = Console.ReadLine();
           dog_nights = Convert.ToInt32(dog_stay);

           //Getting User Code
           string dog_code;
           Console.WriteLine(" No Add-On Code N: $75 Per Night | Bathing And Grooming Code A: $169 Per Night | Bathing Only Code C: $112 Dollars Per Night ");
           Console.Write("Please Enter the Code you wish to Recieve: ( N | A | C ):   ");
           dog_code = Console.ReadLine();

           // Declaring Total Amount 
           int total;

           if (dog_code == "N"){
               total = 75 * dog_nights;
               Console.WriteLine("Your Total Estimated Amount is '{0}'", total.ToString());
           }

           else if (dog_code == "A"){
               total = 169 * dog_nights;
               Console.WriteLine("Your Total Estimated Amount is '{0}'", total.ToString());
           }

           else if (dog_code == "C"){
               total = 112 * dog_nights;
               Console.WriteLine("Your Total Estimated Amount is '{0}'", total.ToString());
           }

           else if (dog_code != "N" || dog_code != "A" || dog_code != "C" ){
               Console.WriteLine("Your Total Estimated Amount is Invalid, Because Code Does Not exist, Sorry!");
           }


        }
    }
}
