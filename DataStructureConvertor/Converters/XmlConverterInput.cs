using DataStructureConvertor.Attributes;
using DataStructureConvertor.Core;
using DataStructureConvertor.UIGetters;
using System;
using System.Xml;
using System.Xml.Linq;

namespace DataStructureConvertor.Converters
{
    [ConverterUIActionType(typeof(OpenFileNameGetter))]
    [ConverterCaption("XML")]
    internal class XmlConverterInput : IConverterInput
    {
        private string _fileName;
        private XmlReader reader;

        public XmlConverterInput(string fileName)
        {
            _fileName = fileName;
            reader = XmlReader.Create(_fileName);
        }

        public void Dispose()
        {
            reader.Dispose();            
        }

        public bool Read()
        {
            if(reader.Read())//TODO if
            {
                return true;
            }
            return false;
        }

        Record IConverterInput.Parse()//TODO pouzij XPath
        {
            if (reader.NodeType == XmlNodeType.Element && reader.LocalName == "Record")
            {
                if (reader.HasAttributes)
                {

                    var id = reader.GetAttribute("ID");
                    var name = reader.GetAttribute("Name");

                    return new Record(Convert.ToInt32(id), name.ToString());
                }
                else
                {
                    //jak bych vratil hodnoty kdyby XML nebylo usporadane dle atributu ale id a name v uzlech?


                    reader.ReadToDescendant("ID");
                                       
                    XElement elId = XNode.ReadFrom(reader) as XElement;
                    var id = elId.Value;

                    reader.ReadToNextSibling("Name");
                    XElement elName = XNode.ReadFrom(reader) as XElement;
                    var name = elName.Value;

                    return new Record(Convert.ToInt32(id), name);                                        
                }                          
            }           
            return null;
        }
    }
}
