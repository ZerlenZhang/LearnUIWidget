using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.service;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace UI.Test.App
{
    public class ButtonExample : UIWidgetsPanel
    {
        protected override void OnEnable()
        {
            base.OnEnable();
            //使用ICons必须导入这样的文件
            FontManager.instance.addFont(Resources.Load<Font>("MaterialIcons-Regular"), "Material Icons");
        }

        protected override Widget createWidget()
        {
            return new MaterialApp(
                home:
                new Scaffold(//body: new Text("Hello")));
                        body: Q.ListView
                            .Padding(EdgeInsets.zero)
                            .Child(Q.RaisButton
                                    .Child(Q.Text
                                            .Data("Hello")
                                            .Alignment(TextAlign.center)
                                            .End())
                                    .OnPressed(() => print("Click"))
                                    .End())
                            .Child(Q.OutlineButton
                                .Child(new Text("outline btn"))
                                .OnPressed(() => print("click outlineBtn"))
                                .End())
                            .Child(Q.FlatButton
                                .Child(new Text("FlatButton"))
                                .OnPressed(() => print("click flatBtn"))
                                .End())
                            .Child(Q.IconBtn
                                .IconData(Icons.wifi)
                                .Color(Colors.green)
                                .OnPressed(() => print("click iconBtn"))
                                .End())
                            .Child(Q.IconBtn
                                .IconData(Icons.wifi)
                                .OnPressed(() => print("click iconBtn"))
                                .End())
                            .Child(Q.IconBtn
                                .IconData(Icons.wifi)
                                .OnPressed(() => print("click iconBtn"))
                                .End())
                            .Child(Q.RaisButton
                                .Color(Colors.blue)
                                .HighlightColor(Colors.blue[700])
                                .ColorBrightness(Brightness.dark)
                                .SplashColor(Colors.grey)
                                .Child(new Text("Submit"))
                                .Shape(new RoundedRectangleBorder(borderRadius:BorderRadius.circular(20.0f)))
                                .OnPressed(()=>print("click fancy button"))
                                .End())
                            .End()));

        }
    }
}