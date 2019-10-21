using System;
using System.Collections.Generic;
using UI.Test.Models;
using UI.Test.Redux.Store;
using UI.Test.Utility;
using UI.Test.ViewStates;
using Unity.UIWidgets;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.Redux;
using Unity.UIWidgets.widgets;

namespace UI.Test.Widgets
{
    public class ToDoListPage : StatefulWidget
    {
        public override State createState()
        {
            return new ToDoListState();
        }
    }
    
    public class ToDoListState : State<ToDoListPage>
    {
        public override Widget build(BuildContext context)
        {
            return new StoreConnector<PageState,PageState>(
                converter:state=>state,
                builder: (buildContext, model, dispatcher) =>
                {
                    return Q.ListView
                            //异步消息检测
                        .Child(Q.IconBtn
                            .IconData(Icons.network_wifi)
                            .Color(Colors.green)
                            .Size(90)
                            .OnPressed(() => { dispatcher.dispatch(NetworkRequestAction.Create()); })
                            .End())
                        //输入框
                        .Child(
                            new ToDoInputView(
                                str =>
                                {
                                    dispatcher.dispatch(new AddToDoAction(str));
                                }))
                        //已经输入的条目
                        .Child(ToDoViews(model.todoDatas,model.PageType,dispatcher))
                        .Padding(EdgeInsets.only(0, 50))
                        .End();
                });
        }

        
        private Widget[] ToDoViews(List<ToDoModel> toDoDatas,ToDoPageMode pageType,Dispatcher dispatcher)
        {
                var list = new List<Widget>();
                foreach (var data in toDoDatas)
                {
                    if (!CheckToDoModel(data,pageType))
                        continue;
                    list.Add(new ToDoView(data, 
                        () =>dispatcher.dispatch(new DeleteToDoAction(data)),
                        state => dispatcher.dispatch(new TodoStateChangeAction(data,state)),
//                        null));
                            newContent=>dispatcher.dispatch(new UpdateToDoAction(data,newContent))));
                    list.Add(new Divider());
                }

                return list.ToArray();
        }

        private bool CheckToDoModel(ToDoModel model,ToDoPageMode currentState)
        {
            switch (currentState)
            {
                case ToDoPageMode.All:
                    return true;
                case ToDoPageMode.Finished:
                    return model.finished;
                case ToDoPageMode.UnFinished:
                    return !model.finished;
                default:
                    throw new Exception("???");
            }
        }
    }
}