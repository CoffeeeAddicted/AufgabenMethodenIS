using System;

namespace AufgabenMethodenIS
{
    class Program
    {
        public int coordinateX;
        public int coordinateY;

        // Aufgabe 1 - Give your name, it will be stored in a int, if you don't, then guet "anonymous" tag
        static void IntroduceYourself(string userName)
        {
            
            Console.WriteLine("Your name is " + userName + "\n" + "Thanks for letting me know!" + "\n");
            
        }

        // Aufgabe 2 - summ every time you call the method
        static int WeSumm(params int[] numbers)
        {
            int weAdd = 0;
            foreach (int number in numbers)
            {
                weAdd += number;
            }

            return weAdd;

        }

        //Aufgabe 3 - use overloading two multiply 2 or 3 factors together
        static double WeMultiply(double a, double b)
        {
            return a * b;
        }

        static double WeMultiply(double a, double b, double c)
        {
            return a * b * c;
        }

        static void Main(string[] args)
        {
            

            Console.WriteLine("Aufgabe 1 - Pls tell me your name, stranger!");
            string yourName = Console.ReadLine();
            IntroduceYourself(yourName);

            Console.ReadKey();

            Console.WriteLine("Aufgabe 2 - this is the sum of (1, 2, 3, 4):" + "\n");
            // numbers vanish after they do their job??
            Console.Write(WeSumm(1, 2, 3, 4));

            Console.ReadKey();

            Console.WriteLine("Aufgabe 3 - these are the products of (1, 2) and (1, 2, 3)" + "\n");
            double factors1 = WeMultiply(1, 2);
            double factors2 = WeMultiply(1, 2, 3);
            Console.WriteLine(Convert.ToString(factors1));
            Console.WriteLine(Convert.ToString(factors2));

            Console.ReadKey();

        }
    }
}
