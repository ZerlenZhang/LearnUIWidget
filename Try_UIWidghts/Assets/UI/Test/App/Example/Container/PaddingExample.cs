using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.widgets;

namespace UI.Test.App
{
    public class PaddingExample:UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return Q.Text
                .Data("Hello World")
                .End()
                .GetPadding(EdgeInsets.all(50));
        }
    }
}