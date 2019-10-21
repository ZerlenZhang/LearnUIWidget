using System;
using System.Collections.Generic;
using UI.Test.Utility;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.Widgets
{
    /// <summary>
    /// 一个组件——左边输入框，右边加号，onAdd时加号的回调
    /// </summary>
    public class ToDoInputView : StatelessWidget
    {
        public ToDoInputView(Action<string> onAdd, Key key = null) : base(key)
        {
            this.onAdd += onAdd;
        }

        private string inputString;

        private Action<string> onAdd;

        private void OnSubmit(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
                onAdd?.Invoke(text);
        }

        public override Widget build(BuildContext context)
        {
            return Q.Container
                .Alignment(Alignment.center)
                .Child(
                    new Row(
                        children: new List<Widget>()
                        {
                            Q.Container
                                .Width(780)
                                .BoxDecorationColor(Color.black)
                                .Margin(EdgeInsets.only(left: 80))
                                .Child(
                                    Q.EditableText
                                        .Size(70)
                                        .OnChanged((value) => inputString = value)
                                        .OnSubmit((value) => OnSubmit(value))
                                        .End())
                                .End(),
                            Q.Container
                                .Child(
                                    new Icon(Icons.add_alarm,size:90)
                                        .OnTap(() => OnSubmit(inputString)))
                                .Margin(EdgeInsets.only(right: 70))
                                .End()
                        },
                        mainAxisAlignment: MainAxisAlignment.spaceBetween))
                .Margin(EdgeInsets.only(bottom:20))
                .End();
        }
    }
}