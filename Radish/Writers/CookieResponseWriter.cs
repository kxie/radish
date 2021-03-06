using System;
using System.Net;

namespace Radish.Writers
{
    public class CookieResponseWriter : IResponseWriter
    {
        private readonly string _name;
        private readonly string _value;

        public CookieResponseWriter(string name, string value)
        {
            _name = name;
            _value = value;
        }

        public void Write(IHttpResponse response)
        {
            response.AppendCookie(new Cookie(_name, _value));
        }
    }
}