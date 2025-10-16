using BooksEmployess.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BooksEmployess.Windows
{
    /// <summary>
    /// Interaction logic for ShowBook.xaml
    /// </summary>
    public partial class ShowBook : Window
    {
        public ShowBook(Dictionary<string, string> BookData)
        {
            init();
            this.Title = "Book Details";
            title.Text = BookData["title"];
            description.Text = BookData["description"];
            author.Text = BookData["author"];
            pages.Text = BookData["pages"];
            year.Text = BookData["year"];


            //poster.Source = new BitmapImage(new Uri(BookData["imagepath"]));
            //poster.Width = 300;
            //poster.Height = 300;
            //poster.SourceUpdated


            //Image myImage = new Image();
            //BitmapImage bitmap = new BitmapImage();
            //bitmap.BeginInit();
            //bitmap.UriSource = new Uri("https://placehold.co/300x400?text=Alice's+Adventures+in+Wonderland", UriKind.Absolute);
            //bitmap.EndInit();
            //poster.Source = bitmap;
            //poster.Height = bitmap.Height;
            //poster.Width = bitmap.Width;



        }

        // Replace the line causing the error with the following:



        private void init()
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;

        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            var image = new Image();
            var fullFilePath = @"https://placehold.co/300x400?text=Alice's+Adventures+in+Wonderland";

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();

            // image.Source = bitmap;
            poster.Source = bitmap;
            // MyStackPanel.Children.Add(image);
        }
    }
}
