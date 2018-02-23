using Bachat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Bachat.Providers
{
    interface IDataStoreProvider
    {
        // Read 
        Task<List<Transaction>> FetchAllTransactionsAsync(DateTime date);

        // Write
        Task<Boolean> WriteTransaction(Transaction trans); 
        
        // Delete

        // Update
    }
}
