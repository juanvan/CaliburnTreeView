using Caliburn.Micro;
using CaliburnTreeView.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;


namespace CaliburnTreeView.ViewModels
{
   public class FamilyTreeViewModel : Screen
    {
		//private BindingList<Family> _families;

		//public BindingList<Family> Families
		//{
		//	get { return _families; }
		//	set
		//	{
		//		_families = value;
		//		NotifyOfPropertyChange(() => Families);
		//	}
		//}
		private ObservableCollection<MenuItem> roots;

		public ObservableCollection<MenuItem> Roots
		{
			get { return roots; }
			set { roots = value;
				NotifyOfPropertyChange(() => Roots);
			}
		}

		private MenuItem root;

		public MenuItem Root
		{
			get { return root; }
			set { root = value;
				NotifyOfPropertyChange(() => Root); }
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
			Roots = new ObservableCollection<MenuItem>();	
			Root = new MenuItem() { Title = "Menu" };
			MenuItem childItem1 = new MenuItem() { Title = "Child item #1" };
			childItem1.TrackItems.Add(new TrackItem() { TrackId = "Song 1" });
			childItem1.TrackItems.Add(new TrackItem() { TrackId = "Song 2" });
			childItem1.TrackItems.Add(new TrackItem() { TrackId = "Song 3" });
			childItem1.Items.Add(new MenuItem() { Title = "Child item #1.1" });
			childItem1.Items.Add(new MenuItem() { Title = "Child item #1.2" });
			Root.Items.Add(childItem1);
			Root.Items.Add(new MenuItem() { Title = "Child item #2", Items = new ObservableCollection<MenuItem>() { new MenuItem() { Title = "Child Item 2.1" } }, TrackItems = new ObservableCollection<TrackItem>() { new TrackItem() { TrackId = "Child2 Song 1" } } });
			Roots.Add(Root);
			//Families = new BindingList<Family>();

			//Family family1 = new Family() { Name = "The Doe's" };
			////family1.Pets = new ObservableCollection<Pet>();
			//family1.Pets.Add(new FamilyPet() { Name = "Peepers" });
			//family1.Pets.Add(new FamilyPet() { Name = "Quacks" });
			//family1.Members.Add(new FamilyMember() { Name = "John Doe", Age = 42 });
			//family1.Members.Add(new FamilyMember() { Name = "Jane Doe", Age = 39 });
			//family1.Members.Add(new FamilyMember() { Name = "Sammy Doe", Age = 13 });
			//Families.Add(family1);

			//Family family2 = new Family() { Name = "The Moe's" };
			////family2.Pets = new ObservableCollection<Pet>();
			//family2.Pets.Add(new FamilyPet() { Name = "Bar" });
			//family2.Pets.Add(new FamilyPet() { Name = "Foo" });
			//family2.Members.Add(new FamilyMember() { Name = "Mark Moe", Age = 31 });
			//family2.Members.Add(new FamilyMember() { Name = "Norma Moe", Age = 28 });
			//Families.Add(family2);
		}
	}
}
