using Unity.UIWidgets.painting;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public partial class Q
    {
        public static FlexBuilder Flex=>new FlexBuilder();
    }
    
    public class FlexBuilder:LayoutBuilder<FlexBuilder>
    {
        private Axis mDirection = Axis.vertical;

        public FlexBuilder Direction(Axis axis)
        {
            this.mDirection = axis;
            return this;
        }
        
        public Flex End()
        {
            return new Flex(
                direction:mDirection,
                mainAxisSize:m_MainAxisSize,
                crossAxisAlignment:m_CrossAxisAlignment,
                mainAxisAlignment:mMainAxisAlignment,
                textDirection:mTextDirection,
                verticalDirection:mVerticalDirection,
                children: children);
        }
    }
}