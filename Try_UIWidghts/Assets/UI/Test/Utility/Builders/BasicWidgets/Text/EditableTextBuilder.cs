using System;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.Utility
{
    public partial class Q
    {
        public static EditableTextBuilder EditableText => new EditableTextBuilder();
    }

    public class EditableTextBuilder:EditableBuilder<EditableTextBuilder>
    {

        public MediaQuery End()
        {
            return new MediaQuery(
                data: new MediaQueryData(),
                child: new EditableText(
                    autofocus:autoFocus,
                    obscureText:obscureText,
                    controller: mInputController??new TextEditingController() ,
                    focusNode: mFocusNode,
                    style: Math.Abs(mFontSize) < 0.01f ? mStyle : new TextStyle(fontSize: mFontSize),
                    cursorColor: mCursorColor,
                    backgroundCursorColor:backGroundColor,
                    onChanged: mOnValueChanged,
                    onSubmitted: mOnSubmit,
                    maxLines:maxLine
                    ));
        }
    }
}