using System.Collections.Generic;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public class MutiChildBuilder<T>
    where T:MutiChildBuilder<T>
    {
        protected List<Widget> children = new List<Widget>();
        public T Child(Widget child)
        {
            children.Add(child);
            return this as T;
        }

        public T Children(IEnumerable<Widget> children)
        {
            this.children.AddRange(children);
            return this as T;
        }
        
        public T Children(params Widget[] children)
        {
            this.children.AddRange(children);
            return this as T;
        }
    }
}