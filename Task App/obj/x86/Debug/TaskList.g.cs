﻿#pragma checksum "E:\Zoho(pt3644)\Task Management\Task App\TaskList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "247002F0F68259551CB4C343890427AC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task_App
{
    partial class TaskList : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // TaskList.xaml line 13
                {
                    this.cvs = (global::Windows.UI.Xaml.Data.CollectionViewSource)(target);
                }
                break;
            case 3: // TaskList.xaml line 93
                {
                    this.contentDialog1 = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                }
                break;
            case 5: // TaskList.xaml line 118
                {
                    this.add = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.add).Click += this.add_Click;
                }
                break;
            case 6: // TaskList.xaml line 120
                {
                    this.cancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancel).Click += this.cancel_Click;
                }
                break;
            case 7: // TaskList.xaml line 123
                {
                    this.taskName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // TaskList.xaml line 124
                {
                    this.taskDetails = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // TaskList.xaml line 127
                {
                    this.priority = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 10: // TaskList.xaml line 129
                {
                    this.Assignto = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 11: // TaskList.xaml line 140
                {
                    this.collective = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 12: // TaskList.xaml line 142
                {
                    this.startDate = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 13: // TaskList.xaml line 144
                {
                    this.endDate = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 15: // TaskList.xaml line 17
                {
                    this.listView = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 16: // TaskList.xaml line 89
                {
                    this.Notask = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // TaskList.xaml line 60
                {
                    this.stark1 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 18: // TaskList.xaml line 68
                {
                    this.tasks = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.tasks).ItemClick += this.SelectedTask_ItemClick;
                }
                break;
            case 22: // TaskList.xaml line 61
                {
                    this.two = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23: // TaskList.xaml line 62
                {
                    this.three = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 24: // TaskList.xaml line 63
                {
                    this.four = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 25: // TaskList.xaml line 64
                {
                    this.five = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 26: // TaskList.xaml line 65
                {
                    this.six = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 27: // TaskList.xaml line 66
                {
                    this.seven = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 28: // TaskList.xaml line 42
                {
                    this.select = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.select).SelectionChanged += this.select_SelectionChanged;
                }
                break;
            case 29: // TaskList.xaml line 44
                {
                    this.employees = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 30: // TaskList.xaml line 46
                {
                    this.select1 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.select1).SelectionChanged += this.select1_SelectionChanged;
                }
                break;
            case 32: // TaskList.xaml line 29
                {
                    this.Add_task = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Add_task).Click += this.Add_task_Click;
                }
                break;
            case 33: // TaskList.xaml line 34
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element33 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element33).Click += this.filter_Click;
                }
                break;
            case 34: // TaskList.xaml line 35
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element34 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element34).Click += this.filter_Click;
                }
                break;
            case 35: // TaskList.xaml line 36
                {
                    this.filter = (global::Windows.UI.Xaml.Controls.MenuFlyoutSubItem)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

