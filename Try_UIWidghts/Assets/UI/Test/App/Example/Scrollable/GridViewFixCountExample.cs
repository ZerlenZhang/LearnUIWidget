using System.Collections.Generic;
using System.Linq;
using com.unity.uiwidgets.Runtime.rendering;
using UI.Test.Utility;
using UI.Test.Widgets.ExampleDrawers;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.scheduler;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;
using Color = Unity.UIWidgets.ui.Color;
using Icons = Unity.UIWidgets.material.Icons;

namespace UI.Test.App
{
    public class GridViewFixCountExample : UIWidgetsPanel
    {
        protected override void OnEnable()
        {
            base.OnEnable();
            //使用ICons必须导入这样的文件
            FontManager.instance.addFont(Resources.Load<Font>("MaterialIcons-Regular"), "Material Icons");
        }

        protected override Widget createWidget()
        {
            //指定列数的GridView，你拉动总宽度的时候，总列数不会变，始终平分总宽度
            return GridView.count(
                    crossAxisCount: 3,
                    childAspectRatio: 1,
                    children: new List<Widget>
                    {
                        new Icon(icon: Icons.ac_unit,size:80),
                        new Icon(icon: Icons.shuffle,size:80),
                        new Icon(icon: Icons.wb_cloudy,size:80),
                        new Icon(icon: Icons.edit,size:80),
                        new Icon(icon: Icons.headset,size:80),
                        new Icon(icon: Icons.shuffle,size:80),
                        new Icon(icon: Icons.wb_cloudy,size:80),
                        new Icon(icon: Icons.edit,size:80),
                        new Icon(icon: Icons.headset,size:80),
                        new Icon(icon: Icons.shuffle,size:80),
                        new Icon(icon: Icons.wb_cloudy,size:80),
                        new Icon(icon: Icons.edit,size:80),
                        new Icon(icon: Icons.headset,size:80),
                    })
                .GetScaffold()
                .GetMaterialApp();
        }
    }
}