using System.Collections.Generic;
using UI.Test.Models;
using UI.Test.Redux.Store;
using UI.Test.Utility;
using UI.Test.ViewStates;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.Redux;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace UI.Test.Widgets.Screens
{
    /// <summary>
    /// 主屏幕显示类
    /// </summary>
    public class HomeScreen : StatelessWidget
    {
        public override Widget build(BuildContext buildContext)
        {
            //Scaffold 脚手架
            //MaterialApp的一种。。。框架？
            //这个脚手架可以帮助我们加入 drawer, appBar,floatingButton等组件
            return new Scaffold(
                drawer:

                #region Drawer

                Q.Container
                    .Width(600)
                    .Child(new Drawer(
                        child: Q.ListView
                            .Child(
                                //需要监听或分发消息的Widget,需要这样build——用StoreConnector包起来
                                //第一个泛型，是监听或分发的状态类
                                //第二个泛型是你想要从中获取的信息的类型
                                //第一个参数converter就是一个把状态转化成目标类型的委托
                                new StoreConnector<PageState, object>(
                                    converter: (state) => null,
                                    builder: (context, model, dispatcher) =>
                                    {
                                        return new ListTile(
                                            title: Q.Text
                                                .Data("全部事项")
                                                .Size(70)
                                                .End()
                                                .OnTap(() => { dispatcher.dispatch(new ListPageAction()); }),
                                            leading: new Icon(Icons.list, size: 60));
                                    })
                            )
                            .Child(new Divider())
                            .Child(new StoreConnector<PageState, object>(
                                converter: (state) => null,
                                builder: (context, model, dispatcher) =>
                                {
                                    return new ListTile(
                                        title: Q.Text
                                            .Data("已完成")
                                            .Size(70)
                                            .End()
                                            .OnTap(() => { dispatcher.dispatch(new FinishPageAction()); }),
                                        leading: new Icon(Icons.check_circle, size: 60));
                                }))
                            .Child(new Divider())
                            .Child(new StoreConnector<PageState, object>(
                                converter: (state) => null,
                                builder: (context, model, dispatcher) =>
                                {
                                    return new ListTile(
                                        title: Q.Text
                                            .Data("未完成")
                                            .Size(70)
                                            .End()
                                            .OnTap(() => { dispatcher.dispatch(new UnFinishPageAction()); }),
                                        leading: new Icon(Icons.check_circle_outline, size: 60));
                                }))
                            .Child(new Divider())
                            .End()))
                    .End(),

                #endregion

                appBar:

                #region appBar

                new AppBar(
                    actions: new List<Widget>()
                    {
                        new Icon(Icons.hd, size: 65),
                        new Icon(Icons.wc, size: 65),
                        new PopupMenuButton<Choice>(
                            onSelected: (choise) => Debug.Log(choise.title),
                            itemBuilder: (subContext) =>
                            {
                                List<PopupMenuEntry<Choice>> popupItems = new List<PopupMenuEntry<Choice>>();
                                for (int i = 2; i < Choice.choices.Count; i++)
                                {
                                    popupItems.Add(new PopupMenuItem<Choice>(
                                        value: Choice.choices[i],
                                        child:
                                        Q.Container
                                            .Width(60000)
                                            .Alignment(Alignment.centerLeft)
                                            .Child(Q.Text.Data(Choice.choices[i].title)
                                                .Size(50)
                                                .End())
                                            .End(),
                                        height: 100
                                    ));
                                }

                                return popupItems;
                            })
                    },
                    title: new Center(
                        child: Q.Text
                            .Data("ToDoList")
                            .End())
                ),

                #endregion

                body: new ToDoListPage(),
                floatingActionButtonLocation: FloatingActionButtonLocation.centerFloat,
                floatingActionButton:
                Q.Container
                    .Width(200)
                    .Height(200)
                    .Margin(EdgeInsets.only(bottom: 50))
                    .Child(new FloatingActionButton(
                        backgroundColor: Colors.redAccent,
                        child: new Icon(Unity.UIWidgets.material.Icons.add_alert, size: 100),
                        onPressed: () => Debug.Log("Click")))
                    .End()
            );
        }
    }
}