using System;
using System.Collections.Generic;
using System.Linq;

namespace Libary
{
    public class Program
    {


        static void Main(string[] args)
        {
            int menu = 0;
            int bookChoice = 0;
            List<Books> bookList = new List<Books>();
            Stack<Books> userList = new Stack<Books>();
            Books HarryPotter = new Books("Harry Potter",101,"Black","Fantasy");
            Books StarWars = new Books("Star Wars", 703, "Red", "Fantasy");
            Books GuinessRecords = new Books("Guiness Record Book", 777, "Blue", "Literary");
            bookList.Add(HarryPotter);
            bookList.Add(StarWars);
            bookList.Add(GuinessRecords);

            do
            {
                switch (menu)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine
                        (
                        "====================================" +
                        "\n               Library              " +
                        "\n====================================" +
                        "\n1. Rent book" +
                        "\n3. Exit\n"+
                        "\nEnter your choice"
                        );
                        menu = int.Parse(Console.ReadLine());
                        break;
                    case 1:
                        Console.Clear();
                        int i = 0;
                        foreach (Books book in bookList)
                        {
                            i++;
                            Console.WriteLine(i+". "+book.Name);
                        }
                        if (bookList.Count() > 0)
                        {
                            Console.WriteLine("\nChoose a book to rent");
                            bookChoice = int.Parse(Console.ReadLine());
                            userList.Push(bookList[bookChoice-1]);
                            bookList.Remove(bookList[bookChoice-1]);
                        }



                        
                        if (bookList.Count() == 0)
                        {
                            Console.WriteLine("All books a loaned out");
                            menu = 2;
                        }
                        else
                        {
                        Console.WriteLine("\n1. Choose more books   2.Finish");
                        menu = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 2:
                        Console.Clear();
                        while (userList.Count() > 0 ) 
                        {
                            Console.WriteLine(userList.Peek().Name); 
                            userList.Pop();
                        }
                        Console.WriteLine("\nAll your chosen books are now in your name");
                        Console.WriteLine("Exit by entering 3");
                        menu = int.Parse(Console.ReadLine());
                            break;



                }
            }while (menu != 3);





        }

    }
}
