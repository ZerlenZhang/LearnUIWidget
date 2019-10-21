using Unity.UIWidgets.gestures;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    /// <summary>
    /// Widget手势操作的拓展
    /// </summary>
    public static class GestureDetectorExtension
    {
        public static GestureDetector OnTap(this Widget _widget, GestureTapCallback onTap)
        {
            return new GestureDetector(child: _widget, onTap: onTap);
        }

        public static GestureDetector OnHorizontalDragEnd(this Widget widget, GestureDragEndCallback onDragEnd)
        {
            return new GestureDetector(child:widget,onHorizontalDragEnd:onDragEnd);
        }
    }
}