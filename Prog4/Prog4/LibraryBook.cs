// LibraryBook base class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog4
{
    class LibraryBook
    {
        private string _title;                // Library book's title
        private string _author;               // Library book's author
        private string _publisher;            // Library book's publisher
        private int _copyrightYear;           // Library book's copyright year
        private string _callNumber;           // Library book's call number
        private bool _checkedOut;             // Library book's checked out status
        public const int DEFAULT_YEAR = 2017; // Default copyright year if none is given

        // Property that gets and sets the library book's title
        public string Title
        {
            // Precondition:  None
            // Postcondition: The title has been returned
            get
            {
                return _title;
            }

            // Precondition:  None
            // Postcondition: The title has been set to the specified value
            set
            {
                _title = value;
            }
        }

        // Property that gets and sets the library book's author
        public string Author
        {
            // Precondition:  None
            // Postcondition: The author has been returned
            get
            {
                return _author;
            }

            // Precondition:  None
            // Postcondition: The author has been set to the specified value
            set
            {
                _author = value;
            }
        }

        // Property that gets and sets the library book's publisher
        public string Publisher
        {
            // Precondition:  None
            // Postcondition: The publisher has been returned
            get
            {
                return _publisher;
            }

            // Precondition:  None
            // Postcondition: The publisher has been set to the specified valye
            set
            {
                _publisher = value;
            }
        }

        // Property that gets and sets the library book's copyright year
        public int CopyrightYear
        {
            // Precondition:  None
            // Postcondition: The copyright year has been returned
            get
            {
                return _copyrightYear;
            }

            // Precondition:  value >= 0
            // Postcondition: The copyright year has been set to the specified value
            set
            {
                if (value >= 0)
                    _copyrightYear = value;
                else // Wehn invalid, set year to 2017 instead
                    _copyrightYear = DEFAULT_YEAR;
            }
        }

        // Property that gets and sets the library book's call number
        public string CallNumber
        {
            // Precondition:  None
            // Postcondition: The call number has been returned
            get
            {
                return _callNumber;
            }

            // Precondition:  None
            // Postcondition: The call number has been set to the specified value
            set
            {
                _callNumber = value;
            }
        }

        // Five-parameter constructor
        // Precondition: copyrightYear >= 0
        // Postcondition: The LibraryBook object has been initialized with the specified
        //                title, author, publisher, copyright year, and call number
        public LibraryBook(string title, string author, string publisher, int copyrightYear, string callNumber)
        {
            Title = title;                 // Set the Title property
            Author = author;               // Set the Author property
            Publisher = publisher;         // Set the Publisher property
            CopyrightYear = copyrightYear; // Set the CopyrightYear property
            CallNumber = callNumber;       // Set the CallNumber property
        }

        // Precondition:  None
        // Postcondition: Method sets _checkedOut to true
        public void CheckOut()
        {
            _checkedOut = true;
        }

        // Precondition:  None
        // Postcondition: Method sets _checkedOut to false
        public void ReturnToShelf()
        {
            _checkedOut = false;
        }

        // Precondition:  None
        // Postcondition: Method returns _checkedOut status
        public bool IsCheckedOut()
        {
            return _checkedOut;
        }

        // Precondition:  None
        // Postcondition: A string is returned using the specified book format
        public override string ToString()
        {
            return $"Title: {Title}{Environment.NewLine}" +
                   $"Author: {Author}{Environment.NewLine}" +
                   $"Publisher: {Publisher}{Environment.NewLine}" +
                   $"Copyright Year: {CopyrightYear}{Environment.NewLine}" +
                   $"Call Number: {CallNumber}{Environment.NewLine}" +
                   $"Checked Out: {IsCheckedOut()}";
        }
    }
}
