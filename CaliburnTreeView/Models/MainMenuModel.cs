using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Caliburn.Micro;

namespace CaliburnTreeView.Models
{
    public class TopMenuItem :  PropertyChangedBase 
    {
        private List<TopMenuItem> _Items;

        public TopMenuItem(string header, ICommand command)
        {
            Header = header;
            Command = command;
        }

        public TopMenuItem()
        {

        }
        public TopMenuItem(string header, string xName)
        {
            Header = header;
            XName = xName;
        }

        public string Header { get; set; }

        public List<TopMenuItem> Items
        {
            get { return _Items ?? (_Items = new List<TopMenuItem>()); }
            set { _Items = value; }
        }

        public string XName { get; set; }
        public ICommand Command { get; set; }
        public string CommandName { get; set; }
        public object Icon { get; set; }
        public bool IsCheckable { get; set; }
        private bool _IsChecked;
        public bool IsChecked
        {
            get { return _IsChecked; }
            set
            {
                _IsChecked = value;
                NotifyOfPropertyChange(() => IsChecked);
            }
        }

        public bool Visible { get; set; }
        public bool IsSeparator { get; set; }
        public string InputGestureText { get; set; }
        public string ToolTip { get; set; }
        public int MenuHierarchyID { get; set; }
        public int ParentMenuHierarchyID { get; set; }
        public string IconPath { get; set; }
        public bool IsAdminOnly { get; set; }
        public object Context { get; set; }
        public TopMenuItem Parent { get; set; }
        public int int_Sequence { get; set; }
        public int int_KeyIndex { get; set; }
    }
}
