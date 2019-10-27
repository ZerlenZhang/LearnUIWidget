using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public partial class Q
    {
        public static StackBuilder Stack=>new StackBuilder();
    }
    public class StackBuilder:MutiChildBuilder<StackBuilder>
    {
        private Alignment _alignment;
        private StackFit _stackFit=Unity.UIWidgets.rendering.StackFit.loose;

        public StackBuilder Alignment(Alignment alignment)
        {
            this._alignment = alignment;
            return this;
        }

        public StackBuilder StackFit(StackFit stackFit)
        {
            this._stackFit = stackFit;
            return this;
        }
        
        public Stack End()
        {
            return new Stack(
                alignment:_alignment,
                fit:_stackFit,
                children:children);
        }
    }
}