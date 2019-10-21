using Unity.UIWidgets.material;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public static class ScaffoldExtension
    {
        public static Scaffold GetScaffold(this Widget widget)
        {
            return new Scaffold(
                body:widget);
        }
    }
}