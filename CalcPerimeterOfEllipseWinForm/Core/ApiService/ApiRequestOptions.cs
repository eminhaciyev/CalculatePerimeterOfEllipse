using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcPerimeterOfEllipseWinForm.Core.ApiService
{
    public class ApiRequestOptions
    {
        public Uri BaseAddress { get; set; }

        public Dictionary<string, string> Headers { get; }

        public bool UseDefaultCredentials { get; set; }

        public ApiRequestOptions()
        {
            Headers = new Dictionary<string, string>();
        }

        public void AddHeader(string key, string value)
        {
            if (!Headers.TryGetValue(key, out value))

                Headers[key] = value;
        }
    }
}
