using Foundation;
using System;
using UIKit;
//controls the cell, to do whatever needed
namespace BookStore
{
    public partial class BookTableViewCell : UITableViewCell
    {
        private Book bookData;
        public Book BookData
        {
            get { return bookData; }
            //when bookdata gets a value it looks at these below
            set {
                bookData = value;

                bookAuthorLabel.Text = bookData.Author;
                bookNameLabel.Text = bookData.Name;
                bookYearLabel.Text = bookData.Year.ToString();
                bookEditorLabel.Text = bookData.Editor;
                //accessing the labels
                    
            }
        }
        public BookTableViewCell (IntPtr handle) : base (handle)
        {
            
        }
    }
}