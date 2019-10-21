using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace UI.Test.App
{
    public class CheckBoxExample : UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return new MaterialApp(
                home: new Scaffold(
                    body: new SwitchCheckboxWidget()));
            ;
        }
    }

    public class SwitchCheckboxWidget : StatefulWidget
    {
        public override State createState()
        {
            return new SwitchCheckboxState();
        }
    }

    public class SwitchCheckboxState : State<SwitchCheckboxWidget>
    {
        private bool? mSwitch = false;
        private bool? mCheck = false;

        public override Widget build(BuildContext context)
        {
            return Q.ListView
                .Child(Q.Checkbox
                    .Value(mCheck)
                    .OnChanged(v => this.setState(() => mCheck = v))
                    .End())
                .Child(Q.Switch
                    .Value(mSwitch)
                    .OnChanged(v => setState(() => mSwitch = v))
                    .End())
                .End();
        }
    }
}