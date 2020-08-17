using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Data;

namespace CaliburnTreeView.Models
{
	public class Family : PropertyChangedBase
	{
		public Family()
		{ 
			Members = new ObservableCollection<FamilyMember>();
			Pets = new ObservableCollection<FamilyPet>();
			
		}

		//public ObservableCollection<T> Children
		//{
		//	get
		//	{
		//		return new[]
		//		{
		//	new CollectionContainer(){ Collection = Members },
		//	new CollectionContainer() {Collection = Pets}
		//	};
		//	}
		//}

		public string Name { get; set; }
		public ObservableCollection<FamilyPet> Pets { get; set; }
		public ObservableCollection<FamilyMember> Members { get; set; }
		public override string ToString()
		{
			return Name;
		}
	}

	public class FamilyPet : PropertyChangedBase
	{
		private string name;

		public string Name
		{
			get { return name; }
			set 
			{ 
				name = value;
				NotifyOfPropertyChange(() => Name);

			}
		}


		public override string ToString()
		{
			return Name;
		}

	}

	public class FamilyMember
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public override string ToString()
		{
			return Name + " " + Age;
		}

	}
}
