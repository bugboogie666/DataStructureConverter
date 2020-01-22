using DataStructureConvertor.Attributes;
using DataStructureConvertor.Core;
using DataStructureConvertor.UIGetters;
using System;
using CsvHelper;
using System.IO;
using System.Collections.Generic;

namespace DataStructureConvertor.Converters
{
    [ConverterUIActionType(typeof(SaveFileNameGetter))]
    [ConverterCaption("CSV")]
    internal class CsvConverterOutput : IConvertorOutput
    {
        private string _fileName;
        private StreamWriter sw;
        private CsvWriter csvWriter;
        public CsvConverterOutput(string fileName)
        {
            _fileName = fileName;
            sw = new StreamWriter(_fileName);
            csvWriter = new CsvWriter(sw);
            
        }

        public void Dispose()
        {
            sw.Dispose();
            csvWriter.Dispose();
            
        }

        void IConvertorOutput.Write(Record record)
        {
            if (record != null)//TODO vyhodit pryc
            {
    
                csvWriter.WriteField(record.ID.ToString());
                csvWriter.WriteField(record.Name);
                csvWriter.NextRecord();

            }
            
        }
    }
}
