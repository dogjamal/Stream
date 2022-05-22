namespace Stream
{
    internal class Streaming
    {
        internal void UpdateFile(string filePath, string messageToUpdateFile)
        {
            if (!File.Exists(filePath))
                Console.WriteLine("File doesn't exist");
            else
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Write, FileShare.Write);

                try
                {
                    StreamWriter streamWriter = new StreamWriter(fileStream);
                    fileStream.Position = fileStream.Length;
                    streamWriter.WriteLine(messageToUpdateFile);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                catch (Exception e) { Console.WriteLine(e.Message); }

                Console.WriteLine("File updated");
            }
        }

        internal void ShowFileInfo(string filePath)
        {
            if (!File.Exists(filePath))
                Console.WriteLine("File doesn't exist");
            else
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);

                try
                {
                    StreamReader streamReader = new StreamReader(fileStream);
                    Console.WriteLine(streamReader.ReadToEnd());
                    streamReader.Close();
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
        }

        internal string GetFullFileNameWithExtension()
        {
            Console.WriteLine("Type full file name with extension");
            return Console.ReadLine();
        }

        internal string GetMessageToUpdateFile()
        {
            Console.WriteLine("Type to update file");
            return Console.ReadLine();
        }
    }
}
