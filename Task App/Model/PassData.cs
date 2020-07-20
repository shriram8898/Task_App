using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store.Preview.InstallControl;

namespace Task_App.Model
{
    public class PassData
    {
        public Employee emp { get; set; }
        public TaskDetails Selected { get; set; }
        public ObservableCollection<TaskDetails> tds = new ObservableCollection<TaskDetails>();
        public ObservableCollection<TaskDetails> previous = new ObservableCollection<TaskDetails>();
        public TaskDetails selection { get; set; }
    }
}
