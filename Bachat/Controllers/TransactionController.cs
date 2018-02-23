using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bachat.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bachat.Controllers
{
    public class TransactionController : Controller
    {
        [Route("/api/getsummary")]
        public string GetSummary()
        {
            return "WIP!!!!!!!!!!!!!@#!@#!@#!@#!@#!@#";

        }

        [Route("/api/getmonths")]
        public async Task<string> GetMonths()
        {
            IDataStoreProvider dataProvider = new FileDataStoreProvider();
            var transactions = await dataProvider.FetchAllTransactionsAsync(DateTime.Now);
            var outPut = new StringBuilder();
            outPut.Append($"Showing all transactions for {DateTime.Now.ToString("MMM - yyyy")}");
            outPut.Append(Environment.NewLine);
            foreach (var trans in transactions)
            {
                outPut.Append($"Category: {trans.Category}       Amount: ${trans.Amount}");
                outPut.Append(Environment.NewLine);
            }
            return outPut.ToString();
        }

        /*[Route("/api/postTransactions")]
        public IActionResult postTransactions(double amount, string category)
        {
            IDataStoreProvider fileProvider = new FileDataStoreProvider();
            
        }*/
    }
}