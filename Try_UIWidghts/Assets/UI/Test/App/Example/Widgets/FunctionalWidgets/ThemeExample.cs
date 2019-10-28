using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;
using Color = Unity.UIWidgets.ui.Color;

namespace UI.Test.App.Widgets
{
    public class ThemeExample : UIWidgetsPanel
    {
        protected override void OnEnable()
        {
            base.OnEnable();
            //使用ICons必须导入这样的文件
            FontManager.instance.addFont(Resources.Load<Font>("MaterialIcons-Regular"), "Material Icons");
        }

        protected override Widget createWidget()
        {
            return new ThemeRoute().GetMaterialApp();
        }
    }

    public class ThemeRoute : StatefulWidget
    {
        public override State createState()
        {
            return new ThemeState();
        }
    }

    public class ThemeState : State<ThemeRoute>
    {
        private MaterialColor mThemeColor = Colors.teal;

        public override Widget build(BuildContext context)
        {
            var themedata = Theme.of(context);
            return new Theme(
                data: new ThemeData(
                    primarySwatch: mThemeColor,
                    iconTheme: new IconThemeData(mThemeColor)),
                child: new Scaffold(
                    appBar: new AppBar(title: Q.Text.Data("主题测试").Size(80).End()),
                    body: Q.Colum
                        .MainAxisAlignment(MainAxisAlignment.center)
                        .Children(
                            Q.Row
                                .MainAxisAlignment(MainAxisAlignment.center)
                                .Children(
                                    new Icon(Icons.favorite, size: 100),
                                    new Icon(Icons.airport_shuttle, size: 100),
                                    Q.Text.Data("颜色跟随主题").End())
                                .End(),
                            new Theme(
                                data: themedata.copyWith(iconTheme: themedata.iconTheme.copyWith(Colors.black)),
                                child: Q.Row
                                    .MainAxisAlignment(MainAxisAlignment.center)
                                    .Children(
                                        new Icon(Icons.favorite, size: 100),
                                        new Icon(Icons.airport_shuttle, size: 100),
                                        Q.Text.Data("颜色固定黑色").End())
                                    .End()
                            ))
                        .End(),
                    floatingActionButton: new FloatingActionButton(
                        child: new Icon(Icons.palette, size: 80),
                        onPressed: () =>
                        {
                            setState(() => { mThemeColor = mThemeColor == Colors.teal ? Colors.blue : Colors.teal; });
                        })));
        }
    }
}