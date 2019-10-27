using Unity.UIWidgets.rendering;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    /// <summary>
    /// todo:注意，所有约束都要在MaterialApp和Scorff框架下才有效
    /// 添加约束
    /// 用于限制或对齐子物体，限制方式在BoxConstraints中定义
    /// </summary>
    public static class ConstrainedBoxExtension
    {
        public static ConstrainedBox GetConstrainedBox(this Widget child, BoxConstraints constraints)
        {
            return new ConstrainedBox(child:child,constraints:constraints);
        }
    }
}