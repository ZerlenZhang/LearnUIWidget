using System.Collections.Generic;
using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.widgets;

namespace UI.Test.App
{
    public class StackExample : UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return Q.Stack
                .Alignment(Alignment.center)
                .Children(
                    Q.Text
                        .Data("????")
                        .End(),
                    Q.Container
                        .Color(Colors.red)
                        .Child(Q.Text
                            .Data("HelloWorld")
                            .Color(Colors.yellow)
                            .End())
                        .End(),
                    Q.Text
                        .Data("I'm jack")
                        .End()
                        .GetPositioned(left: 40),
                    Q.Text
                        .Data("your friend")
                        .End()
                        .GetPositioned(top: 30))
                .End()
                .GetConstrainedBox(BoxConstraints.expand());
        }
    }
}