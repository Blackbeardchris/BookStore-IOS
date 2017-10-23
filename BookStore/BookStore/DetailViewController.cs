using Foundation;
using System;
using UIKit;

namespace BookStore
{
    public partial class DetailViewController : UIViewController
    {
        public Book selectedBook;

        public DetailViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewWillAppear(bool animated)
        {
            bookNameLabel.Text = selectedBook.Name;
            bookImageView.Image = UIImage.FromFile(selectedBook.ImagePath);
        } 
    }
}