namespace Stream
{
    internal class Files
    {
        internal void CreateFileWithPath(string dirPath, string fileName)
        {
            if (File.Exists(dirPath + "\\" + fileName))
                Console.WriteLine("File exist");
            else if (!Directory.Exists(dirPath))
                Console.WriteLine("Directory doesn't exist");
            else
            {
                var file = new FileInfo(dirPath + "\\" + fileName);

                try
                {
                    var stream = file.Create();
                    stream.Close();
                }
                catch (Exception e) { Console.WriteLine(e.Message); }

                Console.WriteLine("File created");
                Console.WriteLine("Full Name   : {0}", file.FullName);
            }
        }

        internal void DeleteFileWithPath(string dirPath, string fileName)
        {
            if (!File.Exists(dirPath + "\\" + fileName))
                Console.WriteLine("File doesn't exist");
            else if (!Directory.Exists(dirPath))
                Console.WriteLine("Directory doesn't exist");
            else
            {
                var file = new FileInfo(dirPath + "\\" + fileName);

                try
                {
                    file.Delete();
                }
                catch (Exception e) { Console.WriteLine(e.Message); }

                Console.WriteLine("File deleted");
            }
        }

        internal string GetFileName()
        {
            Console.WriteLine("Type file name");
            return Console.ReadLine();
        }
    }
}
