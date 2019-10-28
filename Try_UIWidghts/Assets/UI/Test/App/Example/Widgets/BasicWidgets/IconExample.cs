using Unity.UIWidgets.engine;
using Unity.UIWidgets.ui;
using UnityEngine;

namespace UI.Test.App
{
    public class IconExample:UIWidgetsPanel
    {
        protected override void OnEnable()
        {
            base.OnEnable();
            FontManager.instance.addFont(Resources.Load<Font>("MaterialIcons-Regular"), "Material Icons");
        }
    }
}