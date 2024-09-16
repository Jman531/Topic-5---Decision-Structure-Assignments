namespace Topic_5___Decision_Structure_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int parkingCost, hurricaneCategory;
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
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            Console.Clear();

            Console.Write("Please enter in a hurricane category and I will tell you the wind speeds: ");
            while (!Int32.TryParse(Console.ReadLine(), out hurricaneCategory));
            {
                Console.WriteLine("Invalid input, please try again... ");
            }

            Console.WriteLine();

            switch (hurricaneCategory)
            {
                case 1:
                    Console.WriteLine("Wind speed is: 74-95 mph or 64-82 kt or 119-153 km/hr");
                    break;
                case 2:
                    Console.WriteLine("Wind speed is: 96-110 mph or 83-95 kt or 154-177 km/hr");
                    break;
                case 3:
                    Console.WriteLine("Wind speed is: 111-130 mph or 96-113 kt or 178-209 km/hr");
                    break;
                case 4:
                    Console.WriteLine("Wind speed is: 131-155 mph or 114-135 kt or 210-249 km/hr");
                    break;
                case 5:
                    Console.WriteLine("Wind speed is greater than: 155 mph or 135 kt or 249 km/hr");
                    break;
                default:
                    Console.WriteLine("That is not a hurricane category...");
                    break;
            }
        }
    }
}
