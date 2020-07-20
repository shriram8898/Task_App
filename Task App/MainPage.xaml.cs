using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Task_App.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Task_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public PassData pd = new PassData();
        public MainPage()
        {
            this.InitializeComponent();
            //DataBase.CREATE();
            user.Text = "stark0648@gmail.com";
            pass.Text = "stark123";
        }

        private async void login_Click(object sender, RoutedEventArgs e)
        {
            string us = user.Text;
            string pas = pass.Text;
            if (us == "" || pas == "")
            {
                return;
            }
            else
            {
                pd.emp = await DataLayer.getSelectedEmployee(us, pas);
                if (pd.emp.id != null)
                {
                    Frame.Navigate(typeof(DashBoard), pd);
                }
                else
                {
                    string message = "OOPS!! Please Check Your Username or Password ";
                    MessageDialog md = new MessageDialog(message, "Invalid Login");
                    await md.ShowAsync();
                }
            }
        }
    }
}
