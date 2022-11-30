using System;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine("Hello welcome to the buffet for each person it will be 9.99$. We have two drink options water which is free and soda which is 1.99.Due to table size we can only seat parties of 6 or less. How many people will we have today?");
            string customers = Console.ReadLine();
            int x = Int32.Parse(customers);
            double Total_buffets = (x * 9.99);
            double s3 = 1.99;
            double w3 = 0.00;
            int s = 0;
            int w = 0;
            double s2 = (s * s3);
            int w2 = w;
            string drink_order;
            string[] drinks = { "water", "soda" };
            int[] total_customers = { 1, 2, 3, 4, 5, 6 };
            double total = w3 + s2 + Total_buffets;

            while (x <= 6)
            {
                Console.WriteLine($"a table for {x} wonderfull, follow me to your table. Lets get everyone started with some drinks we have water and soda.");



                for (int i = x; i > 0; i--)
                {
                    Console.WriteLine($"Alright customer number {i} what can i get you to drink we have water and soda.", i);
                    drink_order = Console.ReadLine();
                    if (drink_order == "soda")
                    {
                        Console.WriteLine("soda, Wonderfull choice");
                        s++;
                    }
                    else if (drink_order == "water")
                    {
                        Console.WriteLine("water, wonderfull choice");
                        w++;
                    }
                    else
                    {
                        Console.WriteLine("No drinks for you!");
                    }
                }
                Console.WriteLine($"so thats {s} sodas and {w} waters, feel free to grab your food");

                Console.WriteLine($"You total today will be {total}");
                break;

            }
            Console.WriteLine("sorry we can only seat tables of 6 or less");
            break;
        }

    }


}