using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01455211.Controllers
{
    public class SquareController : ApiController
    {
        // Question 2 - Returns the square of the integer input {id}.
        public int GET(int id)
        {
            int square = id * id;
            return square;
        }
    }
}
