using AppCore.Contract;
using AppCore.Entity;
using DataStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SendMoneyRepository : ISendMoneyRepository
    {
        public void Add(SendMoney send)
        {
            DB.Transactions.Add(send);
        }
        public SendMoney? Get(int id)
        {
            var transaction = DB.Transactions.FirstOrDefault(m => m.Id == id);
            return transaction;
        }
        public List<SendMoney>? GetAll()
        {
            var ListOfTransaction= DB.Transactions.ToList();
            return ListOfTransaction;
        }

    }
}
