using System;

class Program
{
    static void Main(string[] args)
    {
        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
        {
            Console.WriteLine("Listing directories in Windows");
            string[] directories = System.IO.Directory.GetDirectories(@"C:\");
            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
            }
        }
        else if (Environment.OSVersion.Platform == PlatformID.Unix)
        {
            Console.WriteLine("Listing directories in Unix");
            string[] directories = System.IO.Directory.GetDirectories(@"/");
            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
            }
        }
        else
        {
            Console.WriteLine("Operating system not supported");
        }
    }
}
