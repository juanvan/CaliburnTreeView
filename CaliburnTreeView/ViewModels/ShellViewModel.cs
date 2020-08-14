﻿using Caliburn.Micro;
using System.Threading;

namespace CaliburnTreeView.ViewModels
{
    public class ShellViewModel : Conductor<Screen>
    {
        public ShellViewModel()
        {
            ActivateItemAsync(IoC.Get<FamilyTreeViewModel>(), new CancellationToken());
        }

        public void ShowFamilyTree()
        {
            ActivateItemAsync(IoC.Get<FamilyTreeViewModel>(), new CancellationToken());
        }

        public void ShowDashboard()
        {
            ActivateItemAsync(IoC.Get<DashboardViewModel>(), new CancellationToken());
        }

        protected override void OnViewReady(object view)
        {
            base.OnViewReady(view);
        }
    }
}
