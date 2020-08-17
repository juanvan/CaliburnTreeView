using Caliburn.Micro;
using CaliburnTreeView.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CaliburnTreeView.ViewModels
{
    public class MenuTreeViewModel : Screen
    {
		private ObservableCollection<MenuItem> roots;

		public ObservableCollection<MenuItem> Roots
		{
			get { return roots; }
			set
			{
				roots = value;
				NotifyOfPropertyChange(() => Roots);
			}
		}

		private MenuItem root;

		public MenuItem Root
		{
			get { return root; }
			set
			{
				root = value;
				NotifyOfPropertyChange(() => Root);
			}
		}

		public MenuTreeViewModel()
        {
			Roots = new ObservableCollection<MenuItem>();
			Root = new MenuItem() { Title = "Menu" };
			MenuItem childItem1 = new MenuItem() { Title = "Child item #1" };
			childItem1.TrackItems.Add(new TrackItem() { Title = "Song 1" });
			childItem1.TrackItems.Add(new TrackItem() { Title = "Song 2" });
			childItem1.TrackItems.Add(new TrackItem() { Title = "Song 3" });
			childItem1.Items.Add(new MenuItem() { Title = "Child item #1.1" });
			childItem1.Items.Add(new MenuItem() { Title = "Child item #1.2" });
			Root.Items.Add(childItem1);
			Root.Items.Add(new MenuItem() { Title = "Child item #2", Items = new ObservableCollection<MenuItem>() { new MenuItem() { Title = "Child Item 2.1" } }, TrackItems = new ObservableCollection<TrackItem>() { new TrackItem() { Title = "Child2 Song 1" } } });
			Roots.Add(Root);
		}
    }
}
