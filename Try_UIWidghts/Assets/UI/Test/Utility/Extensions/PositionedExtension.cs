using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    /// <summary>
    /// Stack布局和Positioned组件联合使用
    /// </summary>
    public static class PositionedExtension
    {
        public static Positioned GetPositioned(this Widget widget, float? left = null,
            float? right = null, float? top = null, float? bottom = null,float? width=null,
            float? height=null)
        {
            return new Positioned(
                child:widget,
                left:left,
                right:right,
                top:top,
                bottom:bottom,
                width:width,
                height:height);
        } 
    }
}