using System.Collections.Generic;
using UI.Test.Models;

namespace UI.Test.ViewStates
{
    public class PageState
    {
        public ToDoPageMode PageType;
        public List<ToDoModel> todoDatas;

        public PageState()
        {
            PageType = ToDoPageMode.All;
            this.todoDatas = DataPersistent.Load();
        }

        public PageState(ToDoPageMode mode,List<ToDoModel> list=null)
        {
            this.PageType = mode;
            this.todoDatas = list ?? DataPersistent.Load();
        }
    }
}