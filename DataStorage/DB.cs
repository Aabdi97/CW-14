using AppCore.Entity;

namespace DataStorage
{
    public class DB
    {
        public static List<SendMoney> Transactions =new List<SendMoney>()
        {
            new SendMoney(){ Id=1,CardNumber="6104337512131511",Money=1000}
        };
    }
}