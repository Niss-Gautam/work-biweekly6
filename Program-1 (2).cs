using System;

namespace SydneyCoffee
{
    class Program
    {
        Program(){
            // Declaring N and allocating a value clone with sijan
            int n = 4;

            // declaring arrays to store data
            String[] name = new string[n];
            int[] quantity = new int[n];
            String[] reseller = new string[n];
            double[] charge = new double[n];
            double price;
            double min = 9999999;
            String minName = "";
            double max = -1;
            String maxName = "";
        }
        public: void userinput(){
            // Loop to get the inputs
            for (int i = 0; i < n; i++)            {
                Console.Write("Enter customer name: ");
                name[i] = Console.ReadLine();
                quantity[i] = 0;
                // The loop will continue whenever the entered value is out of range changing some in comments
                do
                {
                    Console.Write("Enter the number of coffee beans bags (bag/1kg): ");
                    quantity[i] = Convert.ToInt32(Console.ReadLine());

                    if (quantity[i] < 1 || quantity[i] > 200)
                    {
                        Console.WriteLine("Invalid Input!\nCoffee bags between 1 and 200 can be ordered.");
                    }
                } while (quantity[i] < 1 || quantity[i] > 200);
        }
        public: void calculate(){
            
                // determining the price
                if (quantity[i] <= 10)
                {
                    price = 36 * quantity[i];
                }
                else if (quantity[i] <= 15)
                {
                    price = 34.5 * quantity[i];
                }
                else
                {
                    price = 32.7 * quantity[i];
                }

                Console.Write("Enter yes/no to indicate whesther you are a reseller: ");
                reseller[i] = Console.ReadLine();

                if (reseller[i] == "yes")
                {
                    // 20% discount
                    charge[i] = price * 0.8;
                }
                else
                {
                    charge[i] = price;
                }
        }
        public: void output(){
            
                Console.WriteLine(String.Format("The total sales value from {0} is ${1}", name[i], charge[i]));
                Console.WriteLine("-----------------------------------------------------------------------------");

                // finding max min value
                if (min > charge[i])
                {
                    min = charge[i];
                    minName = name[i];
                }

                if (max < charge[i])
                {
                    max = charge[i];
                    maxName = name[i];
                }
            }

            // summary heading
            Console.WriteLine("\t\t\t\t\tSummary of sales\n");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------");

            // displaying table header
            Console.WriteLine(String.Format("{0,15}{1,10}{2,10}{3,10}",
                        "Name", "Quantity", "Reseller", "Charge"));

            // displaying table data
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(String.Format("{0,15}{1,10}{2,10}{3,10}",
                       name[i], quantity[i], reseller[i], charge[i]));
            }
            
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine(String.Format("The customer spending most is {0} ${1}", maxName, max));
            Console.WriteLine(String.Format("The customer spending least is {0} ${1}", minName, min));

        }
        static void Main(string[] args)
        {
           // Welcome message
            Console.WriteLine("\t\t\t\tWelcome to use Sydney Coffee Program\n");
            Program p= new Program();
            p.userinput();
            p.calculate();
            p.output();
        
            
        }
    }
}
