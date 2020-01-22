using DataStructureConvertor.Core;
using System;
using System.Xml.Serialization;

namespace DataStructureConvertor
{
    public class Record : IRecord
    {
        public Record()
        {

        }

        public Record(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }



        public int ID { get; }

        public string Name { get; }

        public override string ToString()
        {
            return String.Format("ID: {0}, NAME: {1}", ID, Name);
        }
    }
}
