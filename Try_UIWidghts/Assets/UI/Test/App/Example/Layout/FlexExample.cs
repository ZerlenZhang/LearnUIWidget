using System.Collections.Generic;
using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.widgets;

namespace UI.Test.App
{
    public class FlexExample:UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return Q.Flex
                .Direction(Axis.horizontal)
                .Children(   
                    Q.Container.Color(Colors.blue).End().GetExpanded(1),
                    Q.Container.Color(Colors.red).End().GetExpanded(2)
                    )
                .End()   
                .GetScaffold()
                .GetMaterialApp();
        }
    }
}