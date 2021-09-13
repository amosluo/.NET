using AspNetLockTest.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetLockTest.Controllers
{
    public class ValuesController : ApiController
    {

        readonly object obj = new object();

        // GET api/values/5
        public int Get()
        {
            lock (Global.lck)
            {
                Global.Current++;
                return Global.Current;
            }
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
