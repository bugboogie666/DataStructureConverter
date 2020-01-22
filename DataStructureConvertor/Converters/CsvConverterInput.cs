using DataStructureConvertor.Attributes;
using DataStructureConvertor.Core;
using DataStructureConvertor.UIGetters;
using System;
using System.IO;

namespace DataStructureConvertor.Converters
{
    [ConverterUIActionType(typeof(OpenFileNameGetter))]
    [ConverterCaption("CSV")]
    internal class CsvConverterInput : IConverterInput
    {        
       
        private static string _fileName;
        private StreamReader sr;

        public CsvConverterInput(string fileName)
        {
            _fileName = fileName;
            sr = new StreamReader(_fileName);
        }

        public void Dispose()
        {
            sr.Dispose();
        }

        public bool Read()
        {                        
            if(!sr.EndOfStream)
            {
                return true;                    
            }
            return false;    

            //throw new NotImplementedException("TODO");
        }

        Record IConverterInput.Parse()
        {
            
            var row = sr.ReadLine().Split(';');

            Record record = new Record(Convert.ToInt32(row[0]), row[1]);

            return record;
            //throw new NotImplementedException("TODO");
        }
    }
}
