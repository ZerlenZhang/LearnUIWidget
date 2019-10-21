using System.Collections.Generic;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public class LayoutBuilder<T>
    where T:LayoutBuilder<T>
    {
        protected List<Widget> children = new List<Widget>();

        protected TextDirection? mTextDirection;
        protected VerticalDirection mVerticalDirection = Unity.UIWidgets.painting.VerticalDirection.down;
        
        protected CrossAxisAlignment m_CrossAxisAlignment=Unity.UIWidgets.rendering.CrossAxisAlignment.start;


        protected MainAxisAlignment mMainAxisAlignment= Unity.UIWidgets.rendering.MainAxisAlignment.start;
        

        protected MainAxisSize m_MainAxisSize = Unity.UIWidgets.rendering.MainAxisSize.max;

        public T MainAxisSize(MainAxisSize mainAxisSize)
        {
            this.m_MainAxisSize = mainAxisSize;
            return this as T;
        }
        public T TextDirection(TextDirection? textDirection)
        {
            this.mTextDirection = textDirection;
            return this as T;
        }

        public T MainAxisAlignment(MainAxisAlignment mainAxisAlignment)
        {
            this.mMainAxisAlignment = mainAxisAlignment;
            return this as T;
        }

        public T VerticalDirection(VerticalDirection verticalDirection)
        {
            this.mVerticalDirection = verticalDirection;
            return this as T;
        }
        
        public T CrossAxisAlignment(CrossAxisAlignment crossAxisAlignment)
        {
            this.m_CrossAxisAlignment = crossAxisAlignment;
            return this as T;
        }
        
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