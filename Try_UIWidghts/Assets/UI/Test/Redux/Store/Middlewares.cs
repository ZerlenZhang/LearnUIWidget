using UI.Test.Models;
using UI.Test.ViewStates;
using Unity.UIWidgets;

namespace UI.Test.Redux.Store
{
    /// <summary>
    /// 保存中间件
    /// </summary>
    public class SaveMiddleware
    {
        public static Middleware<State> create<State>()
            where State : PageState
        {
            return store => next => new DispatcherImpl(
                
                action =>
                {
                    var result = next.dispatch(action);
                    var afterState = store.getState();
                    DataPersistent.Save(afterState.todoDatas);
                    return result;

                });
        }
    }
}