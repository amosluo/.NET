using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetLockTest.App_Start
{
    public class Global
    {
        public static int Current { get; set; } = 0;

        public static object lck = new object();
    }
}