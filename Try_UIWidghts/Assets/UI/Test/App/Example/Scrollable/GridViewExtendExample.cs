using System.Collections.Generic;
using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace UI.Test.App
{
    public class GridViewExtendExample:UIWidgetsPanel
    {
        protected override void OnEnable()
        {
            base.OnEnable();
            //使用ICons必须导入这样的文件
            FontManager.instance.addFont(Resources.Load<Font>("MaterialIcons-Regular"), "Material Icons");
        }

        protected override Widget createWidget()
        {
            //整个方法需要指定 maxCrossAxisExtent， 这个参数含义是每个格子最大宽度，随着你增大总宽度，列数会变化
            return GridView.extent(
                    maxCrossAxisExtent: 200,
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