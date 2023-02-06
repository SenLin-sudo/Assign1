using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// This method returns number add 10 when receiving a get request number
        /// <example> GET api/AddTen/{id} </example>
        /// </summary>
        /// <param name="id"></param>
        /// <param>[21,0,-9]</param>
        /// <returns>[31,10,1]</returns>

        public int  Get(int id)
        {
            return  id+10  ; 
        }


    }
}
