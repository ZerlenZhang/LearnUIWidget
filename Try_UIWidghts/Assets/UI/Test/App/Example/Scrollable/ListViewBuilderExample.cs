using System.Collections.Generic;
using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.widgets;

namespace UI.Test.App.Scrollable
{
    /// <summary>
    /// 在列表项数量非常多的时候，使用ListView.Build更为优化
    /// </summary>
    public class ListViewBuilderExample:UIWidgetsPanel
    {
        private List<int> data = new List<int>();
        protected override Widget createWidget()
        {
            for (var i = 0; i < 100; i++)
                data.Add(i);
            
            var divider=new Divider(color:Colors.black54);
//            return ListView.builder(
//                itemCount:data.Count,
//                itemBuilder:(context,index)=>new ListTile(
//                    title:Q.Text.Data(data[index].ToString()).End()))
//                .GetScaffold()
//                .GetMaterialApp();
            return ListView.seperated(
                    itemCount:data.Count,
                    itemBuilder:(context,index)=>new ListTile(
                        title:Q.Text.Data(data[index].ToString()).End()),
                    separatorBuilder:(context, index) =>divider)
                .GetScaffold()
                .GetMaterialApp();
        }
    }
}