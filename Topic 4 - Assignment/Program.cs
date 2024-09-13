namespace Topic_4___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sam Ahrens 09/13/24
            string firstName, lastName, studentID, userName;
            int age, grade;
            double salary, schoolAverage;
            
            
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, what's your name?");
            firstName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(firstName + " is a very nice name.");
            Console.WriteLine();

            Console.WriteLine("So " + firstName + ", how old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine();

            Console.WriteLine("So you're " + age + ", that's not too old at all!");
            Console.WriteLine();

            Console.WriteLine("Can I ask how much you make, " + firstName + "?");
            Console.Write("$");
            Double.TryParse(Console.ReadLine(), out salary);
            Console.WriteLine();

            Console.WriteLine("Wow, " + salary.ToString("C") + "! I hope that's per hour, and not per year!");
            Console.WriteLine();

            Console.WriteLine("Hey " + firstName + ", acn I ask what your last name is?");
            lastName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What about your student ID?");
            studentID = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("And your "



        }
    }
}
