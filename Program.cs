using System;

namespace _1st_app
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 101;
            Boolean flag=true;
            int tries = 0;
            String answr;
            Random rnd = new Random();
            Console.WriteLine("Σκέψου έναν αριθμό΄από το 1-100 και θα προσπαθήσω να τον βρώ.");
            Console.WriteLine("Παρακαλώ απάντησε με Y για ναί και N για όχι.");
            Console.WriteLine("Όταν είσαι έτοιμος, πάτα ένα πλήκτρο");
            Console.ReadLine();
            do
            {
                tries++;
                int n = rnd.Next(min, max);
                Console.WriteLine("Μήπως σκέφτηκες το " + n);
                answr = Console.ReadLine();
                while (answr != "N" && answr != "Y")
                {
                    Console.WriteLine("Δεν μπορώ να καταλάβω την απάτηση σου. Ξαναπροσπάθησε: ");
                    answr = Console.ReadLine();
                }
                if (answr == ("Y"))
                {
                    flag = false;
                    Console.WriteLine("Τέλεια, το παιχνίδι τελείωσε. Το βρήκα με την " + tries + " προσπάθεια!");
                    Console.WriteLine("Πάτησε ένα πλήκτρο για να κλείσεις το παιχνίδι");
                }
                else
                {
                    Console.WriteLine("Ο αριθμός σου είναι μεγαλύτερος από το " + n + ";");
                    answr = Console.ReadLine();
                    while (answr != "N" && answr != "Y")
                    {
                        Console.WriteLine("Δεν μπορώ να καταλάβω την απάτηση σου. Ξαναπροσπάθησε: ");
                        answr = Console.ReadLine();
                    }
                    if (answr == "Y")
                    {
                        min = n;
                    }
                    else
                    {
                        max = n;
                    }
                }

            } while (flag);
            Console.ReadLine();
            Environment.Exit(0);

        }
    }
}
