using Elmah;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmahSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Convert.ToInt32("A");
            }
            catch (Exception ex)
            {
                ErrorLog errorLog = ErrorLog.GetDefault(null);
                errorLog.Log(new Error(ex));
            }
        }
    }
}
