using Unity.UIWidgets.painting;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    /// <summary>
    /// todo:注意，所有约束都要在MaterialApp和Scorff框架下才有效
    /// 不受约束限制的约束器，用于让某一个特殊的子物体不受约束
    /// </summary>
    public static class UnConstrainedBoxExtension
    {
        public static UnconstrainedBox GetConstrainedBox(this Widget widget,Alignment alignment,Axis constrainedAxis)
        {
            return new UnconstrainedBox(child: widget, alignment: alignment, constrainedAxis: constrainedAxis);
        }
    }
}