using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Assignment1_n01455211.Controllers
{
    public class AddTenController : ApiController
    {
        // Question 1 - Returns 10 more than the integer input {id}.
        public int GET(int id)
        {
            int addten = id + 10;
            return addten;
        }
    }
}