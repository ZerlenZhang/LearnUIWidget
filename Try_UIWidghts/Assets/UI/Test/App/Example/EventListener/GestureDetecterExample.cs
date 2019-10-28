using System.Collections.Generic;
using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.App.EventListener
{
    public class GestureDetecterExample : UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return new GestureDetectorRoute();
        }
    }

    public class GestureDetectorRoute : StatefulWidget
    {
        public override State createState()
        {
            return new GestureDetectorState();
        }
    }

    public class GestureDetectorState : State<GestureDetectorRoute>
    {
        private string mText = "";
        private float left = 0;
        private float top = 0;

        public override Widget build(BuildContext context)
        {
            return new Stack(
                children: new List<Widget>
                {
                    new GestureDetector(
                        child: Q.Container
                            .Alignment(Alignment.center)
                            .Color(Colors.blue)
                            .Height(100)
                            .Width(200)
                            .Child(Q.Text
                                .Data(mText)
                                .Size(20)
                                .Color(Color.white)
                                .End())
                            .End(),
                        onDoubleTap: e => setState(() => mText = "OnDoubleTap"),
                        onLongPress: () => setState(() => mText = "onLongPress"),
                        onLongPressEnd: e => setState(() => mText = "onLongPressedEnd"),
                        onLongPressStart: e => setState(() => mText = "onLongPressedStart"),
                        onLongPressUp: () => setState(() => mText = "onLongPressedUp"),
//                        onLongPressMoveUpdate: e => setState(() => mText = "onLongPressedMoveUpdate"),
                        onPanDown: e => setState(() => mText = "onPanDown" + e),
                        onPanCancel: () => setState(() => mText = "onPanCancel"),
                        onPanEnd: e => setState(() => mText = "onPanEnd" + e),
                        onPanStart: e => setState(() => mText = "onPanStart" + e),
                        onPanUpdate: e => setState(() =>
                        {
                            left += e.delta.dx;
                            top += e.delta.dy;
                            mText = "onPanUpdate" + e;
                        }))
//                        onHorizontalDragCancel: () => setState(() => mText = "onHorizontalDragCancel"),
//                        onHorizontalDragDown: e => setState(() => mText = "onHorizontalDragDown"),
//                        onHorizontalDragEnd: e => setState(() => mText = "onHorizontalDragEnd" + e),
//                        onHorizontalDragStart: e => setState(() => mText = "onHorizontalDragStart" + e))
//                        onHorizontalDragUpdate: e => setState(() => mText = "onHorizontalDragUpdate" + e))
                        .GetPositioned(left:left,top:top)

                });
        }
    }
}