using System;

namespace DataStructureConvertor.Attributes
{
    public class ConverterCaptionAttribute : Attribute
    {
        public ConverterCaptionAttribute(string caption)
        {
            this.Caption = caption;
        }

        public string Caption;
    }
}
