using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                //intro+firstName block
                Console.WriteLine("Hello there, I am the legendary fortune teller \"Zolthar2.0 the even more All-Knowing!!\"\n");
                Console.WriteLine("\n\n\nPlease.....tell Zolthar2.0, what is your first name?");
                string firstName = Console.ReadLine();
                if (firstName.ToUpper() == "QUIT")
                {
                    Console.WriteLine("Goodbye");
                    break;

                }
                else if (firstName.ToUpper() == "RESTART")
                {
                    Console.WriteLine("Restarted");
                    continue;
                }

                //lastname block
                Console.WriteLine("\nYes, that's right. " + firstName + "." + "\nZolthar aleady knew your first name....just wanted to be sure.\n");
                Console.WriteLine("BUT....... what is your last name?");
                string lastName = Console.ReadLine();
                if (lastName.ToUpper() == "QUIT")
                {
                    Console.WriteLine("Goodbye");
                    break;

                }
                else if (lastName.ToUpper() == "RESTART")
                {
                    Console.WriteLine("Restarted");
                    continue;
                }

                Console.WriteLine("\n\n\n");
                Console.WriteLine(Greeting(firstName, lastName));

                //age/retire age block
                Console.WriteLine("\nWhat is your age?");

                string retireAge = Console.ReadLine();
                if (retireAge.ToUpper() == "QUIT")
                {
                    Console.WriteLine("Goodbye");
                    break;

                }
                else if (retireAge.ToUpper() == "RESTART")
                {
                    Console.WriteLine("Restarted");
                    continue;

                }
                int retire = RetireAge(int.Parse(retireAge));

                //birthMonth/money block
                Console.WriteLine("\nReally? Zolthar thought you were younger than that.......\n");
                Console.Write("...and what is the number of your birth month?\n(numeric answers only: 1-12)\n");
                string strBirthMonth = Console.ReadLine();
                if (strBirthMonth.ToUpper() == "QUIT")
                {
                    Console.WriteLine("Goodbye");
                    break;

                }
                else if (strBirthMonth.ToUpper() == "RESTART")
                {
                    Console.WriteLine("Restarted");
                    continue;

                }
                double doubleMonth = BirthMonth(int.Parse(strBirthMonth));



                //ROYGBIV/transportation block. Input is sent .ToUpper. 
                Console.WriteLine("\nWhat is your favorite ROYGBIV color? \nIf you do not know what an ROYGBIV color is, please enter 'HELP' so that Zolthar can assist you.");
                string color = RoyG(Console.ReadLine().ToUpper());
                if (color.ToUpper() == "QUIT")
                {
                    Console.WriteLine("Goodbye");
                    break;

                }
                else if (color.ToUpper() == "RESTART")
                {
                    Console.WriteLine("Restarted");
                    continue;
                }
                if (RoyG(color) == "HELP")
                {
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, or Violet");
                    color = RoyG(Console.ReadLine().ToUpper());

                    if (color.ToUpper() == "QUIT")
                    {
                        Console.WriteLine("Goodbye");
                        break;

                    }
                    else if (color.ToUpper() == "RESTART")
                    {
                        Console.WriteLine("Restarted");
                        continue;
                    }

                }
                //Siblings/vacation home block. 
                Console.WriteLine("\nNow enter the numeric value of siblings do you have:\n\n Press 44 to quit. 55 to restart.");

                string vacationHome = SibNum(int.Parse(Console.ReadLine()));
                if (vacationHome == "QUIT")
                {
                    Console.WriteLine("Goodbye");
                    break;

                }
                else if (vacationHome == "RESTART")
                {
                    Console.WriteLine("Restarted");
                    continue;
                }


                //output block
                Console.WriteLine("\n\n\nI'm looking into my crystal ball.....Yes. It's all starting to appear to me.");
                Console.WriteLine("Hit \"ENTER\" for your fortune.");
                Console.ReadLine();


                Console.Write("\n\n\n" + firstName + " " + lastName + " will retire in " + retire + " years with $" + doubleMonth +
                              " in the bank,\na vacation home " + vacationHome + " and a " + color + "\n\n\n");
                Opinion();
                if (Console.ReadLine().ToUpper() == "QUIT")
                {
                    Console.WriteLine("Goodbye");
                    break;


                }
                else if (Console.ReadLine().ToUpper() == "RESTART")
                {
                    Console.WriteLine("Restarted");
                    continue;
                }
                Console.ReadKey();


            }

        }


        static string Greeting(string firstName, string lastName)
        {
            string fullName = "Greetings, " + firstName + " " + lastName + ". I will tell your fortune!";
            return fullName;
        }

        static int RetireAge(int age)
        {
            int retire = age % 2;

            switch (retire)
            {
                case 0:
                    retire = 32;
                    break;
                case 1:
                    retire = 15;
                    break;
                default:
                    retire = 100000;
                    break;
            }
            return retire;
        }


        static string SibNum(int siblings)
        {
            string vacationHome = "";
            if (siblings >= 0)
            {
                if (siblings == 0)
                {
                    vacationHome = "in London,";
                }
                else if (siblings == 1)
                {
                    vacationHome = "on the coast of Maine,";
                }
                else if (siblings == 2)
                {
                    vacationHome = "in Sao Paulo, Brazil,";
                }
                else if (siblings == 3)
                {
                    vacationHome = "in the the Dutch Alps,";
                }
                else if (siblings > 3 && siblings <= 43)
                {
                    vacationHome = "in Sidney, Austraila,";
                }
                else if (siblings == 44)
                {
                    vacationHome = "QUIT";
                }
                else if (siblings == 55)
                {
                    vacationHome = "RESTART";
                }
            }
            else
            {
                vacationHome = ".....well, really it's just a timeshare\n.....in Cleveland.....in the winter,";
            }
            return vacationHome;

        }



        static double BirthMonth(int birthMonth)
        {
            if (birthMonth <= 12 && birthMonth >= 1)
            {
                if (birthMonth <= 12 && birthMonth >= 9)
                {
                    birthMonth = -33000;
                }
                else if (birthMonth <= 8 && birthMonth >= 5)
                {
                    birthMonth = 90000;
                }
                else if (birthMonth <= 4 && birthMonth >= 1)
                {
                    birthMonth = 42000000;
                }
            }
            else
            {
                birthMonth = 0;
            }
            double doubleMonth = birthMonth;
            return doubleMonth;
        }


        static void Opinion()
        {

            Console.WriteLine("Yes......A very stange fortune indeed. Goodbye my friend.");
        }

        static string RoyG(string color)
        {
            string ride = "";



            if (color == "RED")
            {
                ride = "an old hippie van that smells of music \nfestivals long since passed.";
            }

            else if (color == "ORANGE")
            {
                ride = "1969 Dodge Dart \nwith a 340 and NOS in the trunk.";
            }
            else if (color == "YELLOW")
            {
                ride = "dilapidated old unicycle.";
            }

            else if (color == "GREEN")
            {
                ride = "Abrhams A-1 tank. \nIt's going to be an interesting retirement.";
            }

            else if (color == "BLUE")
            {
                ride = "broken down \nmonster truck?(hey at least you went big right?)";
            }

            else if (color == "INDIGO")
            {
                ride = "chaufer-driven \nstretch limosine(you corporate bourgie swine you....)";
            }
            else if (color == "VIOLET")
            {
                ride = "straight up ballin' Cadillac \nfrom the 70's, you ARE that stylin' old guy.";
            }
            else if (color == "HELP")
            {
                ride = "HELP";
            }
            else if (color == "QUIT")
            {
                ride = "QUIT";
            }
            else if (color == "RESTART")
            {
                ride = "RESTART";
            }
            else
                ride = "......you're rolling around in a squeaky shopping cart.";
            return ride;

        }
    }


}










