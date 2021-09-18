using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] filenames;

        if (args.Length > 1)
            filenames = args;
        else
            filenames = Directory.GetFiles("images/", "*.jpg");

        ImageProcessor.Inverse(filenames);
    }
}
