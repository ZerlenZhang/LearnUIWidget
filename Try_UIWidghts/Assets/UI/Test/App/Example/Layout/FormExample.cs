using Unity.UIWidgets.engine;
using Unity.UIWidgets.widgets;

namespace UI.Test.App
{
    public class FormExample:UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return new FormWidget();
        }
    }

    public class FormWidget : StatefulWidget
    {
        public override State createState()
        {
            return new FormWidgetState();
        }
    }

    public class  FormWidgetState : State<FormWidget>
    {
        private TextEditingController mUnnameChontroller=new TextEditingController();
        private TextEditingController mPwdController=new TextEditingController();
        
        
//        private GlobalKey<FormState> mFormKey = new GlobalKey<FormState>();




        public override Widget build(BuildContext context)
        {
//            textformf
            return new Form();
        }
    }
}