namespace Stream
{
    internal class drive
    {
        internal void print_drive()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("\nDrive                            : {0}", d.Name);
                Console.WriteLine("File type                        : {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine("Volume label                     : {0}", d.VolumeLabel);
                    Console.WriteLine("File system                      : {0}", d.DriveFormat);
                    Console.WriteLine("Available space to current user  : {0} bytes", d.AvailableFreeSpace);
                    Console.WriteLine("Total available space            : {0} bytes", d.TotalFreeSpace);
                    Console.WriteLine("Total size of drive              : {0} bytes", d .TotalSize);
                    Console.WriteLine("RootDirectory                    : {0} bytes", d.RootDirectory);
                }
            }
        }
    }
}
