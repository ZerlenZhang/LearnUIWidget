using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UI.Test.Utility;
using Unity.UIWidgets.animation;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.gestures;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.scheduler;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;
using Color = Unity.UIWidgets.ui.Color;
using Material = Unity.UIWidgets.material.Material;

namespace UI.Test.App.Widgets.CustomWidgets
{
    public class CustomWidgetExample : UIWidgetsPanel
    {        
        protected override void OnEnable()
        {
            base.OnEnable();
            //使用ICons必须导入这样的文件
            FontManager.instance.addFont(Resources.Load<Font>("MaterialIcons-Regular"), "Material Icons");
        }

        protected override Widget createWidget()
        {
            return new CustomWidgetRoute()
                .GetScaffold()
                .GetMaterialApp();
        }

        class CustomWidgetRoute:StatefulWidget
        {
            public override State createState()
            {
                return new CustomWidgetState();
            }
        }  
        class CustomWidgetState : State<CustomWidgetRoute>
        {
            private float turns = 0f;
            public override Widget build(BuildContext context)
            {
                return Q.Colum
                    .CrossAxisAlignment(CrossAxisAlignment.center)
                    .MainAxisAlignment(MainAxisAlignment.spaceAround)
                    .Children(
                        new GradintBtn(
                            colors: new List<Color> {Colors.orange, Colors.red, Colors.cyan},
                            child: Q.Text.Data("Submit").End(),
                            height: 50f,
                            onTap: () => { }),
                        new GradintBtn(
                            colors: new List<Color> {Colors.lightGreen, Colors.green[700], Colors.amber},
                            child: Q.Text.Data("Submit").End(),
                            height: 50f,
                            onTap: () => { }),
                        new GradintBtn(
                            colors: new List<Color> {Colors.lightBlue, Colors.blueAccent, Colors.cyan},
                            child: Q.Text.Data("Submit").End(),
                            height: 50f,
                            onTap: () => { }),
                        new TurnBox(
                            turns:turns,
                            speed:0.5f,
                            child:new Icon(Icons.refresh,size:50)),
                        Q.RaisButton
                            .Child(Q.Text.Data("旋转").Size(40).End())
                            .OnPressed(()=>setState(()=>turns-=0.5f))
                            .End()
                    )
                    .End();
            }
        }
    }




    public class GradintBtn : StatelessWidget
    {
        public GradintBtn(Key key = null,
            GestureTapCallback onTap = null,
            List<Color> colors = null,
            float width = float.MaxValue,
            float height = 100,
            Widget child = null) : base(key)
        {
            this.colors = colors;
            this.width = width;
            this.height = height;
            this.child = child;
            this.onTap = onTap;
        }

        private List<Color> colors;

        private float width, height;

        private Widget child;

        private GestureTapCallback onTap;

        public override Widget build(BuildContext context)
        {
            var themeData = Theme.of(context);
            var colors = this.colors ?? new List<Color>
            {
                themeData.primaryColor,
                themeData.primaryColorDark ?? themeData.primaryColor
            };
            return new DecoratedBox(
                decoration: new BoxDecoration(
                    gradient: new LinearGradient(colors: colors)),
                child: new Material(
                    type: MaterialType.transparency,
                    child: new InkWell(
                        splashColor: colors[colors.Count - 1],
                        highlightColor: Colors.transparent,
                        onTap: onTap,
                        child: new ConstrainedBox(
                            constraints: BoxConstraints.tightFor(width, height),
                            child: new Center(
                                child: new Padding(
                                    padding: EdgeInsets.all(8),
                                    child: new DefaultTextStyle(
                                        style: new TextStyle(fontWeight: FontWeight.bold),
                                        child: child)
                                ))))));
        }
    }

    public class TurnBox : StatefulWidget
    {
        public readonly float? Turns;
        public readonly float? Speed;
        [CanBeNull] public readonly Widget Child;

        public TurnBox(float turns, float speed, Widget child)
        {
            Turns = turns;
            Speed = speed;
            Child = child;
        }

        public override State createState()
        {
            return new TurnBoxState();
        }

        public class TurnBoxState : State<TurnBox>, TickerProvider
        {
            private AnimationController mController;

            public override void initState()
            {
                base.initState();
                mController = new AnimationController(
                    vsync: this,
                    value: widget.Turns,
                    lowerBound: float.NegativeInfinity,
                    upperBound: float.PositiveInfinity);
            }

            public override void dispose()
            {
                base.dispose();
                mController.dispose();
            }

            public override Widget build(BuildContext context)
            {
                return new RotationTransition(
                    turns: mController,
                    child: widget.Child);
            }

            public override void didUpdateWidget(StatefulWidget oldWidget)
            {
                base.didUpdateWidget(oldWidget);
                //旋转角度发生变化时执行过渡动画
                if ((oldWidget as TurnBox).Turns != widget.Turns)
                {
                    mController.animateTo(
                        widget.Turns.Value,
                        duration: TimeSpan.FromSeconds(widget.Speed ?? 0.2),
                        Curves.ease);
                }
            }

            public Ticker createTicker(TickerCallback onTick)
            {
                return new Ticker(onTick);
            }
        }
    }
}