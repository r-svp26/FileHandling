using System;

namespace FileIO
{
    class Program
    {
        static string path = @"V:\BridgeLabz\FileIO\Input.txt";
        static string newpath = @"V:\BridgeLabz\FileIO\Input.txt";
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File IO");
            Operation.FileExist(path);
            Operation.ReadAllLines(path);
            Operation.CopyText(path, newpath);
            Operation.Delete(newpath);
            Operation.DisplayFile(path);
            Console.WriteLine("Serialization");
            BinarySerialization.Serialization();
            Console.WriteLine("Deserialization");
            BinarySerialization.Deserialization();
        }
    }
}
