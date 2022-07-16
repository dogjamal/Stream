namespace Stream
{
    internal class Print
    {
        internal void PrintMethod()
        {
            var drive = new Drive();
            var directories = new Directories();
            var files = new Files();
            var streaming = new Streaming();

            PrintHeader();

            string response = "";
            bool exiting = false;

            response = Console.ReadLine();

            while (response != "EXIT" || response != "Exit" || response != "exit")
            {
                switch (response)
                {
                    case "EDIT":
                    case "Edit":
                    case "edit":
                        EditMenu();
                        break;

                    case "VIEW":
                    case "View":
                    case "view":
                        ViewMenu();
                        break;
                        
                    case "EXIT":
                    case "Exit":
                    case "exit":
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

        private void PrintHeader()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("*************************************");
            Console.WriteLine("Type Edit for Edit Menu");
            Console.WriteLine("Type View for View Menu");
            Console.WriteLine("*************************************");
            Console.WriteLine("Type Exit if you did all tasks");
            Console.ResetColor();
        }

        private void EditMenuHeader()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("*************************************");
            Console.WriteLine("Type CF to create File");
            Console.WriteLine("Type DF to delete File");
            Console.WriteLine("Type CD to create Directory");
            Console.WriteLine("Type DD to delete Directory");
            Console.WriteLine("Type UF to update File");
            Console.WriteLine("*************************************");
            Console.WriteLine("Type M to return Main menu");
            Console.ResetColor();
        }

        private void ViewMenuHeader()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("*************************************");
            Console.WriteLine("Type P for print Drives");
            Console.WriteLine("Type D for print info about Directories");
            Console.WriteLine("Type SF to show File info");
            Console.WriteLine("Type CD to show Files and Directories names");
            Console.WriteLine("*************************************");
            Console.WriteLine("Type M to return Main menu");
            Console.ResetColor();
        }

        private void FunctionDone()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Operation is done");
            Console.ResetColor();
        }

        private void EditMenu()
        {
            var directories = new Directories();
            var files = new Files();
            var streaming = new Streaming();

            EditMenuHeader();

            string response = "";
            bool exiting = false;

            response = Console.ReadLine();

            while (response != "M" || response != "m")
            {
                switch (response)
                {
                    case "CF":
                    case "Cf":
                    case "cf":
                        files.CreateFileWithPath(directories.GetDirPath(), files.GetFileName());
                        FunctionDone();
                        break;

                    case "DF":
                    case "Df":
                    case "df":
                        files.DeleteFileWithPath(directories.GetDirPath(), files.GetFileName());
                        FunctionDone();
                        break;

                    case "CD":
                    case "Cd":
                    case "cd":
                        directories.CreateDirectoryWithPath(directories.GetDirPath(), directories.GetNewDirectoryName());
                        FunctionDone();
                        break;

                    case "DD":
                    case "Dd":
                    case "dd":
                        directories.DeleteDirectoryWithPath(directories.GetDirPath());
                        FunctionDone();
                        break;

                    case "UF":
                    case "Uf":
                    case "uf":
                        streaming.UpdateFile(streaming.GetFullFileNameWithExtension(), streaming.GetMessageToUpdateFile());
                        FunctionDone();
                        break;

                    case "M":
                    case "m":
                        PrintHeader();
                        exiting = true;
                        break;
                    default:
                        Console.WriteLine($"no command for {response} key");
                        EditMenuHeader();
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

        private void ViewMenu()
        {
            var drive = new Drive();
            var directories = new Directories();
            var files = new Files();
            var streaming = new Streaming();

            ViewMenuHeader();

            string response = "";
            bool exiting = false;

            response = Console.ReadLine();

            while (response != "M" || response != "m")
            {
                switch (response)
                {
                    case "P":
                    case "p":
                        drive.PrintDrive();
                        FunctionDone();
                        break;

                    case "D":
                    case "d":
                        directories.PrintDriveDirectory(drive.GetDrivesName());
                        FunctionDone();
                        break;

                    case "SF":
                    case "Sf":
                    case "sf":
                        streaming.ShowFileInfo(streaming.GetFullFileNameWithExtension());
                        FunctionDone();
                        break;

                    case "CD":
                    case "Cd":
                    case "cd":
                        directories.PrintCurrentPlaceDriveDirectory();
                        FunctionDone();
                        break;
                    case "M":
                    case "m":
                        PrintHeader();
                        exiting = true;
                        break;
                    default:
                        Console.WriteLine($"no command for {response} key");
                        ViewMenuHeader();
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
