using Unity.UIWidgets.foundation;
using Unity.UIWidgets.material;
using Unity.UIWidgets.ui;

namespace UI.Test.Utility
{
    public partial class Q
    {
        public static SwitchBuilder Switch=>new SwitchBuilder();
    }
    
    public class SwitchBuilder
    {
        private bool? value = false;
        private ValueChanged<bool?> OnValueChanged = null;

        private Color activeColor=Colors.green;

        public SwitchBuilder ActiveColor(Color color)
        {
            this.activeColor = color;
            return this;
        }
        public SwitchBuilder Value(bool? value)
        {
            this.value = value;
            return this;
        }

        public SwitchBuilder OnChanged(ValueChanged<bool?> onChanged)
        {
            this.OnValueChanged = onChanged;
            return this;
        }
        
        public Switch End()
        {
            return new Switch(value:value,onChanged:OnValueChanged,activeColor:activeColor);
        }
    }
}