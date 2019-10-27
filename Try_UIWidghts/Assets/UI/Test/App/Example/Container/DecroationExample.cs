using System.Collections.Generic;
using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.App
{
    public class DecroationExample:UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return Q.Text
                .Data("HelloWorld")
                .Color(Color.white)
                .End()
                .GetPadding(EdgeInsets.symmetric(vertical:30,horizontal:40))
                .GetDecoratedBox(new BoxDecoration(
                    gradient: new LinearGradient(colors: new List<Color> {Colors.red, Colors.orange[700]}),
                    borderRadius: BorderRadius.circular(9),
                    boxShadow: new List<BoxShadow>
                    {
                        new BoxShadow(Colors.black54, new Offset(2, 2), 4.0f)
                    }))
                .GetPadding(EdgeInsets.symmetric(vertical: 30, horizontal: 50))
                .GetScaffold()
                .GetMaterialApp();
        }
    }
}