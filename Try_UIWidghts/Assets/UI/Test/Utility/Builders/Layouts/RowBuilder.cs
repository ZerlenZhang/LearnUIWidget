using System.Collections.Generic;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public partial class Q
    {
        public static RowBuilder Row => new RowBuilder();
    }

    public class RowBuilder:LayoutBuilder<RowBuilder>
    {
        public Row End()
        {
            return new Row(
                mainAxisSize:m_MainAxisSize,
                crossAxisAlignment:m_CrossAxisAlignment,
                mainAxisAlignment:mMainAxisAlignment,
                textDirection:mTextDirection,
                verticalDirection:mVerticalDirection,
                children: children);
        }
    }
}