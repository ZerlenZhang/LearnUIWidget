using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.App.Scrollable
{
    public class ListViewExample:UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return Q.ListView
                .Child(Q.Text.Data("Hello world").End())
                .Child(Q.Text.Data("Hello world").End())
                .Child(Q.Text.Data("Hello world").End())
                .Child(Q.Text.Data("Hello world").End())
                .Child(Q.Text.Data("Hello world").End())
                .Child(Q.Text.Data("Hello world").End())
//                .ShrinkWrap()
                .Padding(EdgeInsets.all(40))
                .End()
                .DefaultTextStyle(new TextStyle(fontSize:50),TextAlign.center);
        }
    }
}