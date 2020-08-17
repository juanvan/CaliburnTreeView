using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CaliburnTreeView.Models
{
	public class MenuItem
	{
		public MenuItem()
		{
			Items = new ObservableCollection<MenuItem>();
			TrackItems = new ObservableCollection<TrackItem>();
		}

		public string Title { get; set; }

		public ObservableCollection<MenuItem> Items { get; set; }
		public ObservableCollection<TrackItem> TrackItems { get; set; }
	}

	public class TrackItem
	{
		public string Title { get; set; }
	}
}
