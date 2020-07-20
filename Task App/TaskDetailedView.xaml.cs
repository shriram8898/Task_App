﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Task_App.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
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
    public sealed partial class TaskDetailedView : Page
    {
        public PassData pd = new PassData();
        public TaskDetails selected = new TaskDetails();
        public ObservableCollection<TaskDetails> tds = new ObservableCollection<TaskDetails>();
        public ObservableCollection<TaskDetails> source = new ObservableCollection<TaskDetails>();
        public ObservableCollection<comments> com1 = new ObservableCollection<comments>();
        public TaskDetailedView()
        {
            
            
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            pd = e.Parameter as PassData;
            this.DataContext = pd.Selected;
            this.InitializeComponent();
            source = pd.tds;
            tasks.ItemsSource = pd.tds;            
            taskpriority.Items.Clear();
            taskstatus.Items.Clear();
            taskrelated.Items.Clear();
            taskpriority.Items.Add("High");
            taskpriority.Items.Add("Medium");
            taskpriority.Items.Add("Low");
            taskstatus.Items.Add("Open");
            taskstatus.Items.Add("Close");
            taskrelated.Items.Add("Other");
            taskrelated.Items.Add("Login");
            taskrelated.Items.Add("sample");
            IntializeFrameData();
        }


        //
        public async void IntializeFrameData()
        {
            completed.Visibility = Visibility.Visible;
            if (!(pd.Selected.Assign_by_id == pd.emp.id || pd.emp.designation == "manager" || pd.emp.designation == "team lead"))
            {
                delete.Visibility = Visibility.Collapsed;
                //Edit.Visibility = Visibility.Collapsed;
                //taskrelated.IsEditable = false;
                //taskstatus.IsEnabled = false;
                //taskpriority.IsEnabled = false;
                //taskrelated.IsEnabled = false;
                //startDate1.IsEnabled = false;
                //endDate1.IsEnabled = false;
            }
            if (pd.Selected.Assign_to_id == pd.emp.id)
            {
                //completed.Visibility = Visibility.Visible;
            }
            files.Text = "";
            this.DataContext = pd.Selected;
            string[] value = pd.Selected.id.Split('-');
            if(value[0]=="T")
            {
                Back.Visibility = Visibility.Collapsed;
                tasks.SelectedItem = pd.Selected;
            }
            else
            {
                Back.Visibility = Visibility.Visible;
                var _value = pd.previous[pd.previous.Count - 1];
                tasks.SelectedItem = pd.selection;
                //tasks.SelectedItem = _value;
            }
            
            taskupdated.Text = pd.Selected.updated.ToString();
            taskcreated.Text = pd.Selected.createdDate.ToString();
            taskassignby.Text = pd.Selected.Assign_by + "(" + pd.Selected.Assign_by_id + ")";
            taskassignto.Text = pd.Selected.Assign_to + "(" + pd.Selected.Assign_to_id + ")";
            taskid.Text = pd.Selected.id;
            taskpriority.SelectedItem = pd.Selected.priority;
            taskstatus.SelectedItem = pd.Selected.status;
            taskrelated.SelectedItem = pd.Selected.collective;
            LoadSubTask();
        }

        private async void LoadSubTask()
        {           
            tds.Clear();
            tds = await Task.Run(()=>DataLayer.LoadSub(pd.Selected));                 
            this.cvs.Source = null;
            var groups = from c in tds
                         group c by c.taskname;
            this.cvs.Source = groups;
            com1 =await  Task.Run(()=>DataLayer.LoadComment(pd.Selected));
            commentsSection.ItemsSource = com1;
            string value= await Task.Run(()=>DataLayer.LoadFiles(pd.Selected));
            if(value!=null)
            files.Text = value;
        }

        private async void initializeData1()
        {
            priority.Items.Clear();
            priority.Items.Add("None");
            priority.Items.Add("Low");
            priority.Items.Add("Medium");
            priority.Items.Add("High");
            taskName.Text = "";
            taskDetails.Text = "";
            priority.SelectedIndex = 0;
            Assignto.SelectedIndex = -1;
            var temp = await LoadTeamMembers();
            ObservableCollection<EmployeeDisplay> temp1 = new ObservableCollection<EmployeeDisplay>();
            foreach (var items in temp)
            {
                string[] item = items.Split(' ');
                string pic = "Assets/" + item[1] + ".jpg";
                temp1.Add(new EmployeeDisplay { name = item[0], Img = new BitmapImage(new Uri(this.BaseUri, pic)), empid = item[1] });
            }
            Assignto.ItemsSource = temp1;
        }
        private async void initializeData()
        {
            priority1.Items.Clear();
            collective1.Items.Clear();
            status.Items.Clear();
            priority1.Items.Add("None");
            priority1.Items.Add("Low");
            priority1.Items.Add("Medium");
            priority1.Items.Add("High");
            collective1.Items.Add("sample");
            collective1.Items.Add("Login");
            collective1.Items.Add("Other");
            status.Items.Add("Open");
            status.Items.Add("Close");

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
                foreach (string item in items)
                {
                    tableCommand = "SELECT * FROM members WHERE name='" + item + "';";
                    var teams1 = await DataBase.LoadTeams(tableCommand);
                    foreach (var it in teams1)
                        select1.Add(it.empname + " " + it.empid);

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
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            pd.previous.Clear();
            pd.tds.Clear();
            this.Frame.Navigate(typeof(TaskList), pd);
        }

        private async void delete_Click(object sender, RoutedEventArgs e)
        {
            await DataLayer.DeleteAll(pd.Selected);
            this.Frame.Navigate(typeof(TaskList), pd);
        }

        private async void Edit_Click(object sender, RoutedEventArgs e)
        {
            initializeData();
            await contentDialog2.ShowAsync();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if(pd.previous.Count!=0)
            {
                Back.Visibility = Visibility.Collapsed;
                pd.Selected = pd.previous[pd.previous.Count - 1];
                pd.previous.RemoveAt(pd.previous.Count - 1);
                IntializeFrameData();
            }
        }

        private async void completed_Click(object sender, RoutedEventArgs e)
        {
            string name = pd.Selected.name + " task is CLOSED.";
            MessageDialog message = new MessageDialog(name);
            await message.ShowAsync();
            completed.Visibility = Visibility.Visible;
            taskstatus.SelectedItem = "Close";
            await DataLayer.Update(pd.Selected);
        }

        private async void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (taskpriority.SelectedIndex == -1)
                return;
            string prior = taskpriority.SelectedItem.ToString();
            await DataLayer.Update1(prior, pd.Selected,"priority");
        }

        private async void combo_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (taskstatus.SelectedIndex == -1)
                return;
            string prior = taskstatus.SelectedItem.ToString();
            await DataLayer.Update1(prior, pd.Selected, "status");
        }

        private async void combo_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
            if (taskrelated.SelectedIndex == -1)
                return;
            string prior = taskrelated.SelectedItem.ToString();
            await DataLayer.Update1(prior, pd.Selected, "collective");

        }

        private async void Comment_Click(object sender, RoutedEventArgs e)
        {
            var dt  = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"); 
            string mess = pd.emp.name + ":" + combox.Text;
            await DataLayer.InsertToComments(pd.Selected.id, pd.emp.id, pd.emp.name, combox.Text, dt,"");            
            com1.Add(new comments { empname = pd.emp.name, message = combox.Text, dt =DateTime.Now, empid = pd.emp.id,});
            commentsSection.ItemsSource = null;
            commentsSection.ItemsSource = com1;
            combox.Text = "";
        }

        private async void upload_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".png");
            StorageFile file = await openPicker.PickSingleFileAsync();
            StringBuilder output = new StringBuilder();
            if (file != null)
            {
                files.Text = "";
                output.Append("File Name   :" + file.Name + "\n");
                output.Append("File Created:" + file.DateCreated);
                files.Text = output.ToString();
                files.Visibility = Visibility.Visible;
                var dt = DateTime.Now.ToString();
                await DataLayer.InsertToComments(pd.Selected.id, pd.emp.id, pd.emp.name, output.ToString(), dt,"files");
                
            }
        }

        private async void subtask_Click(object sender, RoutedEventArgs e)
        {
            initializeData1();
            await contentDialog1.ShowAsync();
        }

        private async void add_Click(object sender, RoutedEventArgs e)
        {
            string name = taskName.Text;
            string details = taskDetails.Text;
            string prior = priority.SelectedItem.ToString();
            var emplo = (EmployeeDisplay)Assignto.SelectedItem;
            string asign = emplo.name + " " + emplo.empid;
            string[] values = startDate2.Date.ToString().Split('+');
            var startdate = values[0];
            string[] values1 = endDate2.Date.ToString().Split('+');
            var enddate = values1[0];
            if (name == "" || details == "" || asign == "")
                return;
            else
            {
                await writeinDb(name, details, prior, asign,startdate,enddate);
                taskName.Text = "";
                taskDetails.Text = "";
                priority.SelectedIndex = 0;
                Assignto.SelectedIndex = -1;
                contentDialog1.Hide();
                pd.previous.Add(pd.Selected);
                string[] value = pd.Selected.id.Split('-');
                if (value[0] == "T")
                    pd.selection = pd.Selected;
                pd.Selected = selected;                
                this.Frame.Navigate(typeof(TaskDetailedView), pd);
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            contentDialog1.Hide();
        }

        private async void save_Click(object sender, RoutedEventArgs e)
        {
            string name = taskName1.Text;
            string details = taskDetails1.Text;
            string prior = priority1.SelectedItem.ToString();
            string coll = collective1.SelectedItem.ToString();
            string status = "Open";
            string[] values = startDate.Date.ToString().Split('+');
            var startdate = values[0];
            string[] values1 = endDate.Date.ToString().Split('+');
            var enddate = values1[0];
            var dt = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
            pd.Selected.updated = DateTime.Now; pd.Selected.name = name; pd.Selected.details = details; pd.Selected.priority = prior; pd.Selected.status = status;
            pd.Selected.collective = coll;pd.Selected.startdate = Convert.ToDateTime(startdate);pd.Selected.enddate = Convert.ToDateTime(enddate);
            await DataLayer.Update2(dt, name, details, prior, status, coll, pd.Selected.id,startdate,enddate);           
            contentDialog2.Hide();
        }

        private void cancel1_Click(object sender, RoutedEventArgs e)
        {
            contentDialog2.Hide();
        }

        private void edit1_Click(object sender, RoutedEventArgs e)
        {
            taskDetails1.Visibility = Visibility.Visible;
        }

        private void subtaskview_ItemClick(object sender, ItemClickEventArgs e)
        {
            pd.previous.Add(pd.Selected);
            var clickedItem = (TaskDetails)e.ClickedItem;
            string[] value = pd.Selected.id.Split('-');
            if (value[0] == "T")
                pd.selection = pd.Selected;
            pd.Selected = clickedItem;
            this.Frame.Navigate(typeof(TaskDetailedView), pd);
        }

        private void tasks_ItemClick(object sender, ItemClickEventArgs e)
        {
            var value = e.ClickedItem as TaskDetails;            
            pd.Selected = value;
            IntializeFrameData();
        }


        private async Task writeinDb(string name, string details, string prior, string asign,string _startdate,string _enddate)
        {
            string n = await DataBase.findIddb("ST-");
            string[] assigned = asign.Split(" ");
            string status = "Open";
            string coll = pd.Selected.collective;
            var dt = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
            bool results = await DataLayer.WriteInDataBase(n, name, details, assigned[0], assigned[1], pd.emp.name, pd.emp.id,dt,prior,status,coll,pd.Selected.id,pd.Selected.name,_startdate,_enddate);
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
                taskid = pd.Selected.id,
                taskname = pd.Selected.name,
                startdate=Convert.ToDateTime(_startdate),
                enddate=Convert.ToDateTime(_enddate)
            };
            tds.Add(selected);
        }

        private async void endDate1_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            string[] values = endDate1.Date.ToString().Split('+');
            string[] val = values[0].Split(' ');
            if (val[0] == "01-01-1920")
                return;
            string prior = values[0];
            await DataLayer.Update1(prior, pd.Selected, "enddate");
        }

        private async void startDate1_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            string[] values = startDate1.Date.ToString().Split('+');
            string[] val = values[0].Split(' ');
            if (val[0] == "01-01-1920")
                return;
            string prior = values[0];
            await DataLayer.Update1(prior, pd.Selected, "startdate");
        }
    }
}
