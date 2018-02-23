using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Bachat.Models;

namespace Bachat.Providers
{
    public class FileDataStoreProvider : IDataStoreProvider
    {
        public async Task<List<Transaction>> FetchAllTransactionsAsync(DateTime date)
        {
            // Get the date and year to get the filename.
            var fileName = $"{date.ToString("MMM")}{date.ToString("yyyy")}.csv";
            var currentDir = Environment.CurrentDirectory;
            var filePath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, $@"TransactionFiles\{fileName}"));
            string line = string.Empty;
            var file = new StreamReader(filePath);
            var result = new List<Transaction>();
            
            //Read the file line by line
            while((line = await file.ReadLineAsync()) != null)
            {
                var trans = Transaction.CreateTransactionObject(line);
                if(trans != null)
                {
                    result.Add(trans);
                }
            }
            return result;
        }

        public Task<bool> WriteTransaction(Transaction trans)
        {
            throw new NotImplementedException();
        }
    }
}
