using AppCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Contract
{
    public interface ISendMoneyRepository
    {
        void Add(SendMoney send);
        SendMoney? Get(int id);
        List<SendMoney>? GetAll();
    }
}
