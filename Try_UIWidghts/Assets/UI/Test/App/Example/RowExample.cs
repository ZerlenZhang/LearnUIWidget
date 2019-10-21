using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.App
{
    public class RowExample:UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return new MaterialApp(
                home: new Scaffold(
                    body:Q.Colum
                        .Child(Q.Row
                            .Child(Q.Text
                                .Data("HelloWorld")
                                .Size(50)
                                .End())
                            .Child(Q.Text
                                .Data("LengencyOfLeague")
                                .End())
                            .End())
                        .Child(Q.Row
                            .TextDirection(TextDirection.rtl)
                            .Child(Q.Text
                                .Data("HelloWorld")
                                .Size(50)
                                .End())
                            .Child(Q.Text
                                .Data("TextDirection.rtl")
                                .End())
                            .End())
                        .Child(Q.Row
                            .MainAxisAlignment(MainAxisAlignment.center)
                            .Child(Q.Text
                                .Data("HelloWorld")
                                .Size(50)
                                .End())
                            .Child(Q.Text
                                .Data("MainAxisAlignment.center")
                                .End())
                            .End())
                        .Child(Q.Row
                            .MainAxisAlignment(MainAxisAlignment.end)
                            .Child(Q.Text
                                .Data("HelloWorld")
                                .Size(50)
                                .End())
                            .Child(Q.Text
                                .Data("MainAxisAlignment.end")
                                .End())
                            .End())
                        .Child(Q.Row
                            .MainAxisAlignment(MainAxisAlignment.spaceAround)
                            .Child(Q.Text
                                .Data("HelloWorld")
                                .Size(50)
                                .End())
                            .Child(Q.Text
                                .Data("MainAxisAlignment.spaceAround")
                                .End())
                            .End())
                        .Child(Q.Row
                            .MainAxisAlignment(MainAxisAlignment.spaceBetween)
                            .Child(Q.Text
                                .Data("HelloWorld")
                                .Size(50)
                                .End())
                            .Child(Q.Text
                                .Data("MainAxisAlignment.spaceBetween")
                                .End())
                            .End())
                        .Child(Q.Row
                            .VerticalDirection(VerticalDirection.up)
                            .Child(Q.Text
                                .Data("HelloWorld")
                                .Size(50)
                                .End())
                            .Child(Q.Text
                                .Data("VerticalDirection.up")
                                .End())
                            .End())
                        .Child(Q.Row
                            .MainAxisSize(MainAxisSize.min)
                            .MainAxisAlignment(MainAxisAlignment.spaceBetween)
                            .Child(Q.Text
                                .Data("MainAxisSize.min")
                                .Size(50)
                                .End())
                            .Child(Q.Text
                                .Data("MainAxisAlignment.spaceBetween")
                                .End())
                            .End())
                        .End()
                    ));
        }
    }
}