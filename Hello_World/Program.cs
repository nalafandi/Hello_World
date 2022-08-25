namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string stg = "Hello world (using string)";
            Console.WriteLine(stg);
            Console.WriteLine("Enter UserName: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter User Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello " + userName + " Your age is " + age);
        }
    }
}