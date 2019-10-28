using System;
using UI.Test.Utility;
using Unity.UIWidgets.animation;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.widgets;

namespace UI.Test.App.Animation
{
    public class RouteTransitionExample : UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return new MaterialApp(
                home: new PageA());
        }
    }
    
    
    public class FadeRoute:PageRoute
    {
        public override TimeSpan transitionDuration { get; }

        public FadeRoute(RouteSettings settings, bool fullscreenDialog = false) : base(settings, fullscreenDialog)
        {
        }

        private WidgetBuilder _builder;

        public FadeRoute(TimeSpan transitionDuration, WidgetBuilder builder, RouteSettings settings=null):base(settings)
        {
            _builder = builder;
            this.transitionDuration = transitionDuration;
        }

        public override Widget buildPage(BuildContext context, Animation<float> animation, Animation<float> secondaryAnimation)
        {
            return _builder(context);
        }

        public override Widget buildTransitions(BuildContext context, Animation<float> animation, Animation<float> secondaryAnimation, Widget child)
        {
            return new FadeTransition(
                opacity:animation,
                child:_builder(context));
        }
    }


    public class PageA : StatelessWidget
    {
        public override Widget build(BuildContext context)
        {
            return Q.Container
                .Color(Colors.cyan)
                .Child(Q.Text
                    .Data("Page A")
                    .Size(100)
                    .Color(Colors.white54)
                    .End()
                    .OnTap(() =>
                        Navigator.push(context,new FadeRoute(
                            TimeSpan.FromSeconds(.5f),
                            _=>new PageB()))))
                .End();
        }
    }

    public class PageB : StatelessWidget
    {
        public override Widget build(BuildContext context)
        {
            return Q.Container
                .Color(Colors.teal)
                .Child(Q.Text
                    .Data("Page B")
                    .Size(100)
                    .Color(Colors.lime)
                    .End()
                    .OnTap(() =>
                        Navigator.push(context, new PageRouteBuilder(
                            transitionDuration: TimeSpan.FromSeconds(.5f),
                            pageBuilder: (buildContext, animation, secondaryAnimation) =>
//                                new SizeTransition(
//                                    sizeFactor:animation,
//                                    child:new PageA())
//                                new RotationTransition(
//                                    turns: animation,
//                                    child: new PageA())
                                new FadeTransition(
                                    opacity: animation,
                                    child: new PageA())
                        ))))
                .End();
        }
    }
}