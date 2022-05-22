namespace Stream
{
    internal class Print
    {
        internal void PrintMethod()
        {
            var drive = new Drive();
            var directories = new Directories();
            var files = new Files();

            PrintHeader();

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

                    case "CD":
                    case "Cd":
                    case "cd":
                        directories.CreateDirectoryWithPath(directories.GetDirPath(), directories.GetNewDirectoryName());
                        break;

                    case "DD":
                    case "Dd":
                    case "dd":
                        directories.DeleteDirectoryWithPath(directories.GetDirPath());
                        break;

                    case "E":
                    case "e":
                        Console.WriteLine("Good Bye!");
                        System.Threading.Thread.Sleep(100);
                        exiting = true;
                        break;
                    default:
                        Console.WriteLine($"no command for {response} key");
                        PrintHeader();
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

        internal void PrintHeader()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("Type P for print Drives");
            Console.WriteLine("Type D for print info about Directories");
            Console.WriteLine("Type CF to create File");
            Console.WriteLine("Type DF to delete File");
            Console.WriteLine("Type CD to create Directory");
            Console.WriteLine("Type DD to delete Directory");
            Console.WriteLine("*************************************");
            Console.WriteLine("Type E Exit");
        }
    }
}
