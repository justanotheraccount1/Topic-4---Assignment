namespace Topic_4___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sam Ahrens 09/13/24
            string firstName, lastName, studentID, userName;
            int age, grade, ageIn5, ageLast5;
            double salary, schoolAverage, num1, num2, num3, numAvg, numTotal;
            
            
            
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

            Console.WriteLine("Hey " + firstName + ", can I ask what your last name is?");
            lastName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What about your student ID?");
            studentID = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("And your Username?");
            userName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What grade are you in?");
            Int32.TryParse(Console.ReadLine(), out grade);
            Console.WriteLine();

            Console.WriteLine("What is your average grade in school?");
            Double.TryParse(Console.ReadLine(), out schoolAverage);
            Console.WriteLine();

            Console.WriteLine("HaHa! I HAVE STOLEN ALL OF YOUR PERSONAL INFORMATION! " +
                "I AM THE HACKER MAN!!!");
            Console.WriteLine();

            Console.WriteLine("Name:\t\t" + lastName + ", " + firstName);
            Console.WriteLine();

            Console.WriteLine("ID:\t\t" + studentID);
            Console.WriteLine();

            Console.WriteLine("Username:\t" + userName);
            Console.WriteLine();

            Console.WriteLine("Grade:\t\t" + grade);
            Console.WriteLine();

            Console.WriteLine("Average:\t" + schoolAverage + "%");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();




            ageIn5 = (age + 5);
            ageLast5 = (age - 5);
            Console.WriteLine("Hey," + firstName + "! Did you know that in 5 years you will be " + ageIn5 +
                ", and 5 years ago you were " + ageLast5);
            Console.WriteLine("Crazy how time flies.");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Welcome to Calculator App");
            Console.WriteLine();

            Console.WriteLine("Please input a number:");
            Double.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine();

            Console.WriteLine("Please input a number:");
            Double.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine();

            Console.WriteLine("Please input a number:");
            Double.TryParse(Console.ReadLine(), out num3);
            Console.WriteLine();

            numTotal = (num1 + num2 + num3);
            numAvg = numTotal / 2;
            Console.WriteLine("The sum of your numbers is: " + numTotal);
            Console.WriteLine();
            Console.WriteLine(numTotal + " divided by 2 = " +  numAvg);






        }
    }
}
