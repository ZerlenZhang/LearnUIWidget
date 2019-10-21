using Unity.UIWidgets.material;

namespace UI.Test.Utility
{
    public partial class Q
    {
        public static OutlineButtonBuilder OutlineButton => new OutlineButtonBuilder();
    }

    public class OutlineButtonBuilder:ButtonBuilder<OutlineButtonBuilder>
    {
        public OutlineButton End()
        {
            return new OutlineButton(
                child: child,
                onPressed: this.onPressed,
                textColor:textColor,
                disabledTextColor:disabledTextColor,
                color:color,
                splashColor:splashColor,
                highlightColor:highlightColor,
                padding:padding,
                shape:mShape);
        }
    }
}