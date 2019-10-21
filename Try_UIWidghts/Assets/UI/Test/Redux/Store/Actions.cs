using System.Net.Http;
using UI.Test.Models;
using UI.Test.ViewStates;
using Unity.UIWidgets.Redux;

namespace UI.Test.Redux.Store
{
    public class ListPageAction
    {
    }

    public class FinishPageAction
    {
    }

    public class UnFinishPageAction
    {
    }

    public class AddToDoAction
    {
        public string content;

        public AddToDoAction(string content)
        {
            this.content = content;
        }
    }

    public class UpdateToDoAction
    {
        public readonly ToDoModel toDoModel;
        public readonly string newContent;

        public UpdateToDoAction(ToDoModel doModel, string newContent)
        {
            toDoModel = doModel;
            this.newContent = newContent;
        }
    }

    public class DeleteToDoAction
    {
        public readonly ToDoModel target;

        public DeleteToDoAction(ToDoModel target)
        {
            this.target = target;
        }
    }
    public class TodoStateChangeAction
    {
        public readonly ToDoModel target;
        public readonly bool State;

        public TodoStateChangeAction(ToDoModel target,bool state)
        {
            this.target = target;
            this.State = state;
        }
    }

    public class NetworkRequestAction
    {
        public string Result { get; set; }

        public static ThunkAction<PageState> Create()
        {
            return new ThunkAction<PageState>(
                (dispatcher, getState) =>
                {
                    var client = new HttpClient();
                    var task = client.GetAsync("http://sikiedu.com");

                    task.GetAwaiter().OnCompleted(() =>
                    {
                        var conentTask = task.Result.Content.ReadAsStringAsync();
                        conentTask.GetAwaiter().OnCompleted(() =>
                        {
                            dispatcher.dispatch(new NetworkRequestAction
                            {
                                Result = conentTask.Result
                            });
                        });
                    });

                    return null;
                }
            );
        }
    }
}