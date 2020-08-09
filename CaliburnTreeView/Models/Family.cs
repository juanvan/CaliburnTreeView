using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CaliburnTreeView.Models
{
	public class Family
	{
		public Family()
		{
			this.Members = new ObservableCollection<FamilyMember>();
		}

		public string Name { get; set; }

		public ObservableCollection<FamilyMember> Members { get; set; }
		public override string ToString()
		{
			return Name;
		}
	}

	public class FamilyMember : PropertyChangedBase
	{
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value;
				NotifyOfPropertyChange(() => Name);
			}
		}

		private int _age;

		public int Age
		{
			get { return _age; }
			set { _age = value;
				NotifyOfPropertyChange(() => Age);
			}
		}
		public override string ToString()
		{
			return Name + " " + Age;
		}

	}
}
