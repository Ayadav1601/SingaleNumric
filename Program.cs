namespace SingaleNumric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

             if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("NUM35");
            }

           else if(num % 3 == 0)
            {
                Console.WriteLine("NUM3");
            }

            else if(num % 5 == 0)
            {
                Console.WriteLine("NUM5");
            }
             
            else
            {
                Console.WriteLine("You win");
            }
        }
    }
}