using System.Collections.Generic;
using Unity.UIWidgets.gestures;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;

namespace UI.Test.Utility
{

    public partial class Q
    {
        public static TextSpanBuilder TextSpan => new TextSpanBuilder();
    }

    /// <summary>
    /// 用于富文本的处理
    /// </summary>
    public class TextSpanBuilder
    {
        
        #region TextStyleBuilder

        private TextStyleBuilder tsbuilder=new TextStyleBuilder();       
        
        public TextSpanBuilder Family(string family)
        {
            tsbuilder.family = family;
            return this;
        }
        
        public TextSpanBuilder UnHerit()
        {
            tsbuilder.inherit = false;
            return this;
        }
        
        public TextSpanBuilder DecorationColor(Color color)
        {
            tsbuilder.decorationColor = color;
            return this;
        }
            
        public TextSpanBuilder BackGroundColor(Color color)
        {
            tsbuilder.backgroundColor = color;
            return this;
        }
            
        public TextSpanBuilder Height(float? height)
        {
            tsbuilder.height = height;
            return this;
        }

        public TextSpanBuilder Decoration(TextDecoration textDecoration)
        {
            tsbuilder.textDecoration = textDecoration;
            return this;
        }
            
        public TextSpanBuilder DecorationStyle(TextDecorationStyle textDecorationStyle)
        {
            tsbuilder.textDecorationStyle = textDecorationStyle;
            return this;
        }
            
        public TextSpanBuilder Color(Color fontColor)
        {
            tsbuilder.fontColor = fontColor;
            return this;
        }

        public TextSpanBuilder FontWeight(FontWeight fontWeight)
        {
            tsbuilder.fontWeight = fontWeight;
            return this;
        }

        public TextSpanBuilder Size(float? fontSize)
        {
            tsbuilder.fontSize = fontSize;
            return this;
        }          

        #endregion
        private List<TextSpan> m_TextSpans=new List<TextSpan>();
        private string text;
        private GestureRecognizer onTap;

        public TextSpanBuilder Child(TextSpan child)
        {
            m_TextSpans.Add(child);
            return this;
        }

        public TextSpanBuilder Text(string text)
        {
            this.text = text;
            return this;
        }
        

        public TextSpanBuilder OnTap(GestureTapCallback gestureTapCallback)
        {
            onTap=new TapGestureRecognizer
            {
                onTap = gestureTapCallback
            };
            return this;
        }

        public TextSpan End()
        {
            return new TextSpan(
                children:m_TextSpans.Count==0?null:m_TextSpans,
                text:text,
                style:tsbuilder.End(),
                recognizer:onTap);
        }
        
    }
}