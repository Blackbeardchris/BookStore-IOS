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
                Editor = "Bloomsbury",
                Year = 1997,
                ImagePath = "Images/harry-1.jpg"
            });

			bookList.Add(new Book()
			{
				Author = "J.K. Rowling",
				Name = "Harry Potter and the Chamber of Secrets",
				Editor = "Bloomsbury",
				Year = 1998,
                ImagePath = "Images/harry-2.jpg"
			});

			bookList.Add(new Book()
			{
				Author = "J.K. Rowling",
				Name = "Harry Potter and the Prisoner of Azkaban",
				Editor = "Bloomsbury",
				Year = 1999,
                ImagePath = "Images/harry-3.jpg"
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
            var cell = tableView.DequeueReusableCell("Book") as BookTableViewCell;
            //uses the booktableviewcell
            //grabs reusable cell

            var data = bookList[indexPath.Row];
            //current row
            //data displayed in the cell

            cell.BookData = data;

            return cell;
        }
            //retrieve cell and return to use in tableview
        public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
            {
            if (segue.Identifier == "DetailsSegue")
                {
                    var navigationController = segue.DestinationViewController as DetailViewController;

                    if (navigationController != null)
                    {
                        var rowPath = TableView.IndexPathForSelectedRow;
                        var selectedData = bookList[rowPath.Row];
                        navigationController.selectedBook = selectedData;

                }
            }
        }
    }

    public class Book
    {
        public string Name;
        public string Author;
        public string Editor;
        public int Year;
        public string ImagePath;
    }
}