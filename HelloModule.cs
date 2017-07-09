using Nancy;
using Nancy.ModelBinding;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McRest
{
    class HelloResponse
    {
        public string Response { get; set; }
    }

    public class HelloModule : NancyModule
    {
        private static HelloResponse hello = new HelloResponse()
        {
            Response = "Hello, dawg"
        };

        public HelloModule()
        {
            Get["/"] = parameters => hello;
            Post["/"] = parameters =>
            {
                hello = this.Bind<HelloResponse>();
                return hello;
            };
        }
    }

}
