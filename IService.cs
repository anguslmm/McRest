using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace McRest
{
    [ServiceContract]
    interface IService
    {
        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json)]
        Message EchoWithGet(string s);

        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Message EchoWithPost(HelloMessage s);
    }
}
