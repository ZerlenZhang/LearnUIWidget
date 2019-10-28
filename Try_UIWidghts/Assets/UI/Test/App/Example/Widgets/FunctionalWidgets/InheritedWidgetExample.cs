using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace UI.Test.App.Widgets
{
    public class InheritedWidgetExample:UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return new InheritedWidgetRoute();
        }
    }
    
    public class  InheritedWidgetRoute:StatefulWidget
    {
        public override State createState()
        {
            return new InheritedWidgetState();
        }
    }

    public class InheritedWidgetState : State<InheritedWidgetRoute>
    {
        private int mCount;
        public override Widget build(BuildContext context)
        {
            return new Center(
                child:new ShareDataWidget(
                    mCount,
                    Q.Colum
                        .CrossAxisAlignment(CrossAxisAlignment.center)
                        .Children(
                            new TestWidet().GetPadding(EdgeInsets.only(bottom:20)),
                            Q.RaisButton
                                .Child(Q.Text
                                    .Data("Inherite")
                                    .End())
                                .OnPressed(()=>setState(()=>mCount++))
                                .End()

                        )
                        
                        .End()));
        }
    }

    public class ShareDataWidget : InheritedWidget
    {

        public int mData { get; private set; }
        public ShareDataWidget(int data, Widget child):base(child:child)
        {
            mData = data;
        }

        public static ShareDataWidget of(BuildContext context)
        {
            return context.inheritFromWidgetOfExactType(typeof(ShareDataWidget)) as ShareDataWidget;
        }
        
        public override bool updateShouldNotify(InheritedWidget oldWidget)
        {
            return (oldWidget as ShareDataWidget).mData != mData;
        }
    }



    #region TestWidget


    public class TestWidet:StatefulWidget
    {
        public override State createState()
        {
            return new TestWidgetState();
        }
    }

    public class TestWidgetState : State<TestWidet>
    {
        /// <summary>
        /// 这里由于TestWidget中使用/依赖了ShareDataWidget，所以，
        /// 当ShareDataWidget发生更新以后，didChangeDependencies会调用
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Widget build(BuildContext context)
        {
            return Q.Text
                .Data(ShareDataWidget.of(context).mData.ToString())
                .End();
        }

        public override void didChangeDependencies()
        {
            base.didChangeDependencies();
            Debug.Log("依赖改变");
        }
    }

    #endregion
    
    
    
    
    
    
    
    
    
}