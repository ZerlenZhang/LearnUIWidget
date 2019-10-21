using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UI.Test.Models;
using UI.Test.Redux.Store;
using UI.Test.Utility;
using UI.Test.ViewStates;
using UI.Test.Widgets;
using UI.Test.Widgets.Screens;
using Unity.UIWidgets;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.Redux;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace UI.Test.App
{
    /// <summary>
    /// 代办事项APP
    /// </summary>
    public class ToDoListApp : UIWidgetsPanel
    {
        protected override void OnEnable()
        {
            base.OnEnable();
            //使用ICons必须导入这样的文件
            FontManager.instance.addFont(Resources.Load<Font>("MaterialIcons-Regular"), "Material Icons");
        }

        protected override Widget createWidget()
        {
            //MaterialApp，路由和Home不能同时使用
            var app = new MaterialApp(
                //初始路由
                initialRoute: "/",
                
                #region 配置路由
                routes:
                new Dictionary<string, WidgetBuilder>
                {
                    {"/", builder => new HomeScreen()},
                }
                #endregion
            );
            
            //这是Redux消息框架的使用，这里是初始化消息监听和处理
            var store = new Store<PageState>(
                //事件监听器
                Reducers.Reduce,
                //初始状态
                new PageState(),
                //中间件——存储
                SaveMiddleware.create<PageState>(),
                ReduxThunk.create<PageState>());
            
            return new StoreProvider<PageState>(store, app);
        }
    }
}