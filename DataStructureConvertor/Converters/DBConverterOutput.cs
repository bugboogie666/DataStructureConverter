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
using System.Windows.Forms;
using System.Data;

namespace DataStructureConvertor.Converters
{
    [ConverterUIActionType(typeof(SaveDBConnectionGetter))]
    [ConverterCaption("Database")]
    internal class DBConverterOutput : IConvertorOutput
    {
        private string _connectionString;
        private SqlConnection connection;
        private SqlCommand cmd;
        
        public DBConverterOutput(string connectionString)
        {
            _connectionString = connectionString;
            connection = new SqlConnection(_connectionString);           
            
        }

        public void Dispose()
        {
            
            cmd.Dispose();
            
            //throw new NotImplementedException();
        }

        public void Write(Record record)
        {
            cmd = new SqlCommand("INSERT into Prisoners (ID,Name) VALUES (@ID,@Name)",connection);//TODO predelej INIT

            //cmd.Connection = connection;

            //cmd.CommandText = "INSERT into Prisoners (ID,Name) VALUES (@ID,@Name)";

            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = record.ID;//cmd.Parameters["@ID"].Value = record.ID;

            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = record.Name;


            try//odstran try catch - udelame to v konvertoru = odstran ve vsech tridach
            {
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch(SqlException)
            {
                MessageBox.Show("Cannot connect to SQLSERVER or query couldn't be executed.");
            }
            finally
            {
                connection.Close();
            }




        }
    }
}
