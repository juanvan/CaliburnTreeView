using Caliburn.Micro;
using CaliburnTreeView.Models;
using System.Collections.ObjectModel;
using System.Threading;

namespace CaliburnTreeView.ViewModels
{
    //https://www.syncfusion.com/kb/4832/how-to-create-hierarchicaldatatemplate-for-the-treeviewadv
    //https://stackoverflow.com/questions/17726445/set-treeview-hierarchicaldatatemplate-with-2-levels-in-wpf
    //https://medium.com/@BrunoLM7/wpf-treeview-with-hierarchical-data-1e064f3fa67d
    //https://www.codemag.com/Article/1401031/Using-the-WPF-Tree-View-with-Multiple-Levels
    //https://www.syncfusion.com/faq/wpf/treeview/how-do-i-bind-a-treeview-to-a-hierarchical-list-where-some-nodes-have-multiple-child-lists
    //https://stackoverflow.com/questions/36006256/wpf-treeview-add-custom-header-to-hierarchicaldatatemplates
    //https://stackoverflow.com/questions/28993566/simple-nested-treeview-xaml-structure
    public class ShellViewModel : Conductor<Screen>
    {
        private ObservableCollection<TopMenuItem> _MainMenu;

        public ObservableCollection<TopMenuItem> MainMenu
        {
            get { return _MainMenu; }
            set
            {
                _MainMenu = value;
                NotifyOfPropertyChange(() => MainMenu);
            }
        }

        public ShellViewModel()
        {
           // MainMenu = new ObservableCollection<TopMenuItem>();
            //MainMenu.Add(new TopMenuItem("Test", "Test1"));
            ActivateItemAsync(IoC.Get<DataGridDemoViewModel>(), new CancellationToken());
        }

        public void ShowFamilyTree()
        {
            
            ActivateItemAsync(IoC.Get<FamilyTreeViewModel>(), new CancellationToken());
        }

        public void ShowDashboard()
        {
            ActivateItemAsync(IoC.Get<DashboardViewModel>(), new CancellationToken());
        }
        public void ShowMenuTreeViewModel()
        {
            ActivateItemAsync(IoC.Get<MenuTreeViewModel>(), new CancellationToken());
        }

        public void ShowEmployeeTreeViewModel()
        {
            ActivateItemAsync(IoC.Get<EmployeeViewModel>(), new CancellationToken());
        }
        protected override void OnViewReady(object view)
        {
            base.OnViewReady(view);
        }
    }
}
