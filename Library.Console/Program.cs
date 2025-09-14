using System;
using Library.Logic;
using Npgsql;

namespace Library.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Проверка");

            Library_Logic library_Logic = new Library_Logic();

            library_Logic.CreateCategory("roman");

            library_Logic.CreateBook("run pike", "description", "Pyskun", 123, 2023, 1);
            library_Logic.CreateBook("run banan", "description", "tolstoy", 435, 1323, 1);


        }
    }
}