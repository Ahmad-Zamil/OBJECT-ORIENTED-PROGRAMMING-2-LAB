using System;
namespace BookTask

{

    class Book

    {



        private String bookName;

        private String bookAuthor;

        private String bookId;

        private String bookType;

        private int bookCopy;



        public Book()

        {

            Console.WriteLine("default constructor");

        }

        public Book(String bookName, String bookAuthor, String bookId, String bookType, int bookCopy)

        {

            this.bookName = bookName;

            this.bookAuthor = bookAuthor;

            this.bookId = bookId;

            this.bookType = bookType;

            this.bookCopy = bookCopy;



        }
        public string BookName

        {

            set

            {

                this.bookName = value;

            }



            get

            {

                return this.bookName;

            }



        }

        public string BookAuthor

        {

            set

            {

                this.bookAuthor = value;

            }



            get

            {

                return this.bookAuthor;

            }



        }

        public string BookId

        {

            set

            {

                this.bookId = value;

            }



            get

            {

                return this.bookId;

            }



        }

        public String BookType

        {

            set

            {

                this.bookType = value;

            }



            get

            {

                return this.bookType;

            }

        }

        public int BookCopy

        {

            set

            {

                this.bookCopy = value;

            }

            get

            {

                return this.bookCopy;

            }



        }







        public void showPropertyInfo()

        {

            Console.WriteLine("Book Name is      : " + BookName);

            Console.WriteLine("Book Author is    : " + BookAuthor);

            Console.WriteLine("Book ID is        : " + BookId);

            Console.WriteLine("Book Type is      : " + BookType);

            Console.WriteLine("Book Copy is      : " + BookCopy);



        }



        public void AddBookCopy(int x)

        {

            bookCopy = bookCopy + x;

            Console.WriteLine("After adding book Book Copy is: " + bookCopy);

        }



        static void Main(string[] args)

        {



            Book s1 = new Book("Tech Yourself", "Al Stevens", "11109", "CS", 9);

            Book s2 = new Book();



            Console.WriteLine("Showing from Property");

            s1.BookName = "Tech Smith";

            s1.BookAuthor = "Albert";

            s1.BookId = "111#hh";

            s1.BookType = "CS";

            s1.BookCopy = 12;

            s1.showPropertyInfo();

            s1.AddBookCopy(20);



            Console.ReadLine();







        }

    }

}