using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.widgets;

namespace UI.Test.App
{
    public class WarpFlowExample:UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return Q.Wrap
                .Direction(Axis.horizontal)
                .Spacing(8)
                .RunSpacing(4)
                .Alignment(WrapAlignment.center)
                .Children(
                    Q.Text.Data("@@@").End(),
                    Q.Text.Data("@@@").End(),
                    Q.Text.Data("@@@").End(),
                    Q.Text.Data("@@@").End(),
                    Q.Text.Data("@@@").End(),
                    Q.Text.Data("@@@").End(),
                    Q.Text.Data("@@@").End(),
                    Q.Text.Data("@@@").End(),
                    Q.Text.Data("@@@").End(),
                    Q.Text.Data("@@@").End(),
                    Q.Text.Data("@@@").End(),
                    Q.Text.Data("@@@").End()
                )
                .End();
        }
    }
}