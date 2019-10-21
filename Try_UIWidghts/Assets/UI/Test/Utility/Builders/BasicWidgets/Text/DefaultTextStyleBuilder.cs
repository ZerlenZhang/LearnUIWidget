using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public class DefaultTextStyleBuilder
    {
        private Widget child;
        private TextStyle textStyle;
        private TextAlign? m_TextAlign;

        public DefaultTextStyleBuilder TextStyle(TextStyle style)
        {
            textStyle = style;
            return this;
        }

        public DefaultTextStyleBuilder TextAlign(TextAlign textAlign)
        {
            this.m_TextAlign = textAlign;
            return this;
        }
        
        public DefaultTextStyleBuilder(Widget child)
        {
            this.child = child;
        }

        public DefaultTextStyle End()
        {
            return new DefaultTextStyle(
                child: child,
                textAlign: m_TextAlign,
                style: textStyle);
        }
    }
}