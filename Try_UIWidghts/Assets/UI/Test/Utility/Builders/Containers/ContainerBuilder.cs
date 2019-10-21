using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public partial class Q
    {
        public static ContainerBuild Container => new ContainerBuild();
    }

    public class ContainerBuild
    {
        private Widget mChild { get; set; }
        private Alignment mAlignment { get; set; }
        private Color mColor { get; set; }
        private EdgeInsets mMargin = EdgeInsets.zero;
        private EdgeInsets mPadding=EdgeInsets.zero;
        //可控参数
        private float? mWidth = null;
        private float? mHeight = null;

        private Color boxColor;

        public ContainerBuild BoxDecorationColor(Color color)
        {
            boxColor = color;
            return this;
        }

        
        public static ContainerBuild GetBuilder()
        {
            return new ContainerBuild();
        }

        public ContainerBuild Padding(EdgeInsets padding)
        {
            this.mPadding = padding;
            return this;
        }
        

        public ContainerBuild Child(Widget _child)
        {
            mChild = _child;
            return this;
        }
        public ContainerBuild Color(Color _color)
        {
            mColor = _color;
            return this;
        }
        public ContainerBuild Margin(EdgeInsets _edgInsets)
        {
            mMargin = _edgInsets;
            return this;
        }
        public ContainerBuild Width(float _width)
        {
            mWidth = _width;
            return this;
        }

        public ContainerBuild Height(float height)
        {
            mHeight = height;
            return this;
        }
        public ContainerBuild Alignment(Alignment _alignment)
        {
            mAlignment = _alignment;
            return this;
        }
        public Container End()
        {
            return new Container(child: mChild, alignment: mAlignment, color: mColor, width: mWidth, margin: mMargin,
                height: mHeight, decoration: boxColor == null ? null : new BoxDecoration(border:Border.all(boxColor,width:5)),
                padding:mPadding);
        }
    }
}