using Foundation;
using System;
using UIKit;

namespace BookStore
{
    public partial class BooksTableViewController : UITableViewController
    {
        List<Book> bookList;
        public BooksTableViewController (IntPtr handle) : base (handle)
        {
            bookList = new List<Book>();
        }
    }

    public class Book
    {
        public string Name;
        public string Author;
        public string Editor;
        public int Year;
    }
}