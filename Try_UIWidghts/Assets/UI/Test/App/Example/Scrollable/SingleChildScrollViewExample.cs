using System.Linq;
using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.widgets;

namespace UI.Test.App.Scrollable
{
    public class SingleChildScrollViewExample:UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            var str = "ABCDEFGHIGKHLMNOPQRSTUVWXYZ";
            return new Scrollbar(child:new SingleChildScrollView(
                padding:EdgeInsets.all(16),
                child:new Center(child:Q.Colum
                    .Children(
                        str.Select(c=>Q.Text.Data(new string(c,1)).Size(50).End() as Widget).ToList())
                    .End())));
        }
    }
}