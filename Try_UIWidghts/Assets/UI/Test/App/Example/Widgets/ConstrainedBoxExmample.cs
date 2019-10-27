using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.App
{
    public class ConstrainedBoxExmample : UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return Q.Colum
                .Children(
                    Q.Container
                        .Color(Colors.red)
                        .End()
                        .GetConstrainedBox(new BoxConstraints(maxHeight: 60, minWidth: 400))
                        .GetPadding(EdgeInsets.symmetric(vertical:30)),
                    Q.Container
                        .Color(Colors.green)
                        .End()
                        .GetConstrainedBox(BoxConstraints.expand(200,30)),
                    Q.Container
                        .Color(Colors.black)
                        .End()
                        .GetConstrainedBox(BoxConstraints.loose(Size.square(150))),
                    Q.Container
                        .Color(Colors.cyan)
                        .End()
                        .GetSizeBox(50,100)
                )
                .End()
                .GetScaffold()
                .GetMaterialApp();
        }
    }
}