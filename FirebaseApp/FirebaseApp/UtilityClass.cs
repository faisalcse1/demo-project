using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
//using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseApp
{
   public static class UtilityClass
    {
        public static bool IsCheckInternet()
        {
            try
            {
                using (var clint=new WebClient())
                {
                    using (clint.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
