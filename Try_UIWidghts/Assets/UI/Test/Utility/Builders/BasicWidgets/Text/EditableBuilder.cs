using Unity.UIWidgets.foundation;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.service;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public class EditableBuilder<T> 
    where T:EditableBuilder<T>
    {
        protected TextEditingController mInputController = new TextEditingController(text: "");
        protected FocusNode mFocusNode = new FocusNode();
        
        protected float mFontSize=20;
        protected ValueChanged<string> mOnValueChanged = null;
        protected ValueChanged<string> mOnSubmit = null;
        protected int maxLine = 1;
        protected TextStyle mStyle = new TextStyle();
        protected Color mCursorColor = Color.black;
        protected Color backGroundColor=Color.white;
        
        protected bool autoFocus = false;
        protected bool obscureText = false;

        protected TextSelection TextSelection;

        public T Selection(int start, int end)
        {
            TextSelection = new TextSelection(start, end);
            mInputController.selection = TextSelection;
            return this as T;
        }


        public T Controller(TextEditingController controller)
        {
            this.mInputController = controller;
            return this as T;
        }
        
        
        /// <summary>
        /// 是否是密码
        /// </summary>
        /// <returns></returns>
        public T ObscureText()
        {
            obscureText = true;
            return this as T;
        }
        
        public T AutoFocus()
        {
            this.autoFocus = true;
            return this as T;
        }
        
        public T CursorColor(Color color)
        {
            mCursorColor = color;
            return this as T;
        }

        public T BackGroundColor(Color color)
        {
            backGroundColor = color;
            return this as T;
        }
        

        public T Size(float size)
        {
            mFontSize = size;
            return this as T;
        }
        public T FocusNode(FocusNode focusNode)
        {
            mFocusNode = focusNode;
            return this as T;
        }
        public T MaxLine(int maxLine)
        {
            this.maxLine = maxLine;
            return this as T;
        }
        public T DefaultData(string str)
        {
            mInputController = new TextEditingController(str);
            return this as T;
        }
        public T OnChanged(ValueChanged<string> _onValueChanged)
        {
            mOnValueChanged = _onValueChanged;
            return this as T;
        }
        public T OnSubmit(ValueChanged<string> _onSubmit)
        {
            mOnSubmit = _onSubmit;
            return this as T;
        }
    }
}