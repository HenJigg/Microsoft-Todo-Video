using MicrosoftToDO.Common;
using System.Collections.ObjectModel;

namespace MicrosoftToDO.ViewModels
{
    public class MainViewModel
    {
        private ObservableCollection<MenuItem> menuItems;

        public ObservableCollection<MenuItem> MenuItems
        {
            get { return menuItems; }
            set { menuItems = value; }
        }

        public MainViewModel()
        {
            MenuItems = new ObservableCollection<MenuItem>();
            MenuItems.Add(new MenuItem() { Icon = "\xe635", Name = "我的一天", Count = 999 });
            MenuItems.Add(new MenuItem() { Icon = "\xe6b6", Name = "重要", Count = 999 });
            MenuItems.Add(new MenuItem() { Icon = "\xe6e1", Name = "已计划日程", Count = 999 });
            MenuItems.Add(new MenuItem() { Icon = "\xe614", Name = "已分配给你", Count = 999 });
            MenuItems.Add(new MenuItem() { Icon = "\xe755", Name = "任务", Count = 999 });
        }
    }
}
