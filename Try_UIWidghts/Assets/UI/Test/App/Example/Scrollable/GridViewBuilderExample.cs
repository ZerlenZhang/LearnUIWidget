using System;
using System.Collections.Generic;
using System.Linq;
using com.unity.uiwidgets.Runtime.rendering;
using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.scheduler;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace UI.Test.App
{
    public class GridViewBuilderExample:UIWidgetsPanel
    {        
        protected override void OnEnable()
        {
            base.OnEnable();
            //使用ICons必须导入这样的文件
            FontManager.instance.addFont(Resources.Load<Font>("MaterialIcons-Regular"), "Material Icons");
        }

        protected override Widget createWidget()
        {
            return new GridViewBuilderWidget().GetScaffold().GetMaterialApp();
        }
    }

    public class GridViewBuilderWidget : StatefulWidget
    {
        public override State createState()
        {
            return new GridViewBuilderState();
        }
    }

    public class GridViewBuilderState : State<GridViewBuilderWidget>
    {
        private List<IconData> mIcons = new List<IconData>();


        public override void initState()
        {
            base.initState();
            ReGetIcons();
        }

        public override Widget build(BuildContext context)
        {
            return GridView.builder(
                gridDelegate: new SliverGridDelegateWithFixedCrossAxisCount(3, 1),
                itemCount: mIcons.Count,
                itemBuilder: (buildContext, index) =>
                {
                    if (index == mIcons.Count - 1 && mIcons.Count < 200)
                    {
                        ReGetIcons();
                    }

                    return new Icon(mIcons[index]);
                });
        }

        private void ReGetIcons()
        {
            TickerFutureImpl.Delayed(TimeSpan.FromSeconds(2))
                .Then(() =>
                    setState(()=>
                        mIcons.AddRange(new []
                        {
                            Icons.ac_unit,
                            Icons.do_not_disturb,
                            Icons.games,
                            Icons.adb,
                            Icons.warning,
                            Icons.queue,
                            Icons.opacity,
                            Icons.vibration
                        }))
                );
        }
    }
}