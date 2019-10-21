using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UI.Test.Models
{
    public static class DataPersistent
    {
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <returns></returns>
        public static List<ToDoModel> Load()
        {
            var toDoListContent = PlayerPrefs.GetString("ToDoList_Key", string.Empty);
            var splitdatas = toDoListContent.Split(new[] {"@@@@"}, StringSplitOptions.None);
            return splitdatas.Where(data => !string.IsNullOrEmpty(data)).Select(
                todoData =>
                {
                    var todo = new ToDoModel();
                    var todoSpliteDatas = todoData.Split(new[] {"::::"}, StringSplitOptions.None);
                    todo.content = todoSpliteDatas[0];
                    if (todoSpliteDatas.Length > 1)
                    {
                        todo.finished = bool.Parse(todoSpliteDatas[1]);
                    }

                    return todo;
                }).ToList();
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="infos"></param>
        public static void Save(List<ToDoModel> infos)
        {
            var sb = new StringBuilder();
            infos.ForEach(
                data =>
                {
                    sb.Append(data.content + "::::" + data.finished);
                    sb.Append("@@@@");
                });
            PlayerPrefs.SetString("ToDoList_Key", sb.ToString());
        }
    }
    
    
}