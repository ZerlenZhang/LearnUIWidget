using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public partial class Q
    {
        public static ContainerBuild Container => new ContainerBuild();
    }

    public class ContainerBuild
    {
        private Widget mChild { get; set; }
        private Alignment mAlignment { get; set; }
        private Color mColor { get; set; }
        private EdgeInsets mMargin = EdgeInsets.zero;
        private EdgeInsets mPadding=EdgeInsets.zero;
        //可控参数
        private float? mWidth = null;
        private float? mHeight = null;

        private Color boxColor;
        private Decoration _decoration;
        private BoxConstraints _boxConstraints;
        private Matrix3 _matrix3;

        public ContainerBuild Transform(Matrix3 matrix3)
        {
            this._matrix3 = matrix3;
            return this;
        }
        
        public ContainerBuild Decoration(Decoration decoration)
        {
            this._decoration = decoration;
            return this;
        }
        public ContainerBuild Constraints(BoxConstraints constraints)
        {
            this._boxConstraints = constraints;
            return this;
        }

        public ContainerBuild BoxDecorationColor(Color color)
        {
            boxColor = color;
            return this;
        }

        
        public static ContainerBuild GetBuilder()
        {
            return new ContainerBuild();
        }

        /// <summary>
        /// 容器内补白
        /// </summary>
        /// <param name="padding"></param>
        /// <returns></returns>
        public ContainerBuild Padding(EdgeInsets padding)
        {
            this.mPadding = padding;
            return this;
        }
        

        public ContainerBuild Child(Widget _child)
        {
            mChild = _child;
            return this;
        }
        public ContainerBuild Color(Color _color)
        {
            mColor = _color;
            return this;
        }
        /// <summary>
        /// 容器外补白
        /// </summary>
        /// <param name="_edgInsets"></param>
        /// <returns></returns>
        public ContainerBuild Margin(EdgeInsets _edgInsets)
        {
            mMargin = _edgInsets;
            return this;
        }
        public ContainerBuild Width(float _width)
        {
            mWidth = _width;
            return this;
        }

        public ContainerBuild Height(float height)
        {
            mHeight = height;
            return this;
        }
        public ContainerBuild Alignment(Alignment _alignment)
        {
            mAlignment = _alignment;
            return this;
        }
        public Container End()
        {
            return new Container(null,mAlignment,mPadding,mColor,boxColor!=null?new BoxDecoration(boxColor): _decoration,null,
                mWidth,mHeight,_boxConstraints,mMargin,_matrix3,mChild);
        }
    }
}