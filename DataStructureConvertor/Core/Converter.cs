using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureConvertor.Core
{
    internal static class Converter
    {
        public static void Convert(IConverterInput input, IConvertorOutput output)
        {
            using (input)
            {
                using (output)
                {
                    while (input.Read())
                    {
                        output.Write(input.Parse());
                    }
                }
            }
        }
    }
}
