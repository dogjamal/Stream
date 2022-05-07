namespace Stream
{
    internal class print
    {
        internal void print_method()
        {
            var mdr = new drive();
            var mdi = new directories();

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
                        mdr.print_drive();
                        break;

                    case "F":
                    case "f":
                        mdi.print_directory();
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
