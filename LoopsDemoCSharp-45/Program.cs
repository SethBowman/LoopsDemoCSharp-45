namespace LoopsDemoCSharp_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While loop
            Console.WriteLine("WHILE LOOP:");

            var cont = "yes";

            while(cont == "yes")
            {
                Console.WriteLine("Continue? (Type 'yes' or 'no')");
                cont = Console.ReadLine();
            }


            var numb = 0;

            while(numb <= 5)
            {
                Console.WriteLine(numb);
                numb++;
            }

            //Do while loop
            Console.WriteLine("DO WHILE LOOP:");

            var num = 0;

            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 5);

            //For loop
            Console.WriteLine("FOR LOOP:");

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} is the number we are on.");
            }

            Console.WriteLine("------");

            for(int i = 10; i >= 1; i--) 
            {
                Console.WriteLine($"{i} is the number we are on.");
            }


            //Foreach loop
            Console.WriteLine("FOREACH LOOP:");

            var numbers = new int[] { 22, 3, 444, 500, 12 };

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
