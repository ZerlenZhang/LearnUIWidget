using Unity.UIWidgets.painting;
using Unity.UIWidgets.service;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public class ButtonBuilder<T>where T:ButtonBuilder<T>
    {
        protected Widget child { get; set; }
        protected VoidCallback onPressed = null;
        
        
        
        protected Color textColor;

        protected Color disabledTextColor;

        protected Color color;

        protected Color disabledColor;

        protected Color splashColor;

        protected Color highlightColor;

        protected EdgeInsets padding;

        protected ShapeBorder mShape;
        
        protected Brightness? mColorBrightness;

        public T TextColor(Color color)
        {
            this.textColor = color;
            return this as T;
        }

        public T DisabledTextColor(Color color)
        {
            this.disabledTextColor = color;
            return this as T;
        }

        public T Color(Color color)
        {
            this.color = color;
            return this as T;
        }

        public T DisabledColor(Color color)
        {
            this.disabledColor = color;
            return this as T;
        }

        public T SplashColor(Color color)
        {
            this.splashColor = color;
            return this as T;
        }

        public T HighlightColor(Color color)
        {
            this.highlightColor = color;
            return this as T;
        }

        public T Padding(EdgeInsets padding)
        {
            this.padding = padding;
            return this as T;
        }

        public T Shape(ShapeBorder shapeBorder)
        {
            this.mShape = shapeBorder;
            return this as T;
        }
        public T ColorBrightness(Brightness? brightness)
        {
            this.mColorBrightness = brightness;
            return this as T;
        }
        public virtual T Child(Widget child)
        {
            this.child = child;
            return this as T;
        }
        public T OnPressed(VoidCallback onPressed)
        {
            this.onPressed += onPressed;
            return this as T;
        }
    }
}