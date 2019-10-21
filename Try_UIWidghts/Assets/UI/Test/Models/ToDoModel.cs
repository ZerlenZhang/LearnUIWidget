namespace UI.Test.Models
{
    /// <summary>
    /// 待办事项数据模型
    /// </summary>
    public class ToDoModel
    {
        public ToDoModel()
        {
        }

        public ToDoModel(string content,bool finished=false)
        {
            this.content = content;
            this.finished = finished;
        }

        public bool finished = false;
        public string content = "";
    }
}