using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructureConvertor.Attributes;
using DataStructureConvertor.Core;
using DataStructureConvertor.UIGetters;
using System.IO;
using System.Data.SqlClient;

namespace DataStructureConvertor.Converters
{
    [ConverterUIActionType(typeof(OpenDBConnectionGetter))]
    [ConverterCaption("Database")]
    internal class DBConverterInput : IConverterInput
    {
        //private string _connectionString;//možná někdy použiju
        private SqlConnection connection;
        private SqlCommand cmd;
        private SqlDataReader reader;

        public DBConverterInput(string connectionString)
        {
            //_connectionString = connectionString; // možná někdy využiji
            connection = new SqlConnection(connectionString);
            connection.Open();            
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT ID, Name FROM Prisoners";
            cmd.Connection = connection;

            reader = cmd.ExecuteReader();
        }

        public void Dispose()
        {
            cmd.Dispose();
            reader.Dispose();
            connection.Dispose();            
        }

        public bool Read()
        {                       
            if (reader.Read())//TODO if
            {
                return true;
            }
            return false;
        }
        
        public Record Parse()
        {

            var id = reader.GetValue(0);//reader.GetFieldValue<int>(0);
            var name = reader.GetValue(1);

            var record = new Record(Convert.ToInt32(id), name.ToString());

            return record;           
        }
    }
}
