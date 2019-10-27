using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;

namespace UI.Test.App
{
    public class TextFieldExample : UIWidgetsPanel
    {        
        protected override void OnEnable()
        {
            base.OnEnable();
            FontManager.instance.addFont(Resources.Load<Font>("MaterialIcons-Regular"), "Material Icons");
        }
        protected override Widget createWidget()
        {
            return new MaterialApp(
                home: new Scaffold(
                    body:new TextFieldWidget()
                ));
        }
    }

    class TextFieldWidget : StatefulWidget
    {
        public override State createState()
        {
            return new TextFieldWidgetState();
        }
    }

    internal class TextFieldWidgetState : State<TextFieldWidget>
    {
        public override Widget build(BuildContext context)
        {
            var focusNode1=new FocusNode();
            var focusNode2=new FocusNode();
            FocusScopeNode focusNodeScope=FocusScope.of(context);
            
            focusNode1.addListener(()=>Debug.Log("状态： "+focusNode1.hasFocus));
            
            return Q.Colum
                .Child(Q.TextField
                    .AutoFocus()
                    .IconData(Icons.person)
                    .LabelText("用户名")
                    .HIntText("用户名或邮箱")
                    .DefaultData("张泽龙")
                    .FocusNode(focusNode1)
                    .Selection(0, 2)
                    .OnChanged(value => Debug.Log("onChanged: " + value))
                    .End())
                .Child(Q.TextField
                    .IconData(Icons.lock_icon)
                    .LabelText("密码")
                    .HIntText("您的密码")
                    .FocusNode(focusNode2)
                    .ObscureText()
                    .OnSubmit(value => Debug.Log("onSubmit: " + value))
                    .End())
                .Child(Q.RaisButton
                    .Child(Q.Text.Data("选中密码").End())
                    .OnPressed(() =>
                    {
                        focusNodeScope.requestFocus(focusNode2);
                    })
                    .End())
                .Child(Q.RaisButton
                    .Child(Q.Text.Data("解除焦点").End())
                    .OnPressed(() =>
                    {
                        focusNode1.unfocus();
                        focusNode2.unfocus();
                    })
                    .End())
                .End();
        }
    }
}