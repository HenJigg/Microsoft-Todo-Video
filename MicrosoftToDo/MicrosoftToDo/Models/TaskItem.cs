using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftToDO.Models
{
    /// <summary>
    /// 任务模块
    /// </summary>
    public class TaskItem : BindableBase
    {
        private ObservableCollection<TaskInfo> tasks;
        private string background;
        public string Id { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 背景颜色
        /// </summary>
        public string Background
        {
            get { return background; }
            set { background = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 任务列表
        /// </summary>
        public ObservableCollection<TaskInfo> TaskLists
        {
            get { return tasks; }
            set { tasks = value; RaisePropertyChanged(); }
        }
    }
}
