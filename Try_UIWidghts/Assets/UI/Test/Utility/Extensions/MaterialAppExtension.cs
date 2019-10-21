using Unity.UIWidgets.material;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public static class MaterialAppExtension
    {
        public static MaterialApp GetMaterialApp(this Widget widget)
        {
            return new MaterialApp(
                home:widget);
        }
    }
}