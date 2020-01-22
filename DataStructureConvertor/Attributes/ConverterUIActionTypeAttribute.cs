using System;

namespace DataStructureConvertor.Attributes
{
    public class ConverterUIActionTypeAttribute : Attribute
    {
        public ConverterUIActionTypeAttribute(Type uiGetterType)
        {
            this.UiGetterType = uiGetterType;
        }

        public Type UiGetterType { get; }
    }
}
