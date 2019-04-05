using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            //string selection = "";
            string Temp = "";
            do
            {
                Console.WriteLine("Would you like the value converted to Celsius(C) or Fahrenheit(F)?" + "Enter C or F");
                input = Console.ReadLine();

                Console.WriteLine("Enter a temperature: ");
                Temp = Console.ReadLine();
                 
                 if (input == "C")
                 {
                    double Celsius = (double.Parse(Temp) - 32) * 5 / 9;
                    Console.WriteLine($"Celsius Temperature: {Celsius}C");
                    continue;
                 }

                else if (input == "F")
                {
                    double Fahrenheit = (double.Parse(Temp) * 9 / 5) + 32;
                    Console.WriteLine($"Fahrenheit Temperature: {Fahrenheit}F");
                    continue;
                }
                
            } while (input != "Exit");
        }
    }
}
    


                      
          
       
           
                
                            
        
    
    

