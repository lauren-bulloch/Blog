using System;
using System.Web;

namespace SitemapEngine.Core.Infrastructure.Bootstrap
{
    public class NullHttpRequest : HttpRequestBase
    {
        public override Uri Url
        {
            get { return new Uri(string.Empty, UriKind.Relative); }
        }

        public override string this[string key]
        {
            get { return null; }
        }

        public override string RawUrl
        {
            get { return null; }
        }
    }
}
