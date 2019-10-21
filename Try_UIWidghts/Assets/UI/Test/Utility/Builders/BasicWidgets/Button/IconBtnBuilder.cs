using System;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public partial class Q
    {

        public static IconBtnBuilder IconBtn => new IconBtnBuilder();
    }

    public class IconBtnBuilder:ButtonBuilder<IconBtnBuilder>
    {

        [Obsolete]
        public override IconBtnBuilder Child(Widget child)
        {
            throw new NotImplementedException("IconBtnBuilder 不允许使用Child");
        }
        
        private float size = 24.0f;
        private Alignment alignment;
        private IconData iconData;
        private Icon icon;

        public IconButton End()
        {

            if (iconData != null)
            {
                return new IconButton(
                    null,
                    size,
                    padding,
                    alignment,
                    new Icon(iconData),
                    onPressed: this.onPressed,
                    color:color,
                    splashColor:splashColor,
                    highlightColor:highlightColor);
            }
            return new IconButton(
                null,
                size,
                padding,
                alignment,
                icon,
                onPressed: this.onPressed,
                color:color,
                splashColor:splashColor,
                highlightColor:highlightColor);
        }
        
        public IconBtnBuilder Icon(Icon icon)
        {
            this.icon = icon;
            return this;
        }

        public IconBtnBuilder IconData(IconData iconData)
        {
            this.iconData = iconData;
            return this;
        }

        public IconBtnBuilder Alignment(Alignment alignment)
        {
            this.alignment = alignment;
            return this;
        }

        public IconBtnBuilder Size(float size)
        {
            this.size = size;
            return this;
        }
    }
}