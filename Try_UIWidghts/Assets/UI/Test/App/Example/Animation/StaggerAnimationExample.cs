using System;
using UI.Test.Utility;
using Unity.UIWidgets.animation;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.scheduler;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.App.Animation
{
    public class StaggerAnimationExample:UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return new StaggerDemoWidget().GetScaffold().GetMaterialApp();
        }
    }

    public class StaggerDemoWidget : StatefulWidget
    {
        public override State createState()
        {
            return new StaggerDemoState();
        }
    }

    public class StaggerDemoState : State<StaggerDemoWidget>,TickerProvider
    {
        private AnimationController _animationController;

        public override void initState()
        {
            base.initState();
            _animationController=new AnimationController(
                duration:TimeSpan.FromSeconds(2),
                vsync:this);
        }

        public override Widget build(BuildContext context)
        {
            return new GestureDetector(
                behavior:HitTestBehavior.opaque,
                onTap: () => PlayAnimation(),
                child:new Center(
                    child:Q.Container
                        .Width(300)
                        .Height(300)
                        .Child(new StaggerAnimation(_animationController))
                        .Decoration(new BoxDecoration(
                            color:Colors.black.withOpacity(0.1f),
                            border:Border.all(Colors.black.withOpacity(0.5f))))
                        .End()));
        }

        private void PlayAnimation()
        {
            _animationController.forward().orCancel.Then(() =>
                _animationController.reverse().orCancel.Then(() => { }));
        }

        public Ticker createTicker(TickerCallback onTick)
        {
            return new Ticker(onTick);
        }
    }

    public class StaggerAnimation : StatelessWidget
    {
        private Animation<float> mController;
        private Animation<float> height;
        private Animation<EdgeInsets> padding;
        private Animation<Color> color;

        public StaggerAnimation(Animation<float> controller)
        {
            this.mController = controller;
            height = new FloatTween(0, 300).animate(
                new CurvedAnimation(mController, new Interval(0, 0.6f), Curves.ease));
            color=new ColorTween(Colors.green,Colors.red).animate(
                new CurvedAnimation(mController, new Interval(0, 0.6f), Curves.ease));
            padding=new EdgeInsetsTween(EdgeInsets.only(left:0),EdgeInsets.only(100)).animate(
                new CurvedAnimation(mController, new Interval(0.6f, 1.0f), Curves.ease));

        }
        public override Widget build(BuildContext context)
        {
            return new AnimatedBuilder(
                animation:mController,
                builder:(_,child)=>Q.Container
                    .Alignment(Alignment.bottomCenter)
                    .Padding(padding.value)
                    .Child(Q.Container
                        .Color(color.value)
                        .Width(50)
                        .Height(height.value)
                        .End())
                    .End());
        }
    }
    
    
}