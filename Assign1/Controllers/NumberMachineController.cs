using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// This method returns 4 number with 4 mathematical operation when receiving a get request
        /// <example>GET api/NumberMachine/{id}</example>
        /// </summary>
        /// <param name="id"></param>
        /// <param> [10,-5,30]</param>
        /// <returns> [9,20,20,5] [-6,5,-10,-2] [29,40,60,15]</returns>


        public IEnumerable<int> Get(int id)
        {
            return new int[] { id-1, id+10, id*2, id/2 };
        }
    }
}
