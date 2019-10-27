using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    /// <summary>
    /// todo:注意，所有约束都要在MaterialApp和Scorff框架下才有效
    /// 一种约束
    /// </summary>
    public static class SizeBoxExtension
    {
        public static SizedBox GetSizeBox(this Widget widget, float? width=null, float? height=null)
        {
            return new SizedBox(child:widget,width:width,height:height);
        }
    }
}