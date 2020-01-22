using DataStructureConvertor.Attributes;
using DataStructureConvertor.Core;
using DataStructureConvertor.UIGetters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace DataStructureConvertor.Converters
{
    [ConverterUIActionType(typeof(OpenWebServiceConnectionGetter))]
    [ConverterCaption("API")]
    internal class ApiConverterInput : IConverterInput
    {
        private string _url;
        private WebRequest webRequest;
        private StreamReader sr;        
        public ApiConverterInput(string url)
        {
            this._url = url;
            webRequest = (HttpWebRequest)WebRequest.Create(_url);
            webRequest.Method = "GET";
            var streamResponse = webRequest.GetResponse().GetResponseStream();
            sr = new StreamReader(streamResponse);
        }

        public bool Read()
        {
            if(!sr.EndOfStream)
            {
                return true;
            }
            return false;                       
        }

        public void Dispose()
        {
            sr.Dispose();
        }

        public Record Parse()
        {
            JObject joRes = JObject.Parse(sr.ReadToEnd());
                        
            return new Record(Convert.ToInt32(joRes["id"]), joRes["name"].ToString());
        }

    }
}
