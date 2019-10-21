using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;

namespace UI.Test.Utility
{
    public partial class Q
    {
        public static TextStyleBuilder TextStyle => new TextStyleBuilder();

    }

    /// <summary>
    /// 字体样式
    /// </summary>
    public class TextStyleBuilder
    {
        public float? fontSize;
        public FontWeight fontWeight;
        public Color fontColor;
        public TextDecorationStyle? textDecorationStyle;
        public TextDecoration textDecoration;
        public Color backgroundColor;
        public Color decorationColor;
        public float? height;
        public string family;

        public bool inherit = true;
        #region TextStyleBuilder

        public TextStyleBuilder Family(string family)
        {
            this.family = family;
            return this;
        }

        public TextStyleBuilder UnHerit()
        {
            this.inherit = false;
            return this;
        }

        public TextStyleBuilder DecorationColor(Color color)
        {
            this.decorationColor = color;
            return this;
        }
            
        public TextStyleBuilder BackGroundColor(Color color)
        {
            this.backgroundColor = color;
            return this;
        }
            
        public TextStyleBuilder Height(float? height)
        {
            this.height = height;
            return this;
        }

        public TextStyleBuilder Decoration(TextDecoration textDecoration)
        {
            this.textDecoration = textDecoration;
            return this;
        }
            
        public TextStyleBuilder DecorationStyle(TextDecorationStyle textDecorationStyle)
        {
            this.textDecorationStyle = textDecorationStyle;
            return this;
        }
            
        public TextStyleBuilder Color(Color fontColor)
        {
            this.fontColor = fontColor;
            return this;
        }

        public TextStyleBuilder FontWeight(FontWeight fontWeight)
        {
            this.fontWeight = fontWeight;
            return this;
        }

        public TextStyleBuilder Size(float fontSize)
        {
            this.fontSize = fontSize;
            return this;
        }          

        #endregion
        
        public TextStyle End()
        {
            return new TextStyle(
                fontFamily:family,
                inherit:inherit,
                fontSize: fontSize,
                fontWeight: fontWeight,
                color: fontColor,
                decorationStyle: textDecorationStyle,
                decoration: textDecoration,
                decorationColor: decorationColor,
                background: backgroundColor != null
                    ? new Paint
                    {
                        color = backgroundColor
                    }
                    : null,
                height: height);
        }
    }
}