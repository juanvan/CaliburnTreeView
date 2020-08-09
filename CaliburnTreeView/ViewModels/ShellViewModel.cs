using Caliburn.Micro;
using CaliburnTreeView.Models;
using CaliburnTreeView.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace CaliburnTreeView.ViewModels
{
   public class ShellViewModel : Screen// Conductor<object>
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

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value;
				NotifyOfPropertyChange(() => Name);
			}
		}


		public ShellViewModel()
        {
			Families = new ObservableCollection<Family>();

			Family family1 = new Family() { Name = "The Doe's" };
			family1.Members.Add(new FamilyMember() { Name = "John Doe", Age = 42 });
			family1.Members.Add(new FamilyMember() { Name = "Jane Doe", Age = 39 });
			family1.Members.Add(new FamilyMember() { Name = "Sammy Doe", Age = 13 });
			Families.Add(family1);

			Family family2 = new Family() { Name = "The Moe's" };
			family2.Members.Add(new FamilyMember() { Name = "Mark Moe", Age = 31 });
			family2.Members.Add(new FamilyMember() { Name = "Norma Moe", Age = 28 });
			Families.Add(family2);
			// ActivateItemAsync(IoC.Get<FamilyTreeViewModel>(), new System.Threading.CancellationToken());
		}

		public bool CanTalk(string name)
		{
			return !string.IsNullOrWhiteSpace(name);
		}
		public void Talk(string name)
		{
			MessageBox.Show(string.Format("Hello {0}!", name));
		}
	}
}
