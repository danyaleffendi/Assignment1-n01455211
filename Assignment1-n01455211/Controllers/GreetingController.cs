using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;

namespace Assignment1_n01455211.Controllers
{
    public partial class GreetingController : ApiController
    {
        // Question 3 - Returns the string “Hello World!” through POST

       public IEnumerable<string> Post()
       {
          return new string[] { "Hello World!" };
       }
        

        // Question 4 - Returns the string “Greetings to {id} people!” where id is an integer value.
        public string GET(int id)
         {
            string greetings = "Greetings to " + id + " people!";
            return greetings;
         }
        
    }
}
  
