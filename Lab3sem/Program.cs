using System;
using System.IO;

namespace Lab3sem
{
    class Program // Обозначаем класс
    {
        static void Main(string[] args)
        {
            File.Delete("file2.txt"); // Удалить файл "file2.txt" 
            StreamWriter sw = System.IO.File.CreateText("file.txt");
            sw.Write("Пусть каждый день твой будет светлым, ");
            sw.WriteLine("приятным, радостным и щедрым!");
            sw.Close();
            File.Move("file.txt", "file2.txt"); // Переименование
            FileInfo fileInfo = new FileInfo("file2.txt");
            Console.WriteLine("File {0} is {1} bytes in length, created on {2}",
            fileInfo.FullName, fileInfo.Length, fileInfo.CreationTime);
            Console.WriteLine("");
            StreamReader sr = fileInfo.OpenText();
            String s = sr.ReadLine();
            while (s != null)
            {
                Console.WriteLine(s); s = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
