using Unity.UIWidgets.material;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public partial class Q
    {
        public static InputDecorationBuilder InputDecoration=>new InputDecorationBuilder();
    }
    
    public class InputDecorationBuilder
    {
        private string lableText;
        private string hIntText;
        private IconData iconData;

        public InputDecorationBuilder LabelText(string label)
        {
            this.lableText = label;
            return this;
        }

        public InputDecorationBuilder HIntText(string hIntText)
        {
            this.hIntText = hIntText;
            return this;
        }

        public InputDecorationBuilder IconData(IconData iconData)
        {
            this.iconData = iconData;
            return this;
        }

        public InputDecoration End()
        {
            return new InputDecoration(
                labelText:lableText,
                hintText:hIntText,
                icon:new Icon(iconData));
        }
        
    }
}