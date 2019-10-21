using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using UI.Test.Models;
using UI.Test.Utility;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.Widgets.Screens
{
    public class DetailScreen : StatefulWidget
    {
        private ToDoModel toDoModel;

        public DetailScreen(ToDoModel doModel, Key key = null) : base(key)
        {
            toDoModel = doModel;
        }

        public override State createState()
        {
            return new DetailScreenState(toDoModel);
        }
    }

    
    public class DetailScreenState : State<DetailScreen>
    {
        private ToDoModel toDoModel;
        private string mInputContent;

        public override void initState()
        {
            base.initState();
            mInputContent = toDoModel.content;
        }

        public DetailScreenState(ToDoModel doModel) 
        {
            toDoModel = doModel;
        }

        private List<Widget> GetActions(BuildContext buildContext)
        {
                if (mInputContent == toDoModel.content)
                {
                    return new List<Widget>();
                }

                return new List<Widget>
                {
                    Q.IconBtn
                        .IconData(Icons.save)
                        .Size(70)
                        //Navigator两个方法，PopNamed函数使用路由名转化，但对传参数不友好
                        //                   push 函数可以带参数
                        //                  Pop函数可以传一个参数回去，这样来时的界面就可以用Result接收到
                        .OnPressed(() =>
                        {
                            Navigator.pop(buildContext, mInputContent);
                        })
                        .End()
                };
        }
        
        
        public override Widget build(BuildContext buildContext)
        {
            return new Scaffold(
                body: Q.Container
                    .BoxDecorationColor(Color.black)
                    .Margin(EdgeInsets.all(100))
                    .Child(Q.EditableText
                        .DefaultData(mInputContent)
                        .Size(100)
                        .OnChanged((str) =>
                        {
                            this.setState(
                                ()=> mInputContent=str);   
                        })
                        .MaxLine(4)
                        .End())
                    .End(),
                appBar: new AppBar(
                    actions:GetActions(buildContext))
            );
        }
    }
}