﻿#pragma checksum "E:\TaskApp\View\TaskList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1D2A533155512D65D70E6CD6C710DFB9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskApp.View
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
            case 2: // View\TaskList.xaml line 12
                {
                    this.cvs = (global::Windows.UI.Xaml.Data.CollectionViewSource)(target);
                }
                break;
            case 3: // View\TaskList.xaml line 76
                {
                    this.contentDialog1 = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                }
                break;
            case 5: // View\TaskList.xaml line 101
                {
                    this.add = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.add).Click += this.add_Click;
                }
                break;
            case 6: // View\TaskList.xaml line 103
                {
                    this.cancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancel).Click += this.cancel_Click;
                }
                break;
            case 7: // View\TaskList.xaml line 106
                {
                    this.taskName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // View\TaskList.xaml line 107
                {
                    this.taskDetails = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // View\TaskList.xaml line 110
                {
                    this.priority = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 10: // View\TaskList.xaml line 112
                {
                    this.Assignto = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 11: // View\TaskList.xaml line 123
                {
                    this.collective = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 12: // View\TaskList.xaml line 125
                {
                    this.startDate = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 13: // View\TaskList.xaml line 127
                {
                    this.endDate = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 15: // View\TaskList.xaml line 16
                {
                    this.listView = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 16: // View\TaskList.xaml line 72
                {
                    this.Notask = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // View\TaskList.xaml line 43
                {
                    this.stark1 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 18: // View\TaskList.xaml line 51
                {
                    this.tasks = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.tasks).ItemClick += this.SelectedTask_ItemClick;
                }
                break;
            case 22: // View\TaskList.xaml line 44
                {
                    this.two = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23: // View\TaskList.xaml line 45
                {
                    this.three = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 24: // View\TaskList.xaml line 46
                {
                    this.four = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 25: // View\TaskList.xaml line 47
                {
                    this.five = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 26: // View\TaskList.xaml line 48
                {
                    this.six = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 27: // View\TaskList.xaml line 49
                {
                    this.seven = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 28: // View\TaskList.xaml line 28
                {
                    this.Add_task = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Add_task).Click += this.Add_task_Click;
                }
                break;
            case 29: // View\TaskList.xaml line 33
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element29 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element29).Click += this.filter_Click;
                }
                break;
            case 30: // View\TaskList.xaml line 34
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element30 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element30).Click += this.filter_Click;
                }
                break;
            case 31: // View\TaskList.xaml line 35
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

