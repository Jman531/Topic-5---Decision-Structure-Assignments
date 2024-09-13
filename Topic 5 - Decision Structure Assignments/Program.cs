namespace Topic_5___Decision_Structure_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int parkingCost;
            double angle, parkingMinutes;

            parkingCost = 4;

            Console.Write("Input an angle (0-360) and I will tell you if it's north, east, south or west: ");
            while (!Double.TryParse(Console.ReadLine(), out angle))
            {
                Console.Write("Invalid input, please enter in a valid angle: ");
            }
            angle = angle % 360;

            if (angle >= 45 && angle <= 135)
            {
                Console.WriteLine("You are going east!");
            }
            else if (angle >= 135 && angle <= 225)
            {
                Console.WriteLine("You are going south!");
            }
            else if (angle >= 225 && angle <= 315)
            {
                Console.WriteLine("You are going west");
            }
            else
            {
                Console.WriteLine("You are going north");
            }

            Console.WriteLine();

            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();

            Console.Write("Hello! Welcome to Sam's parking garage! It costs $4.00 to park here and an additional $2.00 per hour and there is a maximum charge of $20.00 for the day... How many minutes do you want to park for? ");
            while (!Double.TryParse(Console.ReadLine(), out parkingMinutes))
            {
                Console.Write("Invalid input, if you want to park here please enter in a valid time... ");
            }

            parkingMinutes = (parkingMinutes / 60);

            parkingMinutes = Math.Ceiling(parkingMinutes);

            for (int i = 1; i < parkingMinutes; i++)
            {
                parkingCost += 2;
            }

            if (parkingCost > 20)
            {
                parkingCost = 20;
            }

            Console.WriteLine("It'll cost you " + parkingCost.ToString("C") + " to park here!");
        }
    }
}
