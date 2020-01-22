using DataStructureConvertor.Attributes;
using DataStructureConvertor.Core;
using DataStructureConvertor.UIGetters;
using System.Xml;

namespace DataStructureConvertor.Converters
{
    [ConverterUIActionType(typeof(SaveFileNameGetter))]
    [ConverterCaption("XML")]
    internal class XmlConverterOutput : IConvertorOutput
    {
        private static string _fileName;

        private XmlWriter sw;

        public XmlConverterOutput(string fileName)
        {
            _fileName = fileName;
            this.sw = XmlWriter.Create(fileName);
            this.sw.WriteStartElement("Records");
        }

        public void Dispose()
        {
            this.sw.WriteEndDocument();
            sw.Dispose();
        }

        void IConvertorOutput.Write(Record record)
        {
            this.sw.WriteStartElement("Record");

            this.sw.WriteAttributeString(nameof(Record.ID), record.ID.ToString());
            this.sw.WriteAttributeString(nameof(Record.Name), record.Name.ToString());

            this.sw.WriteEndElement();
        }
    }
}
