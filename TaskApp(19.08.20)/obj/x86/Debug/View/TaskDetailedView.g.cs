﻿#pragma checksum "E:\TaskApp\View\TaskDetailedView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "36E18E1C1AECD75C8D4A0BE57427D4CF"
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
    partial class TaskDetailedView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class TaskDetailedView_obj59_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITaskDetailedView_Bindings
        {
            private global::TaskApp.Models.TaskDetails dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj59;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj59TextDisabled = false;

            public TaskDetailedView_obj59_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 253 && columnNumber == 93)
                {
                    isobj59TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 59: // View\TaskDetailedView.xaml line 253
                        this.obj59 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.TextBlock)target);
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj59.Target as global::Windows.UI.Xaml.Controls.TextBlock).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::TaskApp.Models.TaskDetails) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ITaskDetailedView_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::TaskApp.Models.TaskDetails)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::TaskApp.Models.TaskDetails obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_name(obj.name, phase);
                    }
                }
            }
            private void Update_name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // View\TaskDetailedView.xaml line 253
                    if (!isobj59TextDisabled)
                    {
                        if ((this.obj59.Target as global::Windows.UI.Xaml.Controls.TextBlock) != null)
                        {
                            XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text((this.obj59.Target as global::Windows.UI.Xaml.Controls.TextBlock), obj, null);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // View\TaskDetailedView.xaml line 13
                {
                    this.cvs = (global::Windows.UI.Xaml.Data.CollectionViewSource)(target);
                }
                break;
            case 3: // View\TaskDetailedView.xaml line 68
                {
                    this.listviewcolumn = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 4: // View\TaskDetailedView.xaml line 69
                {
                    this.detailviewcolumn = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 5: // View\TaskDetailedView.xaml line 277
                {
                    this.Recordings = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                }
                break;
            case 6: // View\TaskDetailedView.xaml line 332
                {
                    this.contentDialog2 = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                }
                break;
            case 7: // View\TaskDetailedView.xaml line 386
                {
                    this.contentDialog1 = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                }
                break;
            case 8: // View\TaskDetailedView.xaml line 441
                {
                    this.VideoRecorder = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                }
                break;
            case 9: // View\TaskDetailedView.xaml line 444
                {
                    this.videosText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // View\TaskDetailedView.xaml line 445
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.Button_Click;
                }
                break;
            case 11: // View\TaskDetailedView.xaml line 460
                {
                    this.PreviewControl = (global::Windows.UI.Xaml.Controls.CaptureElement)(target);
                }
                break;
            case 12: // View\TaskDetailedView.xaml line 462
                {
                    this.infos = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 13: // View\TaskDetailedView.xaml line 477
                {
                    this.cl = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.cl).Click += this.cl_Click;
                }
                break;
            case 14: // View\TaskDetailedView.xaml line 465
                {
                    this.time = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 15: // View\TaskDetailedView.xaml line 468
                {
                    this.HoursTextBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // View\TaskDetailedView.xaml line 470
                {
                    this.MinutesTextBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // View\TaskDetailedView.xaml line 472
                {
                    this.SecondsTextBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21: // View\TaskDetailedView.xaml line 411
                {
                    this.add = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.add).Click += this.add_Click;
                }
                break;
            case 22: // View\TaskDetailedView.xaml line 414
                {
                    this.cancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancel).Click += this.cancel_Click;
                }
                break;
            case 23: // View\TaskDetailedView.xaml line 417
                {
                    this.taskName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 24: // View\TaskDetailedView.xaml line 418
                {
                    this.taskDetails = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 25: // View\TaskDetailedView.xaml line 421
                {
                    this.priority = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 26: // View\TaskDetailedView.xaml line 423
                {
                    this.Assignto = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 27: // View\TaskDetailedView.xaml line 434
                {
                    this.startDate2 = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 28: // View\TaskDetailedView.xaml line 436
                {
                    this.endDate2 = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 31: // View\TaskDetailedView.xaml line 357
                {
                    this.save = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.save).Click += this.save_Click;
                }
                break;
            case 32: // View\TaskDetailedView.xaml line 359
                {
                    this.cancel1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancel1).Click += this.cancel1_Click;
                }
                break;
            case 33: // View\TaskDetailedView.xaml line 361
                {
                    this.taskName1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 34: // View\TaskDetailedView.xaml line 371
                {
                    this.priority1 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 35: // View\TaskDetailedView.xaml line 373
                {
                    this.collective1 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 36: // View\TaskDetailedView.xaml line 375
                {
                    this.status = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 37: // View\TaskDetailedView.xaml line 377
                {
                    this.startDate = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 38: // View\TaskDetailedView.xaml line 379
                {
                    this.endDate = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 39: // View\TaskDetailedView.xaml line 367
                {
                    this.taskDetails1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 40: // View\TaskDetailedView.xaml line 365
                {
                    this.edit1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.edit1).Click += this.edit1_Click;
                }
                break;
            case 41: // View\TaskDetailedView.xaml line 281
                {
                    this.voice = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 42: // View\TaskDetailedView.xaml line 283
                {
                    this.Play = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Play).Click += this.Pause_Click;
                }
                break;
            case 43: // View\TaskDetailedView.xaml line 300
                {
                    this.Record1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 44: // View\TaskDetailedView.xaml line 302
                {
                    this.timer = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 45: // View\TaskDetailedView.xaml line 311
                {
                    this.Stop = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Stop).Click += this.Stop_Click;
                }
                break;
            case 48: // View\TaskDetailedView.xaml line 305
                {
                    this.HoursTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 49: // View\TaskDetailedView.xaml line 307
                {
                    this.MinutesTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 50: // View\TaskDetailedView.xaml line 309
                {
                    this.SecondsTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 53: // View\TaskDetailedView.xaml line 120
                {
                    this.taskname = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 54: // View\TaskDetailedView.xaml line 122
                {
                    this.detsila = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 55: // View\TaskDetailedView.xaml line 202
                {
                    this._pivot = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 56: // View\TaskDetailedView.xaml line 247
                {
                    this.subtask = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.subtask).Click += this.subtask_Click;
                }
                break;
            case 57: // View\TaskDetailedView.xaml line 249
                {
                    this.subtaskview = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.subtaskview).ItemClick += this.subtaskview_ItemClick;
                }
                break;
            case 61: // View\TaskDetailedView.xaml line 241
                {
                    this.upload = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.upload).Click += this.upload_Click;
                }
                break;
            case 62: // View\TaskDetailedView.xaml line 242
                {
                    this.files = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 63: // View\TaskDetailedView.xaml line 207
                {
                    this.commen = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 64: // View\TaskDetailedView.xaml line 228
                {
                    this.combox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 65: // View\TaskDetailedView.xaml line 230
                {
                    this.Video = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Video).Click += this.VideoRecod_Click;
                }
                break;
            case 66: // View\TaskDetailedView.xaml line 232
                {
                    this.Records = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Records).Click += this.Records_Click;
                }
                break;
            case 67: // View\TaskDetailedView.xaml line 234
                {
                    global::Windows.UI.Xaml.Controls.Button element67 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element67).Click += this.Comment_Click;
                }
                break;
            case 68: // View\TaskDetailedView.xaml line 209
                {
                    this.commentsSection = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 71: // View\TaskDetailedView.xaml line 126
                {
                    this.td = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 72: // View\TaskDetailedView.xaml line 128
                {
                    this.Panel1 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 73: // View\TaskDetailedView.xaml line 142
                {
                    this.Panel2 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 74: // View\TaskDetailedView.xaml line 156
                {
                    this.Panel3 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 75: // View\TaskDetailedView.xaml line 170
                {
                    this.Panel4 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 76: // View\TaskDetailedView.xaml line 184
                {
                    this.Panel5 = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 77: // View\TaskDetailedView.xaml line 195
                {
                    this.endDate1 = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarDatePicker)this.endDate1).DateChanged += this.endDate1_DateChanged;
                }
                break;
            case 78: // View\TaskDetailedView.xaml line 188
                {
                    this.startDate1 = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarDatePicker)this.startDate1).DateChanged += this.startDate1_DateChanged;
                }
                break;
            case 79: // View\TaskDetailedView.xaml line 180
                {
                    this.taskrelated = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.taskrelated).SelectionChanged += this.combo_SelectionChanged_2;
                }
                break;
            case 80: // View\TaskDetailedView.xaml line 174
                {
                    this.taskstatus = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.taskstatus).SelectionChanged += this.combo_SelectionChanged_1;
                }
                break;
            case 81: // View\TaskDetailedView.xaml line 166
                {
                    this.taskpriority = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.taskpriority).SelectionChanged += this.combo_SelectionChanged;
                }
                break;
            case 82: // View\TaskDetailedView.xaml line 160
                {
                    this.taskupdated = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 83: // View\TaskDetailedView.xaml line 152
                {
                    this.taskassignby = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 84: // View\TaskDetailedView.xaml line 146
                {
                    this.taskassignto = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 85: // View\TaskDetailedView.xaml line 138
                {
                    this.taskcreated = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 86: // View\TaskDetailedView.xaml line 132
                {
                    this.taskid = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 87: // View\TaskDetailedView.xaml line 109
                {
                    this.exit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.exit).Click += this.exit_Click;
                }
                break;
            case 88: // View\TaskDetailedView.xaml line 111
                {
                    this.delete = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.delete).Click += this.delete_Click;
                }
                break;
            case 89: // View\TaskDetailedView.xaml line 113
                {
                    this.Edit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Edit).Click += this.Edit_Click;
                }
                break;
            case 90: // View\TaskDetailedView.xaml line 115
                {
                    this.completed = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.completed).Click += this.completed_Click;
                }
                break;
            case 91: // View\TaskDetailedView.xaml line 117
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Back).Click += this.Back_Click;
                }
                break;
            case 92: // View\TaskDetailedView.xaml line 87
                {
                    this.searchitem = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.searchitem).TextChanged += this.SearchBox_QueryChanged;
                }
                break;
            case 93: // View\TaskDetailedView.xaml line 89
                {
                    this.notask = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 94: // View\TaskDetailedView.xaml line 90
                {
                    this.tasks = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.tasks).ItemClick += this.tasks_ItemClick;
                }
                break;
            case 97: // View\TaskDetailedView.xaml line 80
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element97 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element97).Click += this.filter_Click;
                }
                break;
            case 98: // View\TaskDetailedView.xaml line 81
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element98 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element98).Click += this.filter_Click;
                }
                break;
            case 99: // View\TaskDetailedView.xaml line 82
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
            switch(connectionId)
            {
            case 59: // View\TaskDetailedView.xaml line 253
                {                    
                    global::Windows.UI.Xaml.Controls.TextBlock element59 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                    TaskDetailedView_obj59_Bindings bindings = new TaskDetailedView_obj59_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element59.DataContext);
                    element59.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element59, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element59, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

