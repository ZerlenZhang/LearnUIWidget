using Unity.UIWidgets.material;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public partial class Q
    {

        public static RaiseButtonBuilder RaisButton => new RaiseButtonBuilder();
    }

    public class RaiseButtonBuilder:ButtonBuilder<RaiseButtonBuilder>
    {
        public RaisedButton End()
        {
            return new RaisedButton(
                child: child,
                onPressed: this.onPressed,
                textColor:textColor,
                disabledTextColor:disabledTextColor,
                color:color,
                disabledColor:disabledColor,
                splashColor:splashColor,
                highlightColor:highlightColor,
                padding:padding,
                shape:mShape);
        }
    }
}