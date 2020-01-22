using System;

namespace DataStructureConvertor.Core
{
    //potomci teto tridy implementuji nacteni a parsovani jednotlivych prvku - potomci IRecord
    interface IConverterInput : IDisposable
    {
        //true - nacetl jsem dalsi prvek, false - dalsi prvek jiz nelze nacist
        bool Read();

        //prevod (parsing) nacteneho zaznamu do struktury
        Record Parse();
    }
}
