using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public static class ExpandedExtension
    {
        public static Expanded GetExpanded(this Widget widget,int flex)
        {
            return new Expanded(
                flex:flex,
                child:widget);
        }
    }
}