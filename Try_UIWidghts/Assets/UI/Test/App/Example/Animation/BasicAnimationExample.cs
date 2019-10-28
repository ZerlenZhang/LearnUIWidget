using System;
using UI.Test.Utility;
using Unity.UIWidgets.animation;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.scheduler;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace UI.Test.App.Animation
{
    public class BasicAnimationExample : UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return new BasicAnimationRoute().GetScaffold().GetMaterialApp();
        }
    }

    public class BasicAnimationRoute : StatefulWidget
    {
        public override State createState()
        {
            return new BasicAnimationState();
        }
    }



    public class GrowTransition : StatelessWidget
    {
        private Widget mChild;
        private Animation<float> mAnimation;
        public GrowTransition(Animation<float> animation,Widget child)
        {
            mChild = child;
            mAnimation = animation;
        }

        public override Widget build(BuildContext context)
        {
            return new AnimatedBuilder(
                animation: mAnimation,
                child: mChild,
                builder: (buildContext, child) =>new Center(
                    child: Q.Container
                        .Height(mAnimation.value)
                        .Width(mAnimation.value)
                        .Child(child)
                        .End())
            );
        }
    }
    

    public class BasicAnimationState : State<BasicAnimationRoute>,TickerProvider
    {
        Animation<float> animation;
        AnimationController controller;
        

        public override void initState()
        {
            base.initState();
            
            controller = new AnimationController(
                duration: TimeSpan.FromSeconds(3),
                vsync:this);

            #region BasicAnimation

            //图片宽高从0变到300
//            animation=new FloatTween(0,300).animate(controller);

            #endregion

            #region 使用曲线动画
            
            animation = new CurvedAnimation(controller, Curves.bounceIn);
            
            animation =new FloatTween(0,300).animate(animation);
            
            #endregion

            controller.addStatusListener(status=>Debug.Log(status));
            
            //启动动画(正向执行)
            controller.forward();
        }

        public override Widget build(BuildContext context)
        {
            return new GrowTransition(
                child: new Center(child: Image.asset("unity-white")),
                animation:animation);

            
//            return new AnimatedBuilder(
//                animation: animation,
//                child: new Center(child: Image.asset("unity-white")),
//                builder: (buildContext, child) =>new Center(
//                        child: Q.Container
//                            .Height(animation.value)
//                            .Width(animation.value)
//                            .Child(child)
//                            .End())
//                );
        }

        public override void dispose()
        {
            base.dispose();
            //路由销毁时需要释放动画资源
            controller.dispose();
        }

        public Ticker createTicker(TickerCallback onTick)
        {
            return new Ticker(onTick);
        }
    }
}