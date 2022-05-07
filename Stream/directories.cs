namespace Stream
{
    internal class directories
    {
        internal void print_directory()
        {
            string dirName = "C:\\";
            var directory = new DirectoryInfo(dirName);

            if (directory.Exists)
            {
                Console.WriteLine("Directories:");
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
    }
}
