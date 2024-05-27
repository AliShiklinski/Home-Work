using Task_1_05._26._2024;

namespace Task_1_05._26._2024
{
    internal class Program
    {
 
    public static void Main()
        {
            User user = new User();

            Console.Write("Enter your name: ");
            user.Name = Console.ReadLine();

            Console.Write("Enter your password: ");
            user.Password = Console.ReadLine();
        }
    }
}



