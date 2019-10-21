using System.Collections.Generic;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public partial class Q
    {
        public static ColumBuilder Colum => new ColumBuilder();
    }

    public class ColumBuilder:LayoutBuilder<ColumBuilder>
    {
        public Column End()
        {
            return new Column(
                crossAxisAlignment:m_CrossAxisAlignment,
                children: children);
        }
    }
}