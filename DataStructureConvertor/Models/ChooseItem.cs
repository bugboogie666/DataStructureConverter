using System;

namespace DataStructureConvertor.Models
{
    internal class ChooseItem
    {
        private readonly string text;

        public ChooseItem(Type converterType, string text)
        {
            this.text = text;
            this.ConverterType = converterType;
        }

        public Type ConverterType { get; }

        public override string ToString()
        {
            return this.text;
        }
    }
}
