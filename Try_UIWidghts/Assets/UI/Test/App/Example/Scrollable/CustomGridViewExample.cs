using System.Collections.Generic;
using com.unity.uiwidgets.Runtime.rendering;
using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace UI.Test.App.Example.Scrollable
{
    public class CustomGridViewExample : UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return new CustomScrollView(
                slivers: new List<Widget>
                {
                    new SliverAppBar(
                        pinned: true,
                        expandedHeight: 250f,
                        flexibleSpace: new FlexibleSpaceBar(title: Q.Text.Data("Demo").End()))
//                    new SliverPadding(
//                        padding: EdgeInsets.all(8),
//                        sliver: new SliverGrid(
//                            gridDelegate: new SliverGridDelegateWithFixedCrossAxisCount(2, 10.0f, 10.0f, 4f),
//                            layoutDelegate: new SliverChildBuilderDelegate(
//                                childCount: 20,
//                                builder: (context, index) => Q.Container
//                                    .Alignment(Alignment.center)
//                                    .Color(Colors.cyan[100 * (index % 9)])
//                                    .Child(Q.Text
//                                        .Data($" Grid Item {index}")
//                                        .Size(40)
//                                        .End())
//                                    .End()))
//                    )
                }
            ).GetScaffold().GetMaterialApp();
        }
    }
}