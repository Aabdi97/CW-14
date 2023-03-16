using AppCore.Contract;
using AppCore.Entity;
using Repository;

namespace AppService
{
    public class SendMoneyService: ISendMoneyService
    {
        private ISendMoneyRepository sendMoneyRepository;

        public SendMoneyService()
        {
            sendMoneyRepository = new SendMoneyRepository();
        }
        public int RandomNumber()
        {
            Random random = new Random();
            return random.Next(7000);
        }
        public bool CheckRandomNumber(int inputNum ,int outputNum)
        {
             return (inputNum == outputNum);            
        }
        public int GetId()
        {
            int Id = sendMoneyRepository.GetAll().Max(x => x.Id) + 1;
            return Id;
        }
        public SendMoney? Get(int id)
        {
           var transaction= sendMoneyRepository.Get(id);
            return transaction;
        }
        public List<SendMoney> GetAll()
        {
            var allTransaction=sendMoneyRepository.GetAll();
            return allTransaction;
        }
        public void AddToDb(SendMoney send,int inputNum,int outputNum)
        {
           if(CheckRandomNumber(inputNum, outputNum))
            {
                send.Id = GetId();
                sendMoneyRepository.Add(send);
            }
           
        }
    }
}