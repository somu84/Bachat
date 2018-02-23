using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bachat.Models
{
    public class Transaction
    {
        public double Amount { get; set; }
        public string Category { get; set; }

        public static Transaction CreateTransactionObject(string csvString)
        {
            if(string.IsNullOrWhiteSpace(csvString))
            {
                return null;
            }
            var lineEntry = csvString.Split(",");
            if(lineEntry.Length != 2)
            {
                return null;
            }
            try
            {
                return new Transaction { Amount = Convert.ToDouble(lineEntry[1]), Category = lineEntry[0] };
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
