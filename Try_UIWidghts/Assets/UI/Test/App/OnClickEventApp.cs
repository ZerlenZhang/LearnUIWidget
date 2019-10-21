using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace UI.Test.App
{
    public class OnClickEventApp:UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return new GestureDetector(
                child: Q.Text
                    .Data("Click Me")
                    .Size(80)
                    .End(),
                onTap: () => Debug.Log("Click"));
        }
    }
}