using UI.Test.Utility;
using Unity.UIWidgets.material;
using Unity.UIWidgets.widgets;

namespace UI.Test.Widgets.ExampleDrawers
{
    public class MyDrawer:StatelessWidget
    {
        public override Widget build(BuildContext context)
        {
            return new Drawer(
                child:Q.Colum
                    .Children(
                        Q.IconBtn.IconData(Icons.save).End(),
                        Q.IconBtn.IconData(Icons.laptop).End()
                        )
                    .End());
        }
    }
}