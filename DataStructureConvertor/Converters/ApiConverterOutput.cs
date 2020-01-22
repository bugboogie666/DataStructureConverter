using DataStructureConvertor.Attributes;
using DataStructureConvertor.Core;
using DataStructureConvertor.UIGetters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureConvertor.Converters
{
    [ConverterUIActionType(typeof(SaveWebServiceConnectionGetter))]
    [ConverterCaption("API")]
    internal class ApiConverterOutput : IConvertorOutput
    {
        //private string _url;
        //private WebRequest webRequest;
        //private StreamWriter sw;        

        public ApiConverterOutput(string url)
        {
            //TODO
            throw new NotImplementedException();
            /**
            _url = url;
            webRequest = (HttpWebRequest)WebRequest.Create(_url);
            //webRequest.Proxy = new WebProxy("http://127.0.0.1:8000/", false);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";
            //webRequest.ContentLength = 31;
            sw = new StreamWriter(webRequest.GetRequestStream());
            **/

        }

        public void Dispose()
        {
            //sw.Dispose();
            
        }

        public void Write(Record record)
        {
            //TODO

            throw new NotImplementedException();
            //_url += "/" + record.ID;   
            /**

            Dictionary<string, string> data = new Dictionary<string, string>
            {
                {"name",  record.Name }
            };

            string postData = JsonConvert.SerializeObject(data);

            var bytes = Encoding.ASCII.GetBytes(postData);
            //webRequest.ContentLength = bytes.Length;

            sw.Write(bytes);

            **/

        }
    }
}
