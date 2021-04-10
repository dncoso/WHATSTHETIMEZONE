using System;

namespace WHATSTHETIMEZONE
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.WhatsTheTime();
        }

        private static void WhatsTheTime()
        {
            string userInput;

            do
            {
                Console.WriteLine("");
                Console.WriteLine(" Write a city to see the timezone!");
                Console.WriteLine(" Write all to see all awailable cities");
                Console.WriteLine(" Write exit to exit");
                Console.WriteLine(" ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "all":
                        foreach (var timeZone in TimeZoneInfo.GetSystemTimeZones())
                        {
                            Console.WriteLine($"\t{timeZone}\n");
                        }
                        break;
                    default:

                        bool valid = false;
                        foreach (var timeZone in TimeZoneInfo.GetSystemTimeZones())
                        {
                            if (timeZone.ToString().ToLower().Contains(userInput.ToLower()))
                            {
                                Console.WriteLine($"\n\t{timeZone}\n");
                                valid = true;
                            }
                        }
                        if (userInput == "exit")
                            valid = true;
                        if (!valid)
                        {
                            Console.WriteLine($" Sorry the city -{userInput}- does not have a named timezone\n");
                        }
                        break;
                }

            } while (userInput != "exit");
        }

    }
}
