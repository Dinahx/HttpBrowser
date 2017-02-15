using HTTPBrowser;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            WebBrowser web = new WebBrowser();
            //ResponsePack_WebBrowser r = web.Request("https://www.baidu.com", null) as ResponsePack_WebBrowser;
            string json = File.ReadAllText(@"C:\Users\Sier\Desktop\m.ctrip.com.har");
            //string json = File.ReadAllText(@"C:\Users\Sier\Desktop\aio.liantuo.com.har");
            HttpHar h = JsonConvert.DeserializeObject<HttpHar>(json);
            Cookie[] c = new  Cookie[0];
            h.log.entries[0].request.url = "https://123.sogou.com/";
            var r = web.Request(h.log.entries[0].request, c);
             
            web.RefreshConfig();
            RequestConfig req = new RequestConfig();
        }
    }
}
