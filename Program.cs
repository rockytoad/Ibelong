using System;

namespace งงโว้ย
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            string letter;
            double NA, CL, O2, R1, R2, R3, a, s, d;
            bool CIA, NSA, FBI;

            Console.Write("Insert your agency name : ");
            letter = Console.ReadLine();
            Console.Write("Insert your ID : ");
            number = double.Parse(Console.ReadLine());


            if (letter == "CIA")
            {
                NA = number % 10 % 3;
                CL = number % 100 / 10;
                O2 = number % 10000 / 1000;
                CIA = (NA == 0) && ((CL != 1) && (CL != 3) && (CL != 5)) && (O2 >= 6 && O2 != 8);
                Console.WriteLine(CIA);
            }
            else if (letter =="FBI")
            {
                NA = number % 1000000 / 100000;
                CL = number % 1000 / 100;
                O2 = number % 100000 / 10000;
                FBI = (NA >= 4 && NA <= 7) && (CL != 6 && CL % 2 == 0) && (O2 % 3 == 0 || O2 % 1 == 0 );
                Console.WriteLine(FBI);
            }
            else if (letter == "NSA")
            {
                NA = number % 10;
                CL = number % 1000 / 100;

                R1 = number % 100 / 10;
                R2 = number % 1000 / 100;
                R3 = number % 10000 / 1000;
                a = number % 100000 / 10000;
                s = number % 1000000 / 100000;
                    NSA = (30 % NA == 0) && ((CL % 3 == 0) && (CL % 2 != 0)) && ((NA == 7) || (R1 == 7) || (R2 == 7) || (R3 == 7) || (a == 7) || (s == 7));
                Console.WriteLine(NSA);

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
