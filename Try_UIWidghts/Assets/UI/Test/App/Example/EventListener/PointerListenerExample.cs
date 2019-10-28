using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.gestures;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace UI.Test.App.EventListener
{
    public class PointerListenerExample : UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return new PointerListenerRoute().GetScaffold().GetMaterialApp();
        }
    }

    public class PointerListenerRoute : StatefulWidget
    {
        public override State createState()
        {
            return new PointerListenerState();
        }
    }

    public class PointerListenerState : State<PointerListenerRoute>
    {
        private PointerEvent _event;

        public override Widget build(BuildContext context)
        {
            return new Listener(
                child: Q.Container
                    .Color(Colors.blue)
                    .Alignment(Alignment.center)
                    .Child(Q.Text
                        .Data(_event?.ToString() ?? "??")
                        .Size(50)
                        .Color(Color.white)
                        .End())
                    .End()
                    .GetSizeBox(200,200),
                onPointerDown:(evt =>setState(()=>_event=evt)),
                onPointerEnter:(evt =>setState(()=>_event=evt)),
                onPointerExit:(evt =>setState(()=>_event=evt)),
//                onPointerCancel:(evt =>setState(()=>_event=evt)),
//                onPointerHover:(evt =>setState(()=>_event=evt)),
                onPointerMove:(evt =>setState(()=>_event=evt)),
//                onPointerScroll:(evt =>setState(()=>_event=evt)),
//                onPointerSignal:(evt =>setState(()=>_event=evt)),
                onPointerUp:(evt =>setState(()=>_event=evt)));
        }
    }
}