using System.Collections.Generic;
using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using Image = Unity.UIWidgets.widgets.Image;

namespace UI.Test.App
{
    public class ImageExample:UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
//            return new Column(children:new List<Widget>
//            {
//                
//                Image.asset("shit"),
//                
////                Image.asset("shit"),
//                Image.network("https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571331960133&di=d60b5ef72a63f470c82b7ce0c0bf1bd0&imgtype=0&src=http%3A%2F%2Fimg.byecity.com.cn%2Ffs%2Fbrs%2Fimgs%2Fjiaotongfuwu%2F2017-08%2Ftupian1.jpg"),
//                Image.asset("shit")
//            });
            return Q.Row
                .Child(Image.asset("shit",
//                    color:Colors.blue,
                    colorBlendMode:BlendMode.difference))
                .Child(Image.network("https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1571331960133&di=d60b5ef72a63f470c82b7ce0c0bf1bd0&imgtype=0&src=http%3A%2F%2Fimg.byecity.com.cn%2Ffs%2Fbrs%2Fimgs%2Fjiaotongfuwu%2F2017-08%2Ftupian1.jpg"))
                .Child(new Image(
                    image:new AssetImage("shit"),
                    repeat:ImageRepeat.repeat,
                    width:100, 
                    height:300))
                .End();
        }
    }
}