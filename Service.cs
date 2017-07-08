using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace McRest
{
    class Service : IService
    {

        public Message EchoWithGet(string s)
        {
            return WebOperationContext.Current.CreateTextResponse(Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                response = "You said " + s
            }));
        }

        public Message EchoWithPost(HelloMessage s)
        {
            string[] result = new string[s.Repeat];
            string myInsult = $"You said, '{s.Greeting}{s.Message}'";

            for(int i = 0; i < s.Repeat; i++)
            {
                result[i] = myInsult;
            }
            return WebOperationContext.Current.CreateTextResponse(Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                response = result
            }));
        }
    }

    [DataContract]
    [Newtonsoft.Json.JsonObject]
    class HelloMessage
    {
        [DataMember]
        public string Message;

        [DataMember]
        public string Greeting;

        [DataMember]
        public int Repeat;
    }
}
