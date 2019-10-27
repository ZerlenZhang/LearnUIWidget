using Unity.UIWidgets.painting;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public static class DecorationExtension
    {
        public static DecoratedBox GetDecoratedBox(this Widget widget,Decoration decoration)
        {
            return new DecoratedBox(child:widget,
                decoration:decoration);
        }
    }
}