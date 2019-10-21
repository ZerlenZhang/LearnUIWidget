using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public partial class Q
    {

        public static TextBuilder Text => new TextBuilder();
    }

    public class TextBuilder
    {

        #region TextStyleBuilder

        private TextStyleBuilder tsbuilder=new TextStyleBuilder();       
        public TextBuilder UnHerit()
        {
            tsbuilder.inherit = false;
            return this;
        }
        
        public TextBuilder Family(string family)
        {
            tsbuilder.family = family;
            return this;
        }
        
        public TextBuilder DecorationColor(Color color)
        {
            tsbuilder.decorationColor = color;
            return this;
        }
            
        public TextBuilder BackGroundColor(Color color)
        {
            tsbuilder.backgroundColor = color;
            return this;
        }
            
        public TextBuilder Height(float? height)
        {
            tsbuilder.height = height;
            return this;
        }

        public TextBuilder Decoration(TextDecoration textDecoration)
        {
            tsbuilder.textDecoration = textDecoration;
            return this;
        }
            
        public TextBuilder DecorationStyle(TextDecorationStyle textDecorationStyle)
        {
            tsbuilder.textDecorationStyle = textDecorationStyle;
            return this;
        }
            
        public TextBuilder Color(Color fontColor)
        {
            tsbuilder.fontColor = fontColor;
            return this;
        }

        public TextBuilder FontWeight(FontWeight fontWeight)
        {
            tsbuilder.fontWeight = fontWeight;
            return this;
        }

        public TextBuilder Size(float? fontSize)
        {
            tsbuilder.fontSize = fontSize;
            return this;
        }          

        #endregion



        private string mData { get; set; }

        private TextAlign m_Alignment;
        private int? maxLine;

        public TextBuilder MaxLine(int? maxLine)
        {
            this.maxLine = maxLine;
            return this;
        }

        public TextBuilder Alignment(TextAlign alignment)
        {
            m_Alignment = alignment;
            return this;
        }

        private TextOverflow? textOverflow;
        
        public static TextBuilder GetBuilder()
        {
            return new TextBuilder();
        }

        public TextBuilder TextOverflow(TextOverflow textOverflow)
        {
            this.textOverflow = textOverflow;
            return this;
        }
        public TextBuilder Data(string _data)
        {
            mData = _data;
            return this;
        }
        public Text End()
        {
            return new Text(data: mData,
                textAlign:m_Alignment,
                overflow:textOverflow,
                maxLines:maxLine,
                style: tsbuilder.End());
        }
    }
}