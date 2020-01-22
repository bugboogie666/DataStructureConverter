using System;

namespace DataStructureConvertor.Core
{
    //potomci teto tridy implementuji ukladani prvku - potomci IRecord
    public interface IConvertorOutput : IDisposable
    {
        //zapis prvku
        void Write(Record record);
    }
}
