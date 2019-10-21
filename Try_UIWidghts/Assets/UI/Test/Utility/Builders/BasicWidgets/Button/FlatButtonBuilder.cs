using Unity.UIWidgets.material;

namespace UI.Test.Utility
{
    public partial class Q
    {

        public static FlatButtonBuilder FlatButton=>new FlatButtonBuilder();        


    }
    public class FlatButtonBuilder:ButtonBuilder<FlatButtonBuilder>
    {
        public FlatButton End()
        {
            return new FlatButton(
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