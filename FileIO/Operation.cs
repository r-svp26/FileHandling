using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    class Operation
    {
        /// <summary>
        /// check is exist or not
        /// </summary>
        /// <param name="path"></param>
        public static void FileExist(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("File is exist");
            }
        }
        /// <summary>
        /// read the files line by line
        /// </summary>
        /// <param name="path"></param>
        public static void ReadAllLines(string path)
        {
            string[] lines = File.ReadAllLines(path);
            foreach (var data in lines)
            {
                Console.WriteLine(data + " ");
            }
        }
        /// <summary>
        /// read file at once
        /// </summary>
        /// <param name="path"></param>
        public static void ReadAllText(string path)
        {
            string line = File.ReadAllText(path);
            Console.WriteLine(line + " ");  
        }
        /// <summary>
        /// copy the text
        /// </summary>
        /// <param name="path"></param>
        /// <param name="newPath"></param>
        public static void CopyText(string path, string newpath)
        {
            File.Copy(path,newpath);
        }
        /// <summary>
        /// delete the file
        /// </summary>
        /// <param name="newpath"></param>
        public static void Delete(string newpath)
        { 
            File.Delete(newpath);
        }
        /// <summary>
        /// print the data
        /// </summary>
        /// <param name="path"></param>
        public static void DisplayFile(string path)
        {
            StreamReader read= null;
            try
            {
                using (read = new StreamReader(path))
                {
                    var data = read.ReadToEnd();
                    foreach (var text in data)
                    {
                        Console.WriteLine(text+ " ");
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
