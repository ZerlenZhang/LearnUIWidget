using System;
using UI.Test.Utility;
using Unity.UIWidgets.animation;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace UI.Test.App.Example.Scrollable
{
    public class ScrollControllerExample:UIWidgetsPanel
    {        
        protected override void OnEnable()
        {
            base.OnEnable();
            //使用ICons必须导入这样的文件
            FontManager.instance.addFont(Resources.Load<Font>("MaterialIcons-Regular"), "Material Icons");
        }

        protected override Widget createWidget()
        {
            return new ScrollControllerWidget().GetMaterialApp();
        }
    }

    public class ScrollControllerWidget : StatefulWidget
    {
        public override State createState()
        {
            return new ScrollControllerState();
        }
    }

    public class ScrollControllerState : State<ScrollControllerWidget>
    {
        private ScrollController mController = new ScrollController();
        private bool mShowToTopBtn = false;//显示返回顶部按钮

        public override void initState()
        {
            base.initState();
            mController.addListener(() =>
            {
                if (mController.offset < 1000 && mShowToTopBtn)
                {
                    setState(()=>mShowToTopBtn=false);
                }
                else if(mController.offset>=1000 && mShowToTopBtn==false)
                {
                    setState(() => mShowToTopBtn = true);
                }
            });
        }

        public override void dispose()
        {
            base.dispose();
            mController.dispose();
            mController = null;
        }

        public override Widget build(BuildContext context)
        {
            return new Scaffold(
                body:new Scrollbar(
                    child:ListView.builder(
                        itemCount:100,
                        itemExtent:50,
                        controller:mController,
                        itemBuilder:((buildContext, index) =>new ListTile(title:Q.Text.Data(index.ToString()).Size(50).End()) ))
                    ),
                floatingActionButton:!mShowToTopBtn? null:new FloatingActionButton(
                    child:new Icon(Icons.arrow_upward),
                    onPressed:()=>setState(() => { mController.animateTo(0, TimeSpan.FromSeconds(0.2f), Curves.ease); }))
            );
        }
    }
}