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
            return "Testing CI/CD";
        }

        [Route("/api/getmonths")]
        public string GetMonths()
        {
            return "Get Summary of transactions for a month";
        }

        [Route("/api/postTransactions")]
        public IActionResult postTransactions(double amount, string category)
        {
            var fileProvider = FileUtilities.GetFileProvider();
            fileProvider.AddEntry(amount, category);
        }
    }
}