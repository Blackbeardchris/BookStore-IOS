using Foundation;
using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using UIKit;

namespace BookStore
{
    partial class BooksTableViewController : UITableViewController
    {
        List<Book> bookList;
        public BooksTableViewController (IntPtr handle) : base (handle)
        {
            bookList = new List<Book>();
            //add as many books
            bookList.Add(new Book()
            {
                Author = "J.K. Rowling",
                Name = "Harry Potter and the Sorcerer's Stone",
                Publisher = "Bloomsbury",
                Year = 1997
            });

			bookList.Add(new Book()
			{
				Author = "J.K. Rowling",
				Name = "Harry Potter and the Chamber of Secrets",
				Publisher = "Bloomsbury",
				Year = 1998
			});

			bookList.Add(new Book()
			{
				Author = "J.K. Rowling",
				Name = "Harry Potter and the Prisoner of Azkaban",
				Publisher = "Bloomsbury",
				Year = 1999
			});
        }
        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
            //only one section needed
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return bookList.Count;
            //counts the amount in the booklist
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("Book")as BookTableViewCell;
            //uses the booktableviewcell
            //grabs reusable cell

            var data = bookList[indexPath.Row];
                                 //current row
            //data displayed in the cell

            cell.BookData = data.Name;

            return cell;
            //retrieve cell and return to use in tableview
        }
    }

    public class Book
    {
        public string Name;
        public string Author;
        public string Publisher;
        public int Year;
    }
}