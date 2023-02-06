using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method returns a string when receiving a post request, but you need run CMD to see it.
        /// Enter curl -d "" "" in CMD and paste request in between last two quotation.
        /// <example> POST api/greeting </example> 
        /// </summary>
        /// <returns> "Hello World!" </returns>
        

        public string Post()
        {
            return  "Hello World!";
        }


        /// <summary>
        /// This method returns a string when receiving a get request
        /// <example> GET api/greeting </example>
        /// </summary>
        /// <param name="id"></param>
        /// <param> [3,6,0] </param>
        /// <returns> "Greeting to 3 people!", "Greeting to 6 people!","Greeting to 0 people!"</returns>


        public string Get(string id)
        {
            return "Greeting to " +  String.Format(id)+ " people!";
        }


    }
}
