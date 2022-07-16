namespace Stream
{
    internal class Directories
    {
        internal void PrintDriveDirectory(List<string> dirNames)
        {
            if (dirNames.Count == 0)
                Console.WriteLine("Empty directories");
            else
            {
                foreach (string dirName in dirNames)
                {
                    try
                    {
                        PrintDirectoryInfo(dirName);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Exception: {e.Message}");
                    }
                }
            }
        }
        internal void PrintDirectoryInfo(string dirName)
        {
            var directory = new DirectoryInfo(dirName);

            if (directory.Exists)
            {
                Console.WriteLine("Directories of drive {0}:\n", dirName.Substring(0, dirName.Length - 2));
                DirectoryInfo[] dirs = directory.GetDirectories();
                foreach (DirectoryInfo dir in dirs)
                {
                    Console.WriteLine("FullName      : {0}", dir.FullName);
                    Console.WriteLine("Name          : {0}", dir.Name);
                    Console.WriteLine("Parent        : {0}", dir.Parent);
                    Console.WriteLine("CreationTime  : {0}", dir.CreationTime);
                    Console.WriteLine("Attributes    : {0}", dir.Attributes);
                    Console.WriteLine("Root          : {0}", dir.Root);
                    Console.WriteLine("LastAccessTime: {0}", dir.LastAccessTime);
                    Console.WriteLine("LastWriteTime : {0}", dir.LastWriteTime);
                    Console.WriteLine("*************************************\n");
                }
            }
        }

        internal void PrintCurrentPlaceDriveDirectory()
        {
            string catalog = Directory.GetCurrentDirectory();
            DirectoryInfo dirinfo = new DirectoryInfo(catalog);

            if (catalog == null)
                Console.WriteLine("Empty directories");
            else
            {
                try
                {
                    PrintDirectoryAndFileInfoName(catalog);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception: {e.Message}");
                }
            }
        }
        internal void PrintDirectoryAndFileInfoName(string dirName)
        {
            var directory = new DirectoryInfo(dirName);

            if (directory.Exists)
            {
                List<string> listOfFileAndDir = GetRecursFileAndDir(dirName);

                List<string> GetRecursFileAndDir(string start_path)
                {
                    List<string> listOfFileAndDir = new List<string>();
                    try
                    {
                        string[] folders = Directory.GetDirectories(start_path);
                        foreach (string folder in folders)
                        {
                            listOfFileAndDir.Add("Directory: " + folder);
                            listOfFileAndDir.AddRange(GetRecursFileAndDir(folder));
                        }
                        string[] files = Directory.GetFiles(start_path);
                        foreach (string filename in files)
                        {
                            listOfFileAndDir.Add("File: " + filename);
                        }
                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    return listOfFileAndDir;
                }

                foreach (string fileAndDir in listOfFileAndDir)
                {
                    Console.WriteLine(fileAndDir);
                }
            }
        }

        internal void ChangeCurrentDirectory(string targetDirPath)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();

                if (!Directory.Exists(targetDirPath))
                    Console.WriteLine("Directory doesn't exist");

                Environment.CurrentDirectory = (targetDirPath);
                if (path.Equals(Directory.GetCurrentDirectory()))
                    Console.WriteLine("You are in the current directory.");
                Directory.SetCurrentDirectory(targetDirPath);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        internal void CreateDirectoryWithPath(string dirPath, string newDirectoryName)
        {
            if (!Directory.Exists(dirPath))
                Console.WriteLine("Directory doesn't exist");
            else
            {
                var directory = new DirectoryInfo(dirPath);

                try
                {
                    directory.CreateSubdirectory(newDirectoryName);
                }
                catch (Exception e) { Console.WriteLine(e.Message); }

                Console.WriteLine("Directory created");
                Console.WriteLine("Full Name   : {0}", directory.FullName);
            }
        }

        internal void DeleteDirectoryWithPath(string dirPath)
        {
            if (!Directory.Exists(dirPath))
                Console.WriteLine("File doesn't exist");
            else
            {
                var directory = new DirectoryInfo(dirPath);

                try
                {
                    directory.Delete();
                }
                catch (Exception e) { Console.WriteLine(e.Message); }

                Console.WriteLine("Directory deleted");
            }
        }

        internal string GetDirPath()
        {
            Console.WriteLine("Type directory path");
            return Console.ReadLine();
        }

        internal string GetNewDirectoryName()
        {
            Console.WriteLine("Type name for new directory");
            return Console.ReadLine();
        }
    }
}