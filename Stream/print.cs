namespace Stream
{
    internal class Print
    {
        internal void PrintMethod()
        {
            var drive = new Drive();
            var directories = new Directories();

            Console.WriteLine("Type P for print Drives");
            Console.WriteLine("Type F for print info about Directories");
            Console.WriteLine("*************************************");
            Console.WriteLine("Type E Exit");

            string response = "";
            bool exiting = false;

            response = Console.ReadLine();

            while (response != "e" || response != "E")
            {
                switch (response)
                {
                    case "P":
                    case "p":
                        drive.PrintDrive();
                        break;

                    case "F":
                    case "f":
                        directories.PrintDirectory(drive.GetDrivesName());
                        break;

                    case "E":
                    case "e":
                        Console.WriteLine("Good Bye!");
                        System.Threading.Thread.Sleep(100);
                        exiting = true;
                        break;
                    default:
                        Console.WriteLine($"no command for {response} key");
                        Console.WriteLine("*************************************");
                        Console.WriteLine("Type P for print Drives");
                        Console.WriteLine("Type F for print info about Directories");
                        Console.WriteLine("*************************************");
                        Console.WriteLine("Type E Exit");
                        break;
                }

                if (exiting)
                {
                    break;
                }
                else
                {
                    response = Console.ReadLine();
                }
            }
        }
    }
}
