using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TaskApp.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace TaskApp.View
{
    public sealed partial class commentsUserControl : UserControl
    {
        public comments comments { get { return this.DataContext as comments; } }
        public ObservableCollection<comments> com = new ObservableCollection<comments>();
        public commentsUserControl()
        {
            this.InitializeComponent();
            this.DataContextChanged += (s, e) => Bindings.Update();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            string msgtime;
            DateTime dt = DateTime.Now;
            string final = "";
            var date = DateTime.Today.AddDays(-1).ToString("MM-dd-yyyy");
            var date1 = comments.dt.ToString("MM-dd-yyyy");
            DateTime dt1 = comments.dt;
            var times = new TimeSpan(dt1.Ticks - dt.Ticks);
            double delta = Math.Abs(times.TotalSeconds);
            if (delta < 60)
            {
                final = "few seconds ago";
            }
            else if (delta < 60 * 2)
            {
                final = "a minute ago";
            }
            else if (delta < 45 * 60)
            {
                final = Math.Abs(times.Seconds).ToString() + " minutes ago";
            }
            else if (delta < 90 * 60)
            {
                final = "an hour ago";
            }
            else if (delta < 24 * 60 * 60)
            {
                final = Math.Abs(times.Hours).ToString() + " hours ago";
            }
            else if (delta < 48 * 60 * 60)
            {
                final = "yesterday";

            }
            else
            {
                if (date != date)
                    final = comments.dt.ToString();
                else
                    final = "yesterday";
            }
            string picture = "Assets/" + comments.empid + ".jpg";
            var bitmapImage = new BitmapImage(new Uri(this.BaseUri, picture));
            pic.ProfilePicture = bitmapImage;
            time.Text = final;
        }
    }
}
