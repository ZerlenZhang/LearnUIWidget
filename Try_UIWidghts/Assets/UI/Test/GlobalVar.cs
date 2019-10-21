using System;
using UI.Test.Models;

namespace UI.Test
{
    public static class GlobalVar
    {
        private static ToDoPageMode page= ToDoPageMode.All;
        public static ToDoPageMode PageType
        {
            get { return page; }
            set
            {
                if (value == page)
                    return;
                onPageTypeModeChange?.Invoke(value);
                page = value;
            }
        }
        public static event Action<ToDoPageMode> onPageTypeModeChange;
    }
}