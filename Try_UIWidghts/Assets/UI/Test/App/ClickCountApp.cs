using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.widgets;

namespace UI.Test.App
{
    public class ClickCountApp:UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return new Counter();
        }
    }

    public class Counter : StatefulWidget
    {
        public override State createState()
        {
            return new CounterState();
        }
    }

    public class CounterState : State<Counter>
    {
        private int clickCount = 0;
        public override Widget build(BuildContext context)
        {
            return new GestureDetector(
                child:Q.Text
                    .Data("ClickCount: "+clickCount)
                    .Size(70)
                    .End(),
                onTap:()=>this.setState(()=>this.clickCount++));
        }
    }
}