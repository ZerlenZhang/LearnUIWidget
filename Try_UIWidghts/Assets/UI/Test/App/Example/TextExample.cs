using System.Collections.Generic;
using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.gestures;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace UI.Test.App
{
    public class TextExample : UIWidgetsPanel
    {
        TextEditingController _controller = new TextEditingController("hmgndfghasdf");
        FocusNode _focusNode = new FocusNode();


        protected override Widget createWidget()
        {
            #region 富文本

//            return Text.rich(
//                Q.TextSpan
//                    .Child(Q.TextSpan
//                        .Text("Hello")
//                        .Size(70)
//                        .End())
//                    .Child(Q.TextSpan
//                        .Text("World")
//                        .Size(100)
//                        .Color(Colors.cyan)
//                        .OnTap(()=>Application.OpenURL("http://sikiedu.com"))
//                        .End())
//                    .End());            

            #endregion


//            _controller.addListener(() => print("addListener"));
//            return Q.Text();

            #region TextStyle封装

//            return Q.Text
//                .Size(60)
//                .MaxLine(2)
//                .Decoration(TextDecoration.lineThrough)
//                .DecorationColor(Colors.grey)
//                .DecorationStyle(TextDecorationStyle.doubleLine)
//                .BackGroundColor(Colors.cyan)
//                .Data("HelloWorldHelloWorldHelloWorldHelloWorldHelloWorldHelloWorldHelloWorldHelloWorldHelloWorldHelloWorldHelloWorld")
//                .Alignment(TextAlign.center)
//                .TextOverflow(TextOverflow.ellipsis)
//                .End();            

            #endregion

            #region 设置默认字体样式

            return
                Q.Colum
                    .CrossAxisAlignment(CrossAxisAlignment.center)
                    .Children(new List<Widget>
                    {
                        Q.Text.Data("First").End(),
                        Q.Text.Data("Second").End(),
                        Q.Text.Data("Third").End(),
                        Q.Text.Data("Forth").Size(120).UnHerit().End()
                    }).End()
                    .DefaultTextStyleBuilder()
                    .TextStyle(Q.TextStyle.Color(Colors.redAccent)
                        .Size(70)
                        .Decoration(TextDecoration.underline)
                        .End())
                    .TextAlign(TextAlign.center)
                    .End();
            #endregion
        }
    }
}