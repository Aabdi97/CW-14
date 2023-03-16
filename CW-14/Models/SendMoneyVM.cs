using AppCore.Contract;
using AppService;
using System.ComponentModel.DataAnnotations;

namespace CW_14.Models
{
    public class SendMoneyVM
    {
        [Required(ErrorMessage = "{0}پرش کن ")]
        [StringLength(16,MinimumLength =16,ErrorMessage ="کمه یا زیاده")]
        [Display(Name = "شماره کارت")]
        public string CardNumber { get; set; }
        [Required(ErrorMessage = "{0}پرش کن ")]
        [Display(Name = "مبلغ")]
        public int Money { get; set; }
        public int OutputRandomNumber { get; set; }

        [Required(ErrorMessage = "پر نکنی رد نمیشی")]
        public int InputRandomNumber { get; set; }
        public SendMoneyVM()
        {
            ISendMoneyService services = new SendMoneyService();
            OutputRandomNumber = services.RandomNumber();
        }
    }
}
