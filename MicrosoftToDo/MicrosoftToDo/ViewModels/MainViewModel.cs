using MicrosoftToDO.Common;
using Prism.Commands;
using Prism.Mvvm;
using System;
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
            MenuItems.Add(new MenuItem() { Icon = "\xe635", BackColor = "#FF3E8E6C", Name = "我的一天", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "\xe6b6", BackColor = "#FFAC395D", Name = "重要", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "\xe6e1", BackColor = "#FF3E8E6C", Name = "已计划日程", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "\xe614", BackColor = "#FFAC395D", Name = "已分配给你", Count = 2 });
            MenuItems.Add(new MenuItem() { Icon = "\xe755", BackColor = "#FF3E8E6C", Name = "任务", Count = 2 });
        }

    }
}
