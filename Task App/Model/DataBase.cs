using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Web.Http;

namespace Task_App.Model
{
    public class DataBase
    {
        /// <summary>
        /// CREATING TABLES FR THE 1ST USE OF DATABASE
        /// </summary>
        public async static void CREATE()
        {
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "TaskApp.db");
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                string tableComman= "CREATE TABLE employee(empid VARCHAR,empname VARCHAR,designation VARCHAR,role VARCHAR,username VARCHAR,password VARCHAR);";
                db.Open();
                SqliteCommand createTable = new SqliteCommand(tableComman, db);
                //createTable.ExecuteReader();
                tableComman = "CREATE TABLE taskdetails(id VARCHAR,name VARCHAR,details VARCHAR,assignedto VARCHAR,assignedtoid VARCHAR,assignedby VARCHAR,assignedbyid VARCHAR," +
                    "Updated DATE,Created DATE,Completed DATE,Priority VARCHAR,Status VARCHAR,Collective VARCHAR,taskid VARCHAR,taskname VARCHAR,startdate VARCHAR,enddate VARCHAR);";
                createTable = new SqliteCommand(tableComman, db);
                createTable.ExecuteReader();
                tableComman = "INSERT INTO employee(empid,empname,designation,role,username,password)" +
                    "VALUES('001','shriram','member','developer','shri8858@gmail.com','shriram8898');";
                createTable = new SqliteCommand(tableComman, db);
                //createTable.ExecuteReader();
            }
        }

        public async static Task<ObservableCollection<Team>> LoadTeam(string tableCommand)
        {
            ObservableCollection<Team> teams = new ObservableCollection<Team>();
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "TaskApp.db");
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {

                db.Open();
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                SqliteDataReader reader = await createTable.ExecuteReaderAsync();
                while(reader.Read())
                {
                    teams.Add(new Team { name = reader.GetString(0), type = reader.GetString(1), manager = reader.GetString(2) });
                }
            }
            return teams;
        }

        /// <summary>   
        /// CHECKING THE LOGIN PROCESS AND GETTING THE CUREENT LOGIN USER DETAILS
        /// </summary>

        public async static Task<Employee> VerifyDatabase(string tableCommand)
        {
            Employee emp = new Employee();
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "TaskApp.db");
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                SqliteDataReader reader = await createTable.ExecuteReaderAsync();
                if (reader.Read())
                {
                    emp = new Employee
                    {
                        id = reader.GetString(0),
                        name = reader.GetString(1),
                        designation = reader.GetString(3),
                        username = reader.GetString(4),
                        password = reader.GetString(5),
                        role = reader.GetString(2)
                    };
                    return emp;
                }
            }
            return emp;
        }

        /// <summary>
        /// READ TASK FROM THE DATABASE BASED ON THE CONDITION IN TASKLIST WINDOW
        /// </summary>
        public async static Task<ObservableCollection<TaskDetails>> ReadDataDb(string tableCommand)
        {
            ObservableCollection<TaskDetails> tds = new ObservableCollection<TaskDetails>();
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "TaskApp.db");
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                SqliteDataReader reader = await createTable.ExecuteReaderAsync();
                while (reader.Read())
                    {
                   var value = new TaskDetails
                    {
                        id = reader.GetString(0),
                        name = reader.GetString(1),
                        details = reader.GetString(2),
                        Assign_to = reader.GetString(3),
                        Assign_to_id = reader.GetString(4),
                        Assign_by = reader.GetString(5),
                        Assign_by_id = reader.GetString(6),
                        updated = reader.GetDateTime(7),
                        createdDate = reader.GetDateTime(8),
                        priority = reader.GetString(10),
                        status = reader.GetString(11),
                        collective = reader.GetString(12),
                        startdate=new DateTimeOffset(Convert.ToDateTime(reader.GetString(15))),
                        enddate=new DateTimeOffset(Convert.ToDateTime(reader.GetString(16)))
                    };
                    string[] sp = value.id.Split('-');
                    if(sp[0]=="ST")
                    {
                        value.taskid = reader.GetString(13);
                        value.taskname = reader.GetString(14);
                    }
                    tds.Add(value);
                }
            }
            return tds;
        }

        internal async static Task<ObservableCollection<string>> LoadTeam1(string tableCommand)
        {
            ObservableCollection<string> value = new ObservableCollection<string>();
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "TaskApp.db");
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                SqliteDataReader reader = await createTable.ExecuteReaderAsync();
                while (reader.Read())
                {
                    value.Add(reader.GetString(0));
                }

            }
            return value;
        }

        public async static Task<string> EmpDetails(string tableCommand)
        {
            string value = "";
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "TaskApp.db");
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                SqliteDataReader reader = await createTable.ExecuteReaderAsync();
                if (reader.Read())
                {
                    value = reader.GetString(0) + "-" + reader.GetString(1);
                }

            }
            return value;
        }

        public async static Task<ObservableCollection<Employee>> EmployeeDetails(string tableCommand)
        {
            ObservableCollection<Employee> assign = new ObservableCollection<Employee>();
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "TaskApp.db");
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                SqliteDataReader reader = await createTable.ExecuteReaderAsync();
                while (reader.Read())
                {
                    assign.Add(new Employee { id = reader.GetString(0), name = reader.GetString(1), role = reader.GetString(3), designation = reader.GetString(2), username = reader.GetString(4) });
                }
            }
            return assign;
        }

        ///Summary
        ///GET members FROM THE MEMBERS TABLE
        ///summary

        public static async Task<ObservableCollection<members>> LoadTeams(string tableCommand)
        {
            ObservableCollection<members> teams = new ObservableCollection<members>();
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "TaskApp.db");
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                SqliteDataReader reader = await createTable.ExecuteReaderAsync();
                while (reader.Read())
                    teams.Add(new members { name = reader.GetString(0), empid = reader.GetString(1), empname = reader.GetString(2), designation = reader.GetString(3), role = reader.GetString(4) });
            }
            return teams;
        }

        public async static Task<string> FileReader(string tableCommand)
        {
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "TaskApp.db");
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                string Value;
                db.Open();
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                SqliteDataReader reader = await createTable.ExecuteReaderAsync();
                if (reader.Read())
                {
                    Value = reader.GetString(4);
                    return Value;
                }
            }
            return null;
        }

        public async static Task<ObservableCollection<comments>> LoadCommentsFromDatabase(string tableCommand)
        {
            ObservableCollection<comments> comments = new ObservableCollection<comments>();
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "TaskApp.db");
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                SqliteDataReader reader = await createTable.ExecuteReaderAsync();
                while (reader.Read())
                {
                    comments.Add(new comments { id = reader.GetString(0), message = reader.GetString(3), empname = reader.GetString(2), 
                        empid = reader.GetString(1), dt =Convert.ToDateTime(reader.GetDateTime(4)) });
                }
            }
            return comments;
        }

        public async static Task<string> findIddb(string id)
        {
            for (int i = 1; i < 1000; i++)
            {
                string tableCommand;
                string s = id + i.ToString();
                string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "TaskApp.db");
                using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
                {
                    db.Open();                   
                    tableCommand = "SELECT * FROM taskdetails WHERE id='" + s + "' ;";
                    SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                    SqliteDataReader reader = await createTable.ExecuteReaderAsync();
                    if (!reader.Read())
                    {
                        return s;
                    }

                }
            }
            return "No available taskId";
        }
        /// <summary>
        /// EXECUTING COMMANDS EG.DELETE,UPDATE,INSERT,ETC........
        /// </summary>
        public async static Task<bool> ExecuteCommand(string tableCommand)
        {
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "TaskApp.db");
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();
                SqliteCommand createTable = new SqliteCommand(tableCommand, db);
                SqliteDataReader reader =await createTable.ExecuteReaderAsync();
                if (reader.Read())
                    return true;
            }
            return false;
        }
    }
}
