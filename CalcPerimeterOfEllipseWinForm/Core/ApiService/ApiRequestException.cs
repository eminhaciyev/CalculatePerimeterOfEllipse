using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcPerimeterOfEllipseWinForm.Core.ApiService
{
    public class ApiRequestException: Exception
    {
        public ApiRequestException() { }
        public ApiRequestException(string message) : base($"Api request failed: {message}") { }
    }
}
