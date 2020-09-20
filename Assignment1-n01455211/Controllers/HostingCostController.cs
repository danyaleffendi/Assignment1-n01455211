using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01455211.Controllers
{
    public class HostingCostController : ApiController
    {
        // Bonus Question - Fortnight Hosting Cost
        //helped taken from https://docs.microsoft.com/de-de/dotnet/api/system.math.floor?redirectedfrom=MSDN&view=netcore-3.1#System_Math_Floor_System_Double_
        //https://docs.microsoft.com/en-us/dotnet/api/system.globalization.numberformatinfo.currencysymbol?view=netcore-3.1
        
        public string GET(double id)
        {

            double term = id / 14; //finding fortnight term
            int fortnight = (int)Math.Floor(term); //rounding down to get whole number
            double cost = (fortnight + 1) * 5.5; //calculating fortnight rates
            string costc = String.Format("{0:c}", cost); //implementing currency format on cost

            double tax = cost * 0.13; //tax amount
            double taxr = Math.Round((Double)tax, 2); // rounding tax figure to 2 decimal points
            string taxcc = String.Format("{0:c}", taxr); //implementing currency format to tax amount

            double total = cost + tax; //adding 13% tax
            Double totalprice = Math.Round((Double)total, 2); // rounding total to 2 decimal points           
            string finalprice = String.Format("{0:c}", totalprice); //implementing currency format to total price

            string rate = fortnight + " fortnights at $5.50/FN = " + costc + " CAD";
            string hst = "HST 13% = " + taxcc + " CAD";
            string final = "Total = " + finalprice + " CAD";

            return rate + "\r\n" + hst + "\r\n" + final;                      
            
        }
    }
}

