using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace BasicServerHTTPlistener
{
    public class Header
    {
        public Header(HttpListenerRequest request)
        {
            Console.WriteLine("Accept = " + request.Headers[HttpRequestHeader.Accept.ToString()]);
            Console.WriteLine("AcceptCharset = " + request.Headers[HttpRequestHeader.AcceptCharset.ToString()]);
            Console.WriteLine("AcceptEncoding = " + request.Headers[HttpRequestHeader.AcceptEncoding.ToString()]);
            Console.WriteLine("AcceptLanguage = " + request.Headers[HttpRequestHeader.AcceptLanguage.ToString()]);
            Console.WriteLine("Allow = " + request.Headers[HttpRequestHeader.Allow.ToString()]);
            Console.WriteLine("Authorization = " + request.Headers[HttpRequestHeader.Authorization.ToString()]);
            Console.WriteLine("UserAgent = " + request.Headers[HttpRequestHeader.UserAgent.ToString()]);
            Console.WriteLine("From = " + request.Headers[HttpRequestHeader.From.ToString()]);
            Console.WriteLine("Cookie = " + request.Headers[HttpRequestHeader.Cookie.ToString()]);
        }
    }
}
