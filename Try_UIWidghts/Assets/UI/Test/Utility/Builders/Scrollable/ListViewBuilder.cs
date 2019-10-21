using System.Collections.Generic;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public partial class Q
    {
        public static ListViewBuilder ListView => new ListViewBuilder();
    }

    public class ListViewBuilder
    {
        List<Widget> mChildren = new List<Widget>();
        EdgeInsets mPadding = null;
        public static ListViewBuilder GetBuilder()
        {
            return new ListViewBuilder();
        }
        public ListViewBuilder Padding(EdgeInsets _madding)
        {
            mPadding = _madding;
            return this;
        }
        public ListViewBuilder Child(List<Widget> _children)
        {
            mChildren = _children;
            return this;
        }
        public ListViewBuilder Child(Widget _child)
        {
            mChildren.Add(_child);
            return this;
        }
        public ListViewBuilder Child(params Widget[] _childeen)
        {
            mChildren.AddRange(_childeen);
            return this;
        }
        public ListView End()
        {
            return new ListView(children: mChildren, padding: mPadding);
        }
    }
}