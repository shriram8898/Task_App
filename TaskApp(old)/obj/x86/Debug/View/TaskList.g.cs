﻿#pragma checksum "E:\TaskApp\View\TaskList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EED89889B280462DFC92EAB38C2EE3EF"
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
            case 3: // View\TaskList.xaml line 16
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 4: // View\TaskList.xaml line 17
                {
                    this.Minimize = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5: // View\TaskList.xaml line 26
                {
                    this.VisualState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6: // View\TaskList.xaml line 91
                {
                    this.contentDialog1 = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                }
                break;
            case 8: // View\TaskList.xaml line 116
                {
                    this.add = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.add).Click += this.add_Click;
                }
                break;
            case 9: // View\TaskList.xaml line 118
                {
                    this.cancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancel).Click += this.cancel_Click;
                }
                break;
            case 10: // View\TaskList.xaml line 121
                {
                    this.taskName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // View\TaskList.xaml line 122
                {
                    this.taskDetails = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12: // View\TaskList.xaml line 125
                {
                    this.priority = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 13: // View\TaskList.xaml line 127
                {
                    this.Assignto = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 14: // View\TaskList.xaml line 138
                {
                    this.collective = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 15: // View\TaskList.xaml line 140
                {
                    this.startDate = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 16: // View\TaskList.xaml line 142
                {
                    this.endDate = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 18: // View\TaskList.xaml line 34
                {
                    this.listView = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 19: // View\TaskList.xaml line 41
                {
                    this.Task1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20: // View\TaskList.xaml line 57
                {
                    this.stark1 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 21: // View\TaskList.xaml line 65
                {
                    global::Windows.UI.Xaml.Controls.ScrollViewer element21 = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                    ((global::Windows.UI.Xaml.Controls.ScrollViewer)element21).ViewChanged += this.scroll_ViewChanged;
                }
                break;
            case 22: // View\TaskList.xaml line 87
                {
                    this.Notask = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23: // View\TaskList.xaml line 66
                {
                    this.tasks = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.tasks).ItemClick += this.SelectedTask_ItemClick;
                }
                break;
            case 27: // View\TaskList.xaml line 58
                {
                    this.two = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 28: // View\TaskList.xaml line 59
                {
                    this.three = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 29: // View\TaskList.xaml line 60
                {
                    this.four = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 30: // View\TaskList.xaml line 61
                {
                    this.five = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 31: // View\TaskList.xaml line 62
                {
                    this.six = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 32: // View\TaskList.xaml line 63
                {
                    this.seven = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 33: // View\TaskList.xaml line 43
                {
                    this.Add_task = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Add_task).Click += this.Add_task_Click;
                }
                break;
            case 34: // View\TaskList.xaml line 44
                {
                    this.filters = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 35: // View\TaskList.xaml line 54
                {
                    this.searchitem = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.searchitem).TextChanged += this.SearchBox_QueryChanged;
                }
                break;
            case 36: // View\TaskList.xaml line 48
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element36 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element36).Click += this.filter_Click;
                }
                break;
            case 37: // View\TaskList.xaml line 49
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element37 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element37).Click += this.filter_Click;
                }
                break;
            case 38: // View\TaskList.xaml line 50
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

