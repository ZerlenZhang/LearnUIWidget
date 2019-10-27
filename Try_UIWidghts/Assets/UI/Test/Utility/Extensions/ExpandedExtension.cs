using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    /// <summary>
    /// 弹性布局中使用，flex表示widget所占比例
    /// </summary>
    public static class ExpandedExtension
    {
        public static Expanded GetExpanded(this Widget widget,int flex)
        {
            return new Expanded(
                flex:flex,
                child:widget);
        }
    }
}