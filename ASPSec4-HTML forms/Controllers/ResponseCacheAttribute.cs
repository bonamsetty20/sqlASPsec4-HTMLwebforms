using System;

namespace ASPSec4_HTML_forms.Controllers
{
    internal class ResponseCacheAttribute : Attribute
    {
        public int Duration { get; set; }
        public object Location { get; set; }
        public bool NoStore { get; set; }
    }
}