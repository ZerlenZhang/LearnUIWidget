using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    /// <summary>
    /// 设置默认字体样式
    /// </summary>
    public static class DefaultTextStyleExtension
    {
        public static DefaultTextStyle DefaultTextStyle(this Widget widget, TextStyle textStyle, TextAlign alignment)
        {
            return new DefaultTextStyle(style:textStyle,
                textAlign:alignment,
                child:widget);
        }
        public static DefaultTextStyleBuilder DefaultTextStyleBuilder(this Widget widget)
        {
            return new DefaultTextStyleBuilder(widget);
        }
    }
}