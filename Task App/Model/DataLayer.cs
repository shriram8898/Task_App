using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments;
using Windows.Networking.NetworkOperators;

namespace Task_App.Model
{
    
    public class DataLayer
    {
        public static bool flag { get; set; } = true;
        public async static Task<Employee> getSelectedEmployee(string us,string pas)
        {
            Employee emp = new Employee();
            if(flag)
            {
                string tableCommand = "SELECT * FROM employee WHERE username='" + us + "' AND password='" + pas + "';";
                return await Task.Run(() => DataBase.VerifyDatabase(tableCommand));
            }
            return emp;
        }

        public async static Task<ObservableCollection<TaskDetails>> GetTask(string value,Employee emp)
        {
            ObservableCollection<TaskDetails> ts = new ObservableCollection<TaskDetails>();
           if (flag)
           {
                string tableCommand = "";
                if (value == "All")
                {
                    tableCommand = "SELECT * FROM taskdetails WHERE taskid='0';";
                }
                else if (value == "Assigned by me")
                {
                    tableCommand = "SELECT * FROM taskdetails WHERE assignedbyId='" + emp.id + "' AND taskid='0';";
                }
                else
                {
                    tableCommand = "SELECT * FROM taskdetails WHERE assignedtoId='" + value + "' AND taskid='0';";
                }
                ts = await Task.Run(() => DataBase.ReadDataDb(tableCommand));
            }            
            return ts;
        }

        public async static Task<bool> WriteInDataBase(string n, string name1, string details, string v1, string v2, string name2, string id, string dt, string prior, string status, string coll,string taskid,
            string taskname,string startdate,string enddate)
        {
           string tableCommand="";bool result=false;
           if(flag)
            {
                if(taskid=="")
                {
                    tableCommand = "INSERT INTO taskdetails(id,name,details,assignedto,assignedtoid,assignedby,assignedbyid,Updated,Created,Priority,Status,Collective,taskid,startdate,enddate)" +
                   "VALUES('" + n + "','" + name1 + "','" + details + "','" + v1 + "','" + v2 + "','" + name2 + "','" + id + "','" + dt + "','" + dt + "','" + prior + "','" + status + "','" + coll + "','0','"+startdate+"','"+enddate+"');";
                    result = await Task.Run(() => DataBase.ExecuteCommand(tableCommand));
                }
                else
                {
                   tableCommand = "INSERT INTO taskdetails(id,name,details,assignedto,assignedtoid,assignedby,assignedbyid,Updated,Created,Priority,Status,collective,taskid,taskname,startdate,enddate)" +
                   "VALUES('" + n + "','" + name1 + "','" + details + "','" + v1 + "','" + v2 + "','" + name2 + "','" + id + "','" + dt + "','" + dt + "','" + prior + "','" + status + "','" + coll + "','" + taskid + "','" + taskname + "','" + startdate + "','" + enddate + "');";
                   result = await DataBase.ExecuteCommand(tableCommand);
                }
                
            }
            return result;
        }

        internal async static Task InsertEmployee(string id1, string name1, string email1, string role1, string position1)
        {
           if(flag)
            {
                string tableCommand = "INSERT INTO employee(empid,empname,designation,role,username,password)" +
                "VALUES('" + id1 + "','" + name1 + "','" + position1 + "','" +  role1 + "','" + email1 + "','password');";
                bool result = await DataBase.ExecuteCommand(tableCommand);
            }
        }

        internal async static Task Insertteams(string name1, string type, string id, string name2)
        {
            string tableCommand;
            if(flag)
            {
                tableCommand = "INSERT INTO teams(name,type,empid,empname)" +
               "VALUES('" + name1 + "','" + type + "','" + id + "','" + name2 + "');";
                var result = await DataBase.ExecuteCommand(tableCommand);
            }
        }

        internal async static Task<ObservableCollection<members>> LoadingMembers(string name, string v)
        {
            ObservableCollection<members> mem = new ObservableCollection<members>();
            string tableCommand;
            if(flag)
            {
                if(v=="designation")
                {
                    tableCommand = "SELECT * FROM members WHERE name='" + name + "' AND designation='team leader';";
                    mem =await DataBase.LoadTeams(tableCommand);
                }
                else
                {
                    tableCommand = "SELECT * FROM members WHERE name='" + name + "';";
                    mem = await DataBase.LoadTeams(tableCommand);
                }
            }
            return mem;
        }

        internal async static Task<string> GetDetails(string v)
        {
            string value="";
            if(flag)
            {
                string tableCommand = "SELECT role,designation FROM employee WHERE empid='" + v + "';";
                value=await DataBase.EmpDetails(tableCommand);
            }
            return value;
        }

        internal async static Task<bool> InsertToMembers(string name, string v1, string v2, string v3, string v4)
        {
            bool result = false;
            string tableCommand;
            if(flag)
            {
                tableCommand = "INSERT INTO members(name,empid,empname,role,designation)" +
                "VALUES('" + name + "','" + v1 + "','" + v2 + "','" + v3 + "','" +v4 + "');";
                result=await DataBase.ExecuteCommand(tableCommand);
            }
            return result;
        }

        public async static Task<ObservableCollection<Team>> Load()
        {
            ObservableCollection<Team> t = new ObservableCollection<Team>();
            if(flag)
            {
                string tableCommand = "SELECT * FROM teams;";
                t=await DataBase.LoadTeam(tableCommand);
            }
            return t;
        }

        public async static Task<ObservableCollection<TaskDetails>> LoadSub(TaskDetails task)
        {
            string tableCommand = "";
            ObservableCollection<TaskDetails> ts=new ObservableCollection<TaskDetails>();
            if (flag)
            {
                tableCommand = "SELECT * FROM taskdetails WHERE taskid='" + task.id + "';";
                ts= await Task.Run(()=>DataBase.ReadDataDb(tableCommand));
            }
            return ts;
        }

        public async static Task<ObservableCollection<comments>> LoadComment(TaskDetails selected)
        {
            string tableCommand = "";
            ObservableCollection<comments> com1 = new ObservableCollection<comments>();
            if(flag)
            {
                tableCommand = "SELECT * FROM comment WHERE id='" + selected.id + "' ;";
                com1 = await Task.Run(()=>DataBase.LoadCommentsFromDatabase(tableCommand));
            }
            return com1;
        }

        public async static Task<string> LoadFiles(TaskDetails selected)
        {
            string tableCommand = "";
            string value="";
            if(flag)
            {
                tableCommand = "SELECT * FROM files WHERE taskid='" + selected.id + "';";
                value= await Task.Run(()=>DataBase.FileReader(tableCommand));
            }
            return value;
        }
        public async static Task DeleteAll(TaskDetails selected)
        {
            if(flag)
            {
                string tableCommand = "DELETE FROM taskdetails WHERE id='" + selected.id + "' OR taskid='" + selected.id + "';";
                bool result = await DataBase.ExecuteCommand(tableCommand);
                tableCommand = "DELETE FROM files WHERE taskid='" + selected.id + "';";
                result = await DataBase.ExecuteCommand(tableCommand);
                tableCommand = "DELETE FROM comment WHERE id='" + selected.id + "';";
                result = await DataBase.ExecuteCommand(tableCommand);
            }
        }

        internal async static Task<ObservableCollection<Employee>> LoadEmployees()
        {
            ObservableCollection<Employee> emp = new ObservableCollection<Employee>();
            if (flag)
            {
                string tableCommand = "SELECT * FROM employee;";
                emp=await DataBase.EmployeeDetails(tableCommand);
            }
            return emp;
        }

        internal async static Task Update(TaskDetails selected)
        {
            if(flag)
            {
                string tableCommand = "UPDATE taskdetails SET status='Close' WHERE id='" + selected.id + "'";
                bool result = await DataBase.ExecuteCommand(tableCommand);
            }
        }
           

        internal async static Task Update1(string prior, TaskDetails selected,string value)
        {
            if(flag)
            {
                if(value=="priority")
                {
                    string tableCommand = "UPDATE taskdetails SET Priority='" + prior + "' WHERE id='" + selected.id + "'";
                    bool result = await DataBase.ExecuteCommand(tableCommand);
                }
                else if(value=="status")
                {

                    string tableCommand = "UPDATE taskdetails SET Status='" + prior + "' WHERE id='" + selected.id + "'";
                    bool result = await DataBase.ExecuteCommand(tableCommand);
                }
                else if(value=="collective")
                {
                    string tableCommand = "UPDATE taskdetails SET Collective='" + prior + "' WHERE id='" + selected.id + "'";
                    bool result = await DataBase.ExecuteCommand(tableCommand);
                }
                else if(value=="enddate")
                {
                    string tableCommand = "UPDATE taskdetails SET enddate='" + prior + "' WHERE id='" + selected.id + "'";
                    bool result = await DataBase.ExecuteCommand(tableCommand);
                }
                else if(value=="startdate")
                {
                    string tableCommand = "UPDATE taskdetails SET startdate='" + prior + "' WHERE id='" + selected.id + "'";
                    bool result = await DataBase.ExecuteCommand(tableCommand);
                }
            }
            
        }
        internal async static Task InsertToComments(string id1, string id2, string name, string text, string dt,string value)
        {
            if(flag)
            {
                if(value=="files")
                {
                    string tableCommand = "INSERT INTO files(taskid,empname,empid,name,date)" +
                    "VALUES('" + id1 + "','" + name + "','" +id2 + "','" + text + "','" +Convert.ToDateTime(dt) + "');";
                    bool result = await DataBase.ExecuteCommand(tableCommand);
                }
                else
                {
                    string tableCommand = "INSERT INTO comment(id,empid,empname,message,date)" +
                    "VALUES('" + id1 + "','" + id2 + "','" + name + "','" + text + "','" + dt + "');";
                    bool result = await DataBase.ExecuteCommand(tableCommand);
                }
                
            }
        }
        internal async static Task Update2(string dt, string name, string details, string prior, string status, string coll, string id,string startdate,string enddate)
        {
           if(flag)
            {
                string tableCommand = "UPDATE taskdetails SET Updated='" + dt + "',name='" + name + "',details='" + details + "',Priority='" + prior + "',Status='" + status + "',Collective='" + coll + "',startdate='"+startdate+"',enddate='"+enddate+"' WHERE id='" + id + "'";
                bool result = await DataBase.ExecuteCommand(tableCommand);
            }
        }
    }
}
