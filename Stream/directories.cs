namespace Stream
{
    internal class Directories
    {
        internal void PrintDirectory(List<string> dirNames)
        {
            if (dirNames.Count == 0)
                Console.WriteLine("Empty directories");
            else
            {
                foreach (string dirName in dirNames)
                {
                    try
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
                    catch (Exception e)
                    {
                        Console.WriteLine($"Exception: {e.Message}");
                    }
                }
            }
  
        }
    }
}
