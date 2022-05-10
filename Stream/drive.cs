namespace Stream
{
    internal class Drive
    {
        internal void PrintDrive()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrives)
            {
                try
                {
                    Console.WriteLine("\nDrive                            : {0}", drive.Name);
                    Console.WriteLine("File type                        : {0}", drive.DriveType);
                    if (drive.IsReady)
                    {
                        Console.WriteLine("Volume label                     : {0}", drive.VolumeLabel);
                        Console.WriteLine("File system                      : {0}", drive.DriveFormat);
                        Console.WriteLine("Available space to current user  : {0} bytes", drive.AvailableFreeSpace);
                        Console.WriteLine("Total available space            : {0} bytes", drive.TotalFreeSpace);
                        Console.WriteLine("Total size of drive              : {0} bytes", drive.TotalSize);
                        Console.WriteLine("RootDirectory                    : {0} bytes", drive.RootDirectory);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception: {e.Message}");
                }               
            }
        }

        internal List<string> GetDrivesName()
        {

            List<string> driveNames = new List<string>();

            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrives)
            {
                try
                {
                    driveNames.Add(drive.Name);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception: {e.Message}");
                }
            }
            return driveNames;
        }
    }
}
