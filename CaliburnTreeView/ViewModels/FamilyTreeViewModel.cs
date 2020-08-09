using Caliburn.Micro;
using CaliburnTreeView.Models;
using System.ComponentModel;

namespace CaliburnTreeView.ViewModels
{
    public class FamilyTreeViewModel : Screen
    {
		private BindingList<Family> _families;

		public BindingList<Family> Families
		{
			get { return _families; }
			set
			{
				_families = value;
				NotifyOfPropertyChange(() => Families);
			}
		}


		public FamilyTreeViewModel()
        {
			Families = new BindingList<Family>();

			Family family1 = new Family() { Name = "The Doe's" };
			family1.Members.Add(new FamilyMember() { Name = "John Doe", Age = 42 });
			family1.Members.Add(new FamilyMember() { Name = "Jane Doe", Age = 39 });
			family1.Members.Add(new FamilyMember() { Name = "Sammy Doe", Age = 13 });
			Families.Add(family1);

			Family family2 = new Family() { Name = "The Moe's" };
			family2.Members.Add(new FamilyMember() { Name = "Mark Moe", Age = 31 });
			family2.Members.Add(new FamilyMember() { Name = "Norma Moe", Age = 28 });
			Families.Add(family2);
		}
    }
}
