using AppCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Contract
{
    public interface ISendMoneyService
    {
        public int RandomNumber();

        public bool CheckRandomNumber(int inputNum, int outputNum);

        public SendMoney? Get(int id);

        public List<SendMoney> GetAll();

        public void AddToDb(SendMoney send,int inputNum, int outputNum);

    }
}
