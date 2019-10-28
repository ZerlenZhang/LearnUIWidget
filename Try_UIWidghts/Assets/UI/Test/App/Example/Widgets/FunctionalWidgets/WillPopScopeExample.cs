using System;
using RSG;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.scheduler;
using Unity.UIWidgets.widgets;

namespace UI.Test.App.Widgets
{
    public class WillPopScopeExample:UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return new WillPopScopeRoute();
        }
    }

    public class WillPopScopeRoute : StatefulWidget
    {
        public override State createState()
        {
            return new WillPopScopeState();
        }
    }

    public class WillPopScopeState : State<WillPopScopeRoute>
    {
        private DateTime _lastPressedAt;
        public override Widget build(BuildContext context)
        {
//            return new WillPopScope(
//                onWillPop: () =>TickerFutureImpl.Delayed(Time)
//
//
//
//                {
//                if (_lastPressedAt == null ||
//                    DateTime.Now.Ticks - _lastPressedAt.Ticks > 1000) {
//                    //两次点击间隔超过1秒则重新计时
//                    _lastPressedAt = DateTime.Now;
//                    return false;
//                }
//                return true;
//            },
//            child: new Container(
//                    alignment: Alignment.center,
//                    child: new Text("1秒内连续按两次返回键退出"),
//                )
//                );
            return null;
        }
    }
}