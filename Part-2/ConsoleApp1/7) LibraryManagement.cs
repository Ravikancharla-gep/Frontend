using System;

namespace ConsoleApp1
{
    class LibraryManagement
    {
        static void Main(string[] args)
        {
            (string Title, bool IsCheckedOut)[] books = new (string, bool)[5];
            int borrowedCount = 0;

            while (true)
            {
                Console.WriteLine("Choose an action: add, remove, display, search, borrow, return, exit");
                string action = Console.ReadLine()?.ToLower() ?? string.Empty;

                if (string.IsNullOrEmpty(action))
                {
                    Console.WriteLine("Invalid action. Please choose add, remove, display, search, borrow, return, or exit.");
                    continue;
                }

                if (action == "add")
                {
                    AddBook(books);
                }
                else if (action == "remove")
                {
                    RemoveBook(books);
                }
                else if (action == "display")
                {
                    DisplayBooks(books);
                }
                else if (action == "search")
                {
                    SearchBook(books);
                }
                else if (action == "borrow")
                {
                    BorrowBook(books, ref borrowedCount);
                }
                else if (action == "return")
                {
                    ReturnBook(books, ref borrowedCount);
                }
                else if (action == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid action. Please choose add, remove, display, search, borrow, return, or exit.");
                }
            }
        }

        static void AddBook((string Title, bool IsCheckedOut)[] books)
        {
            Console.WriteLine("Enter the title of the book to add:");
            string title = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Invalid title.");
                return;
            }

            for (int i = 0; i < books.Length; i++)
            {
                if (string.IsNullOrEmpty(books[i].Title))
                {
                    books[i] = (title, false);
                    Console.WriteLine($"Book '{title}' added.");
                    return;
                }
            }

            Console.WriteLine("No more space to add new books.");
        }

        static void RemoveBook((string Title, bool IsCheckedOut)[] books)
        {
            Console.WriteLine("Enter the title of the book to remove:");
            string title = Console.ReadLine();

            if (string.IsNullOrEmpty(title))
            {
                Console.WriteLine("Invalid title.");
                return;
            }

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Title == title)
                {
                    books[i] = (null, false);
                    Console.WriteLine($"Book '{title}' removed.");
                    return;
                }
            }

            Console.WriteLine("Book not found.");
        }

        static void SearchBook((string Title, bool IsCheckedOut)[] books)
        {
            Console.WriteLine("Enter the title of the book to search:");
            string title = Console.ReadLine();

            if (string.IsNullOrEmpty(title))
            {
                Console.WriteLine("Invalid title.");
                return;
            }

            foreach (var book in books)
            {
                if (book.Title == title)
                {
                    Console.WriteLine($"Book '{title}' is available.");
                    return;
                }
            }

            Console.WriteLine("Book not found.");
        }

        static void BorrowBook((string Title, bool IsCheckedOut)[] books, ref int borrowedCount)
        {
            if (borrowedCount >= 3)
            {
                Console.WriteLine("You cannot borrow more than 3 books at a time.");
                return;
            }

            Console.WriteLine("Enter the title of the book to borrow:");
            string title = Console.ReadLine();

            if (string.IsNullOrEmpty(title))
            {
                Console.WriteLine("Invalid title.");
                return;
            }

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Title == title && !books[i].IsCheckedOut)
                {
                    books[i].IsCheckedOut = true;
                    borrowedCount++;
                    Console.WriteLine($"Book '{title}' borrowed.");
                    return;
                }
            }

            Console.WriteLine("Book not found or already borrowed.");
        }

        static void ReturnBook((string Title, bool IsCheckedOut)[] books, ref int borrowedCount)
        {
            Console.WriteLine("Enter the title of the book to return:");
            string title = Console.ReadLine();

            if (string.IsNullOrEmpty(title))
            {
                Console.WriteLine("Invalid title.");
                return;
            }

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Title == title && books[i].IsCheckedOut)
                {
                    books[i].IsCheckedOut = false;
                    borrowedCount--;
                    Console.WriteLine($"Book '{title}' returned.");
                    return;
                }
            }

            Console.WriteLine("Book not found or not borrowed.");
        }

        static void DisplayBooks((string Title, bool IsCheckedOut)[] books)
        {
            Console.WriteLine("Books currently in the library:");
            foreach (var book in books)
            {
                if (!string.IsNullOrEmpty(book.Title))
                {
                    string status = book.IsCheckedOut ? " (Checked Out)" : "";
                    Console.WriteLine(book.Title + status);
                }
            }
        }
    }
}