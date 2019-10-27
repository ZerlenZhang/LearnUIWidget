using System.Collections.Generic;
using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;
using Color = Unity.UIWidgets.ui.Color;
using Transform = Unity.UIWidgets.widgets.Transform;

namespace UI.Test.App
{
    public class TransformExample : UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return Q.Container
                        .Margin(EdgeInsets.only(left: 120, top: 5))
                        .Constraints(BoxConstraints.tightFor(200, 150))
                        .Decoration(new BoxDecoration(
                            gradient: new RadialGradient(
                                colors: new List<Color> {Colors.red, Colors.orange},
                                center: Alignment.topLeft,
                                radius: 98f),
                            boxShadow: new List<BoxShadow>
                            {
                                new BoxShadow(
                                    color: Colors.black54,
                                    offset: new Offset(2, 2),
                                    blurRadius: 5)
                            }))
                        .Transform(Matrix3.makeRotate(0.2f))
                        .Alignment(Alignment.center)
                        .Child(Q.Text
                            .Color(Color.white)
                            .Data("5.20")
                            .Size(40)
                            .End())
                        
                        .End()
                    .GetPadding(EdgeInsets.only(left: 100, top: 100))
                    .GetScaffold()
                    .GetMaterialApp();
        }
    }
}