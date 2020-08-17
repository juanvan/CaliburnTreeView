using Caliburn.Micro;
using CaliburnTreeView.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace CaliburnTreeView.ViewModels
{
	public class FamilyTreeViewModel : Screen
	{
		private ObservableCollection<Family> _families;

		public ObservableCollection<Family> Families
		{
			get { return _families; }
			set
			{
				_families = value;
				NotifyOfPropertyChange(() => Families);
			}
		}

		private string _sampleText;

		public string SampleText
		{
			get { return _sampleText; }
			set { _sampleText = value;
				NotifyOfPropertyChange(() => SampleText);
			}
		}

		public FamilyTreeViewModel()
		{
			SampleText = "Called from Ctor";

			Families = new ObservableCollection<Family>();

			Family family1 = new Family() { Name = "The Doe's" };
			//family1.Pets = new ObservableCollection<FamilyPet>();
			family1.Pets.Add(new FamilyPet() { Name = "Peepers" });
			family1.Pets.Add(new FamilyPet() { Name = "Quacks" });
			family1.Members.Add(new FamilyMember() { Name = "John Doe", Age = 42 });
			family1.Members.Add(new FamilyMember() { Name = "Jane Doe", Age = 39 });
			family1.Members.Add(new FamilyMember() { Name = "Sammy Doe", Age = 13 });
			Families.Add(family1);

			Family family2 = new Family() { Name = "The Moe's" };
			//family2.Pets = new ObservableCollection<Pet>();
			family2.Pets.Add(new FamilyPet() { Name = "Bar" });
			family2.Pets.Add(new FamilyPet() { Name = "Foo" });
			family2.Members.Add(new FamilyMember() { Name = "Mark Moe", Age = 31 });
			family2.Members.Add(new FamilyMember() { Name = "Norma Moe", Age = 28 });
			Families.Add(family2);
		}

		public bool CanTalk(string name)
		{
			return !string.IsNullOrWhiteSpace(name);
		}
		public void Talk(string name)
		{
			MessageBox.Show(string.Format("Hello {0}!", name));
		}
		public void ViewPerson(object name)
		{
			MessageBox.Show(string.Format("Hello {0}!", name));
		}

	}
}
