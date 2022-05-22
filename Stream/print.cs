namespace Stream
{
    internal class Print
    {
        internal void PrintMethod()
        {
            var drive = new Drive();
            var directories = new Directories();
            var files = new Files();


            Console.WriteLine("Type P for print Drives");
            Console.WriteLine("Type D for print info about Directories");
            Console.WriteLine("Type CF to create file");
            Console.WriteLine("Type DF to delete file");
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

                    case "D":
                    case "d":
                        directories.PrintDriveDirectory(drive.GetDrivesName());
                        break;

                    case "CF":
                    case "Cf":
                    case "cf":
                        files.CreateFileWithPath(directories.GetDirPath(), files.GetFileName());
                        break;

                    case "DF":
                    case "Df":
                    case "df":
                        files.DeleteFileWithPath(directories.GetDirPath(), files.GetFileName());
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
                        Console.WriteLine("Type D for print info about Directories");
                        Console.WriteLine("Type CF to create file");
                        Console.WriteLine("Type DF to delete file");
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
