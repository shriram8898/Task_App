using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Task_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TaskList : Page
    {
        public PassData pd = new PassData();
        public ObservableCollection<TaskDetails> tds = new ObservableCollection<TaskDetails>();
        public ObservableCollection<string> temp = new ObservableCollection<string>();
        public TaskDetails selected;
        public TaskList()
        {
            this.InitializeComponent();
            select.Items.Add("All");
            select.Items.Add("Assigned by me");
            select.Items.Add("Assigned to");
            
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            pd = e.Parameter as PassData;
            select.SelectedIndex = 0;
            temp = await LoadTeamMembers();
            MenuFlyoutItemSettings(temp);

        }
        private async void Add_task_Click(object sender, RoutedEventArgs e)
        {
            initializeData();            
            await contentDialog1.ShowAsync();
        }        
        private async void select_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Notask.Visibility = Visibility.Collapsed;
            stark1.Visibility = Visibility.Visible;
            string value = select.SelectedItem.ToString();
            tds.Clear();
            if(value!="Assigned to")
            {

                employees.Visibility = Visibility.Collapsed;
                tds = await Task.Run(()=>DataLayer.GetTask(value,pd.emp));
                if (!(tds.Count > 0))
                {
                    stark1.Visibility = Visibility.Collapsed;
                    Notask.Visibility = Visibility.Visible;
                }
                var groups = from c in tds
                             group c by c.collective;
                this.cvs.Source = groups;
                tasks.SelectedIndex = -1;
            }
            else if (select.SelectedItem.ToString() == "Assigned to" && employees.Visibility != Visibility.Visible)
            {
                employees.Visibility = Visibility.Visible;
                
                ObservableCollection<EmployeeDisplay> temp1 = new ObservableCollection<EmployeeDisplay>();
                foreach (var items in temp)
                {
                    string[] item = items.Split(' ');
                    string pic = "Assets/" + item[1] + ".jpg";
                    temp1.Add(new EmployeeDisplay { name = item[0], Img = new BitmapImage(new Uri(this.BaseUri, pic)), empid = item[1] });
                }
                select1.ItemsSource = temp1;
                select1.SelectedIndex = -1;
                return;
            }
            
        }
        private async void select1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Notask.Visibility = Visibility.Collapsed;
            stark1.Visibility = Visibility.Visible;
            var emplo = (EmployeeDisplay)select1.SelectedItem;
            string val = emplo.empid;
            tds.Clear();
            tds = await DataLayer.GetTask(val, pd.emp);
            if (!(tds.Count > 0))
            {
                stark1.Visibility = Visibility.Collapsed;
                Notask.Visibility = Visibility.Visible;
            }
            var groups = from c in tds
                         group c by c.collective;
            this.cvs.Source = groups;
            tasks.SelectedIndex = -1;

        }

        private  void SelectedTask_ItemClick(object sender, ItemClickEventArgs e)
        {            
            pd.Selected = e.ClickedItem as TaskDetails;
            pd.tds = tds;
            this.Frame.Navigate(typeof(TaskDetailedView), pd);
        }

        private async Task<ObservableCollection<string>> LoadTeamMembers()
        {
            string tableCommand;
            ObservableCollection<members> teams = new ObservableCollection<members>();
            ObservableCollection<string> select1 = new ObservableCollection<string>();
            if (pd.emp.designation == "manager")
            {
                tableCommand = "SELECT * FROM teams WHERE empid='" + pd.emp.id + "';";
                select1.Add(pd.emp.name + " " + pd.emp.id);
                var items = await DataBase.LoadTeam1(tableCommand);
                foreach(string item in items)
                {
                    tableCommand = "SELECT * FROM members WHERE name='" + item + "';";
                    var teams1 = await DataBase.LoadTeams(tableCommand);
                    foreach (var it in teams1)
                        select1.Add(it.empname+" "+it.empid);
                    
                    return select1;

                }
                select1.Add(pd.emp.name + " " + pd.emp.id);
            }
            else
            {
                tableCommand = "SELECT * FROM members WHERE empid='" + pd.emp.id + "';";
                teams = await DataBase.LoadTeams(tableCommand);
            }
            
            foreach (var item in teams)
            {
                tableCommand = "SELECT * FROM members WHERE name='" + item.name + "';";
                var assign = await Task.Run(() => DataBase.LoadTeams(tableCommand));
                foreach (var vari in assign)
                {
                    string value = vari.empname + " " + vari.empid;
                    select1.Add(value);
                }                    
            }
            return select1;
        }

        //CONTENDIALOG BOX INTIALIZATION AND CORRESPONDING EVENT HANDLING
        private async void initializeData()
        {
            priority.Items.Clear();
            collective.Items.Clear();
            priority.Items.Add("None");
            priority.Items.Add("Low");
            priority.Items.Add("Medium");
            priority.Items.Add("High");
            collective.Items.Add("sample");
            collective.Items.Add("Login");
            collective.Items.Add("Other");
            taskName.Text = "";
            taskDetails.Text = "";
            priority.SelectedIndex = 0;
            Assignto.SelectedIndex = -1;
            collective.SelectedIndex = 2;
            temp = await LoadTeamMembers();
            ObservableCollection<EmployeeDisplay> temp1 = new ObservableCollection<EmployeeDisplay>();
            foreach (var items in temp)
            {
                string[] item = items.Split(' ');
                string pic = "Assets/" + item[1] + ".jpg";
                temp1.Add(new EmployeeDisplay { name = item[0], Img = new BitmapImage(new Uri(this.BaseUri, pic)), empid = item[1] });
            }
            
            Assignto.ItemsSource = temp1;
        }

       
        private async void add_Click(object sender, RoutedEventArgs e)
        {
            string name = taskName.Text;
            string details = taskDetails.Text;
            string prior = priority.SelectedItem.ToString();
            var emplo = (EmployeeDisplay)Assignto.SelectedItem;
            string asign = emplo.name + " " + emplo.empid;
            string coll = collective.SelectedItem.ToString();
            string[] values = startDate.Date.ToString().Split('+');
            var startdate = values[0];
            string[] values1 = endDate.Date.ToString().Split('+');
            var enddate = values1[0];
            if (name == "" || details == "" || asign == "" || coll == "")
                return;
            else
            {
                await writeinDb(name, details, prior, asign, coll,startdate,enddate);
                pd.Selected = selected;
                pd.tds = tds;
                this.Frame.Navigate(typeof(TaskDetailedView), pd);
                contentDialog1.Hide();
                taskName.Text = "";
                taskDetails.Text = "";
                priority.SelectedIndex = 0;
                Assignto.SelectedIndex = -1;
                collective.SelectedIndex = 2;                
                
            }
        }
        private async Task writeinDb(string name, string details, string prior, string asign, string coll,string startdate,string enddate)
        {
            string n = await DataBase.findIddb("T-");
            string[] assigned = asign.Split(" ");
            string status = "Open";
            var dt = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
            selected = new TaskDetails
            {
                id = n,
                Assign_by = pd.emp.name,
                Assign_by_id = pd.emp.id,
                Assign_to = assigned[0],
                Assign_to_id = assigned[1],
                collective = coll,
                details = details,
                name = name,
                updated = DateTime.Now,
                createdDate = DateTime.Now,
                priority = prior,
                status = status,
                startdate = Convert.ToDateTime(startdate),
                enddate = Convert.ToDateTime(enddate)
            };
            tds.Add(selected);
            bool results = await DataLayer.WriteInDataBase(n, name, details, assigned[0], assigned[1], pd.emp.name, pd.emp.id, dt, prior, status, coll,"","",startdate,enddate);
            
        }
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            contentDialog1.Hide();
        }

        private async void filter_Click(object sender, RoutedEventArgs e)
        {
            Notask.Visibility = Visibility.Collapsed;
            stark1.Visibility = Visibility.Visible;
            MenuFlyoutItem selectedItemFlyout = sender as MenuFlyoutItem;
            string value = selectedItemFlyout.Text.ToString();
            tds.Clear();
            if (value == "All"||value=="Assigned by me")
            {
                employees.Visibility = Visibility.Collapsed;
                tds = await Task.Run(()=>DataLayer.GetTask(value, pd.emp));
                
            }
            else
            {
                string[] support = value.Split(' ');
                tds = await Task.Run(()=>DataLayer.GetTask(support[1], pd.emp));
            }
            
            if (!(tds.Count > 0))
            {
                stark1.Visibility = Visibility.Collapsed;
                Notask.Visibility = Visibility.Visible;
            }
            var groups = from c in tds
                         group c by c.collective;
            this.cvs.Source = groups;
            tasks.SelectedIndex = -1;
            //MessageDialog messageDialog = new MessageDialog("Hello");
            //await messageDialog.ShowAsync();
        }
        private void MenuFlyoutItemSettings(ObservableCollection<string> temp)
        {
            MenuFlyout flyout = new MenuFlyout();
            foreach (var item in temp)
            {
                MenuFlyoutItem mi = new MenuFlyoutItem();
                string[] values = item.Split(' ');
                mi.Text = item;
                mi.Click += filter_Click;
                flyout.Items.Add(mi);
            }
            foreach (var item in flyout.Items)
            {
                filter.Items.Insert(filter.Items.Count, item);
            }
        }
    } 
}










/*
 * 
 * 
 * 
 * 
 * 
 *
     



*/
