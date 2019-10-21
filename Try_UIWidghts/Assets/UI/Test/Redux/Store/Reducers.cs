using System.Linq;
using UI.Test.Models;
using UI.Test.ViewStates;
using UnityEngine;

namespace UI.Test.Redux.Store
{
    /// <summary>
    /// Reduce是Redux架构中的消息处理器，在这里对收到消息，作出反应
    /// </summary>
    public class Reducers
    {
        public static PageState Reduce(PageState previousState, object action)
        {
            switch (action)
            {
                case ListPageAction _: //全部
                    return new PageState(ToDoPageMode.All);
                case FinishPageAction _: //已完成
                    return new PageState(ToDoPageMode.Finished);
                case UnFinishPageAction _: //未完成
                    return new PageState(ToDoPageMode.UnFinished);
                case AddToDoAction addToDoAction: //添加项
                    var preList = previousState.todoDatas;
                    preList.Add(new ToDoModel(addToDoAction.content));
                    return new PageState(previousState.PageType, preList);
                case UpdateToDoAction updateToDoAction: //更新项
                    return new PageState(previousState.PageType,
                        previousState.todoDatas.Select(todo =>
                        {
                            if (todo == updateToDoAction.toDoModel)
                                todo.content = updateToDoAction.newContent;
                            return todo;
                        }).ToList());
                case DeleteToDoAction deleteToDoAction: //删除项
                    return new PageState(
                        previousState.PageType,
                        previousState.todoDatas.Where(todo => todo != deleteToDoAction.target).ToList());
                case TodoStateChangeAction finishToDoAction://改变项状态
                    return new PageState(
                        previousState.PageType,
                        previousState.todoDatas
                            .Select(todo =>
                            {
                                if (todo == finishToDoAction.target)
                                    todo.finished = finishToDoAction.State;
                                return todo;
                            })
                            .ToList());
                case NetworkRequestAction networkRequestAction://网络请求
                    Debug.Log(networkRequestAction.Result);
                    return previousState;
            }

            return previousState;
        }
    }
}