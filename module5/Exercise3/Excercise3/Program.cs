using System;

namespace Excercise3
{
    class Book
    {
        public string Title { get; set; }
        public int NumPages { get; set; }
        public double Price { get; set; }

        public void Message()
        {
            Console.WriteLine("Title to the book is {0}.", this.Title);
        }
    }
    
    class BookObjects
    {
        public static void Main()
        {
            Book b1 = new Book();
            b1.Title = "Gone with the Wind";
            b1.Message();

            Console.ReadLine();
        }
    }
}
