using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bachat.Controllers
{
    public class TransactionController : Controller
    {
        [Route("/api/getsummary")]
        public string GetSummary()
        {
            return "Get Summary of all transactions";
        }

        [Route("/api/getmonths")]
        public string GetMonths()
        {
            return "Get Summary of transactions for a month";
        }
    }
}