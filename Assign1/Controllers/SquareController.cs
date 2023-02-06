using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign1.Controllers
{ 
    /// <summary>
    /// This method returns a square number when receiving a get request number
    /// <example> GET api/Square/{id} </example>
    /// </summary>
    /// <param name= "id" ></param>
    /// <param> [2,-2,10] </param>
    /// <return> [4,4,100] </return>
    public class SquareController : ApiController
    {
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id * id };
        }

    }
}
