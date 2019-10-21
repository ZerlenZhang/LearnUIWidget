using System.Collections.Generic;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{

    public partial class Q
    {
        public static WrapBuilder Wrap=>new WrapBuilder();
    }
    
    public class WrapBuilder
    {
        private List<Widget> children = new List<Widget>();
        private TextDirection? mTextDirection;
        private VerticalDirection mVerticalDirection = Unity.UIWidgets.painting.VerticalDirection.down;
        private WrapCrossAlignment m_WrapCrossAlignment = WrapCrossAlignment.start;
        private Axis mDirection = Axis.vertical;
        private WrapAlignment alignment = Unity.UIWidgets.rendering.WrapAlignment.start;
        private float spacing = 0.0f;
        private WrapAlignment runAlignment = Unity.UIWidgets.rendering.WrapAlignment.start;
        private float runSpacing = 0.0f;

        public WrapBuilder Spacing(float space)
        {
            this.spacing = space;
            return this;
        }

        public WrapBuilder RunSpacing(float runSpacing)
        {
            this.runSpacing = runSpacing;
            return this;
        }

        public WrapBuilder Alignment(WrapAlignment alignment)
        {
            this.alignment = alignment;
            return this;
        }

        public WrapBuilder RunAlignment(WrapAlignment runAlignment)
        {
            this.runAlignment = runAlignment;
            return this;
        }

        public WrapBuilder CrossAxisAlignment(WrapCrossAlignment crossAxisAlignment)
        {
            this.m_WrapCrossAlignment = crossAxisAlignment;
            return this;
        }

        public WrapBuilder TextDirection(TextDirection? textDirection)
        {
            this.mTextDirection = textDirection;
            return this;
        }
        public WrapBuilder VerticalDirection(VerticalDirection verticalDirection)
        {
            this.mVerticalDirection = verticalDirection;
            return this;
        }
        public WrapBuilder Child(Widget child)
        {
            children.Add(child);
            return this;
        }

        public WrapBuilder Children(IEnumerable<Widget> children)
        {
            this.children.AddRange(children);
            return this;
        }
        
        public WrapBuilder Children(params Widget[] children)
        {
            this.children.AddRange(children);
            return this;
        }
        
        public WrapBuilder Direction(Axis axis)
        {
            this.mDirection = axis;
            return this;
        }
        
        public Wrap End()
        {
            return new Wrap(
                alignment:alignment,
                runAlignment:runAlignment,
                spacing:spacing,
                runSpacing:runSpacing,
                direction:mDirection,
                crossAxisAlignment:m_WrapCrossAlignment,
                textDirection:mTextDirection,
                verticalDirection:mVerticalDirection,
                children: children);
        }
    }
}