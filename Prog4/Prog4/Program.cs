// B3697
// CIS 199-75
// 12/05/17
// Program 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog4
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Several derived LibraryBook objects created and output
        static void Main(string[] args)
        {
            LibraryBook book1 = 
                new LibraryBook("Harry Potter and the Sorcerer's Stone", "J. K. Rowling", "Arthur A. Levine", 
                                1997, "PR6066.O93 H33 1997");   // Book 1
            LibraryBook book2 =
                new LibraryBook("Harry Potter and the Chamber of Secrets", "J. K. Rowling", "Arthur A. Levine", 
                                1998, "PR6066.O93 H373 1998");  // Book 2
            LibraryBook book3 =
                new LibraryBook("Harry Potter and the Prisoner of Azkaban", "J. K. Rowling", "Arthur A. Levine", 
                                1999, "PR6066.O93 H327 1999");  // Book 3
            LibraryBook book4 =
                new LibraryBook("Harry Potter and the Goblet of Fire", "J. K. Rowling", "Arthur A. Levine", 
                                2000, "PR6066.O93 H34 2000");   // Book 4
            LibraryBook book5 =
                new LibraryBook("Harry Potter and the Order of the Phoenix", "J. K. Rowling", "Arthur A. Levine", 
                                2001, "PR6066.O93 H3727 2001"); // Book 5

            // Five-elemeber LibraryBook array
            LibraryBook[] books = new LibraryBook[5];

            // Initialize array with LibraryBook of derived types
            books[0] = book1;
            books[1] = book2;
            books[2] = book3;
            books[3] = book4;
            books[4] = book5;

            DisplayOriginal(books); // Calls method and prints out each object's original data
            DisplayChanged(books);  // Calls method and prints out each object's new data after being changed
            DisplayReturned(books); // Calls method and prints out each object's new data after returning the 
                                    // books that had been checked out
        }

        // Precondition:  None
        // Postcondition: Method uses a foreach loop to process each element in array books 
        //                and displays them in desired format
        private static void DisplayOriginal(LibraryBook[] origBooks)
        {
            // Original data heading and formatting
            WriteLine("_____________");
            WriteLine();
            WriteLine("ORIGINAL DATA");
            WriteLine("_____________");
            WriteLine();

            // Generically processes each element in array books
            foreach (LibraryBook book in origBooks)
            {
                WriteLine(book); // Invokes ToString implicitly
                WriteLine();
            }
        }

        // Precondition:  None
        // Postcondition: Method changes a property or method of each book and uses a foreach loop
        //                to process each elemenet in array books and displays them in desired format
        private static void DisplayChanged(LibraryBook[] changedBooks)
        {
            changedBooks[0].Title = "Harry Potter and the Philosopher's Stone"; // Changes the Title property of book 1
            changedBooks[1].CopyrightYear = 1999;                               // Changes the CopyrightYear property of book 2
            changedBooks[2].CheckOut();                                         // Changes the checked out status to true of book 3
            changedBooks[3].CheckOut();                                         // Changes the checked out status to true of book 4
            changedBooks[4].CheckOut();                                         // Changes the checked out status to true of book 5

            // Changed data heading and formatting
            WriteLine("____________");
            WriteLine();
            WriteLine("CHANGED DATA");
            WriteLine("____________");
            WriteLine();

            // Generically processes each changed element in array books
            foreach (LibraryBook book in changedBooks)
            {
                WriteLine(book); // Invokes ToString implicitly
                WriteLine();
            }
        }

        // Precondition:  None
        // Postcondition: Method changes each book that was checked out to false and uses a foreach
        //                loop to process each element in array books and displays them in desired format
        private static void DisplayReturned(LibraryBook[] returnedBooks)
        {
            returnedBooks[2].ReturnToShelf(); // Returns book 2, changing its checked out status to false
            returnedBooks[3].ReturnToShelf(); // Returns book 3, changing its checked out status to false
            returnedBooks[4].ReturnToShelf(); // Returns book 4, changing its checked out status to false

            // Returned books data heading and formatting
            WriteLine("___________________");
            WriteLine();
            WriteLine("RETURNED BOOKS DATA");
            WriteLine("___________________");
            WriteLine();

            // Generically processes each element in array books
            foreach (LibraryBook book in returnedBooks)
            {
                WriteLine(book); // Invokes ToString implicitly
                WriteLine();
            }
        }
    }
}
