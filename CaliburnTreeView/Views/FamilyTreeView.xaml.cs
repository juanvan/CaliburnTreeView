using CaliburnTreeView.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CaliburnTreeView.Views
{
    /// <summary>
    /// Interaction logic for FamilyTreeView.xaml
    /// </summary>
    public partial class FamilyTreeView : UserControl
    {
        public FamilyTreeView()
        {
            InitializeComponent();
			
			//ObservableCollection<Family> Families = new ObservableCollection<Family>();

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
			//FamilyTree.Items.Add(Families);
		}
	}
	
}
