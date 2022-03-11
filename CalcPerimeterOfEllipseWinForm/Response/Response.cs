using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcPerimeterOfEllipseWinForm.Response
{
    public class Response
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Root
        {
            public string status { get; set; }
            public string SmallDiameter { get; set; }
            public string BigDiameter { get; set; }
        }

    }
}
