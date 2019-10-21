using System;
using UI.Test.Models;
using UI.Test.Utility;
using UI.Test.Widgets.Screens;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.widgets;
using UnityEngine;
using Color = Unity.UIWidgets.ui.Color;

namespace UI.Test.Widgets
{
    /// <summary>
    /// 每一项代办的条目
    /// </summary>
    public class ToDoView : StatelessWidget
    {
        private readonly Action m_OnDelete;

        private readonly Action<bool> onCheckChange;

        private readonly Action<string> onEdit;

        private bool State
        {
            get { return data.finished; }
            set
            {
                if (value != data.finished)
                {
                    onCheckChange?.Invoke(value);
                    data.finished = value;
                }
                
                
            }
        }

        private ToDoModel data;

        public ToDoView(ToDoModel data, Action onDelete,Action<bool> onCheckChange,Action<string> onEdit, Key key = null) : base(key)
        {
            this.data = data;
            this.onEdit = onEdit;
            this.m_OnDelete = onDelete;
            this.onCheckChange += onCheckChange;
        }


        public override Widget build(BuildContext context)
        {
            return
                new ListTile(
                    leading:

                    #region 对勾

                    Q.IconBtn
                        .Color(State ? new Color(0xff00bcd4) : Color.black)
                        .IconData(State ? Icons.check_box : Icons.check_box_outline_blank)
                        .Size(70)
                        .OnPressed(() => State = !State)
                        .End(),                    

            #endregion

                    trailing:

                    #region 删除

                    Q.IconBtn
                        .Size(70)
                        .IconData(Icons.delete)
                        .OnPressed(() => m_OnDelete?.Invoke())
                        .End(),                    

            #endregion

                    subtitle:
                    Q.Text
                        .Data("subtile")
                        .Size(40)
                        .End(),
                    title:
                    Q.Container
                        .Alignment(Alignment.centerLeft)
                        .Child(Q.Text
                            .Data(data.content)
                            .Size(65)
                            .End())
                        .End(),
                    onTap: () => 
                    {
                        var pushResult =Navigator.push(context, 
                         new MaterialPageRoute(builder:content=>new DetailScreen(data)));
                        pushResult.Then(result =>
                        {
                            var newContent = result as string;
                            Debug.Log("详情界面返回结果："+ result);
                            if (null!=newContent)
                            {
                                onEdit?.Invoke(newContent);
                            }
                            
                        });

                    });
            ;
        }
    }
}