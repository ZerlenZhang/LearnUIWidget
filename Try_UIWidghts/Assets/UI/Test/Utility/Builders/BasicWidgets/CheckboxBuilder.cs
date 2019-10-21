using Unity.UIWidgets.foundation;
using Unity.UIWidgets.material;
using Unity.UIWidgets.ui;

namespace UI.Test.Utility
{
    public partial class Q
    {
        public static CheckboxBuilder Checkbox=>new CheckboxBuilder();
    
    }
    
    public class CheckboxBuilder
    {
        private bool? value = false;
        private ValueChanged<bool?> OnValueChanged = null;
        private Color activeColor=Colors.red;

        public CheckboxBuilder ActiveColor(Color color)
        {
            this.activeColor = color;
            return this;
        }

        public CheckboxBuilder Value(bool? value)
        {
            this.value = value;
            return this;
        }

        public CheckboxBuilder OnChanged(ValueChanged<bool?> onChanged)
        {
            this.OnValueChanged = onChanged;
            return this;
        }
        
        public Checkbox End()
        {
            return new Checkbox(value:value,onChanged:OnValueChanged,activeColor:activeColor);
        }
    }
}