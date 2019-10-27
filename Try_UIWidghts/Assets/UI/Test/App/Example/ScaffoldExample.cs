using System.Collections.Generic;
using System.Linq;
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

namespace UI.Test.App
{
    public class ScaffoldExample : UIWidgetsPanel
    {
        protected override void OnEnable()
        {
            base.OnEnable();
            //使用ICons必须导入这样的文件
            FontManager.instance.addFont(Resources.Load<Font>("MaterialIcons-Regular"), "Material Icons");
        }

        protected override Widget createWidget()
        {
            return new ScaffoldRoute().GetMaterialApp();
        }
    }

    public class ScaffoldRoute : StatefulWidget
    {
        public override State createState()
        {
            return new ScaffoldRouteState();
        }
    }

    public class ScaffoldRouteState : State<ScaffoldRoute>, TickerProvider

    {
        private int selectedIndex = 1;

        private TabController mTabController = null;

        private List<string> mTabs = new List<string>
        {
            "推荐", "最近", "女优","欧美","日韩"
        };


        public override void initState()
        {
            base.initState();
            mTabController = new TabController(
                length: mTabs.Count,
                vsync: this);
            mTabController.addListener(() => { });
        }


        public override Widget build(BuildContext context)
        {
            return new Scaffold(
                drawer: new MyDrawer(),
                body: new TabBarView(
                    controller: mTabController,
                    children: mTabs
                        .Select(tab =>Q.Container
                            .Alignment(Alignment.center)
                            .Child(Q.Text
                                .Data(tab)
                                .Size(100)
                                .End())
                            .End() as Widget).ToList()
                ),
                appBar: new AppBar(
                    title: Q.Text.Data("香蕉视频").End(),
                    actions: new List<Widget>
                    {
                        Q.IconBtn.IconData(Icons.share).OnPressed(null).End()
                    },
                    bottom: new TabBar(
                        controller: mTabController,
                        tabs: mTabs.Select(tab => new Tab(text: tab, icon: new Icon(Icons.ac_unit)) as Widget).ToList()
                    )
                ),
                bottomNavigationBar: new BottomAppBar(
                    color: Color.white,
                    shape: new CircularNotchedRectangle(),//在中间挖一个洞，用于放置悬浮按钮
                    child: Q.Row
                        .Children(
                            Q.IconBtn.IconData(Icons.home).End(),
                            Q.IconBtn.IconData(Icons.wifi).End(),
                            new SizedBox(),//为悬浮按钮留出空间
                            Q.IconBtn.IconData(Icons.book).End(),
                            Q.IconBtn.IconData(Icons.business).End()
                        )
                        .MainAxisAlignment(MainAxisAlignment.spaceAround)
                        .End()),
                floatingActionButton:Q.IconBtn.IconData(Icons.add_circle).Size(100).Color(Colors.orange).End(),
                floatingActionButtonLocation:FloatingActionButtonLocation.centerDocked
            );
//                    items: new List<BottomNavigationBarItem>
//                    {
//                        new BottomNavigationBarItem(icon: new Icon(icon: Icons.home), title: Q.Text.Data("Home").End()),
//                        new BottomNavigationBarItem(icon: new Icon(icon: Icons.business),
//                            title: Q.Text.Data("business").End()),
//                        new BottomNavigationBarItem(icon: new Icon(icon: Icons.school),
//                            title: Q.Text.Data("school").End())
//                    },
//                    currentIndex: selectedIndex,
//                    fixedColor: Colors.blue,
//                    onTap: value => { setState(() => { selectedIndex = value; }); })
//            );
        }

        public Ticker createTicker(TickerCallback onTick)
        {
            return new Ticker(onTick);
        }
    }
}