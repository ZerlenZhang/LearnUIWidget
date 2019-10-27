using Unity.UIWidgets.painting;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    /// <summary>
    /// Padding容器拓展封装
    /// </summary>
    public static class PaddingExtension
    {
        public static Padding GetPadding(this Widget child, EdgeInsets padding)
        {
            return new Padding(child:child,padding:padding);
        }
    }
}