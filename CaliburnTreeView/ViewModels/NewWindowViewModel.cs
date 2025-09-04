using Caliburn.Micro;
using System;

namespace CaliburnTreeView.ViewModels
{
    public class NewWindowViewModel : Screen
    {
        private string _windowTitle = "New Window";
        private string _message = "This is a new window opened from the main shell!";
        private DateTime _openedTime;

        public string WindowTitle
        {
            get { return _windowTitle; }
            set
            {
                _windowTitle = value;
                NotifyOfPropertyChange(() => WindowTitle);
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                NotifyOfPropertyChange(() => Message);
            }
        }

        public DateTime OpenedTime
        {
            get { return _openedTime; }
            set
            {
                _openedTime = value;
                NotifyOfPropertyChange(() => OpenedTime);
            }
        }

        public NewWindowViewModel()
        {
            WindowTitle = "New Window";
            OpenedTime = DateTime.Now;
            Message = $"This window was opened at {OpenedTime:HH:mm:ss}";
        }

        public void CloseWindow()
        {
            TryCloseAsync(true);
        }
    }
}