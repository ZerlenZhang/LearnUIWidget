using Unity.UIWidgets.foundation;
using Unity.UIWidgets.material;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{

    public partial class Q
    {
        public static TextFieldBuilder TextField=>new TextFieldBuilder();
    }
    public class TextFieldBuilder:EditableBuilder<TextFieldBuilder>
    {
        private InputDecorationBuilder InputDecorationBuilder=new InputDecorationBuilder();

        public TextFieldBuilder LabelText(string label)
        {
            InputDecorationBuilder.LabelText(label);
            return this;
        }
        
        public TextFieldBuilder HIntText(string hIntText)
        {
            InputDecorationBuilder.HIntText ( hIntText);
            return this;
        }

        public TextFieldBuilder IconData(IconData iconData)
        {
            InputDecorationBuilder.IconData ( iconData);
            return this;
        }
        
        public TextField End()
        {
            return new TextField(
                controller:mInputController,
                focusNode:mFocusNode,
                autofocus:autoFocus,
                obscureText:obscureText,
                onChanged:mOnValueChanged,
                onSubmitted:mOnSubmit,
                decoration:InputDecorationBuilder.End());
        }
    }
}