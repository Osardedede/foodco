using System;
using System.Threading;

string answer;
string number;


int bananaPris = 10;
int bootPris = 25;
int burgerpris = 45;
int sifra;
int pris;
int kr = 100;


bool success = false;
bool funkar = true;
bool funkar2 = true;

while (success != true)
{
    while (funkar != false)
    {
        kr = 100;



        string item = "w";

        Console.WriteLine($"You have {kr}kr");
        while (item != "banana" && item != "boot" && item != "burger")
        {


            Console.WriteLine("Do you want to buy a banana, boot or burger.");
            Console.WriteLine("Banana cost 10 kr , Boot 25 kr and a burger cost 45 kr");
            item = Console.ReadLine();


        }

        Console.WriteLine("How many do you want to buy");
        number = Console.ReadLine();
        success = int.TryParse(number, out sifra);



        if (item == "banana")
        {
            pris = sifra * bananaPris;
        }

        else if (item == "boot")
        {
            pris = sifra * bootPris;

        }
        else
        {
            pris = sifra * burgerpris;
        }




        if (pris > 100)
        {

            Console.WriteLine("You don't have enuth money for that!");
            Console.WriteLine("Try again!");
        }
        else if (pris <= 100)
        {
            kr -= pris;

            Console.WriteLine($"You have {kr} kr left!");

            Console.WriteLine("do you want to buy someting more?");
            answer = Console.ReadLine();

            if (answer == "no" )
            {
                Console.WriteLine("have a nice day");
                Thread.Sleep(1000);
                System.Environment.Exit(0);
            }

            if ( answer == "yes" && kr != 0)
            {
                Console.WriteLine("you don't have more money so you are going to have to leave");
                 Thread.Sleep(1000);
                System.Environment.Exit(0);
            }

            while (funkar2 != false)
            {


                if (answer == "yes")
                {
                    Console.WriteLine($"You have {kr}kr");
                    item = "hej";

                    while (item != "banana" && item != "boot" && item != "burger")
                    {

                        Console.WriteLine("So you want to buy a banana, boot or burger.");
                        Console.WriteLine("Banana cost 10 kr , Boot 25 kr and a burger cost 45 kr");
                        item = Console.ReadLine();
                    }

                    Console.WriteLine("How many do you want to buy?");
                    number = Console.ReadLine();

                    success = int.TryParse(number, out sifra);



                    if (item == "banana")
                    {
                        pris = sifra * bananaPris;

                    }
                    else if (item == "boot")
                    {
                        pris = sifra * bootPris;


                    }
                    else
                    {
                        pris = sifra * burgerpris;
                    }

                    if (pris <= kr)
                    {
                        kr -= pris;
                        Console.WriteLine($"Here is you change. {kr} kr.");
                        Console.WriteLine("have a great day!");
                        Thread.Sleep(1500);
                        funkar2 = false;
                        funkar = false;
                    }

                    if (pris > kr)
                    {

                        Console.WriteLine("You don't have enuth money for that!");
                        Console.WriteLine("Try again!");
                    }

                }
            }
        }
    }
}