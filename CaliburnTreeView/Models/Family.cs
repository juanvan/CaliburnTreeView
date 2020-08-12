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
			Members = new ObservableCollection<FamilyMember>();
		}

		public string Name { get; set; }
		public ObservableCollection<Pet> Pets { get; set; }
		public ObservableCollection<FamilyMember> Members { get; set; }
		public override string ToString()
		{
			return Name;
		}
	}

	public class Pet
	{
		public string Type { get; set; }
		
	}

	public class PetDetail
	{
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
