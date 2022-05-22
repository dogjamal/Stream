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