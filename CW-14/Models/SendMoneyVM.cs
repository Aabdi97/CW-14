using AppCore.Contract;
using AppService;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CW_14.Models
{
    public class SendMoneyVM
    {
        [RegularExpression("^6037\\d{12}", ErrorMessage = "Name cannot contain credit card number")]
        [Required(ErrorMessage = "{0}پرش کن ")]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "کمه یا زیاده")]
        [Display(Name = "شماره کارت")]
        //[Remote(controller:"Payment",action: "check",ErrorMessage ="شماره کارت با 6037 شروع نشده")]
        public string CardNumber { get; set; }


        [Required(ErrorMessage = "{0}پرش کن ")]
        [Display(Name = "مبلغ")]
        public int Money { get; set; }


        public int OutputRandomNumber { get; set; }


        [Required(ErrorMessage = "پر نکنی رد نمیشی")]
        public int InputRandomNumber { get; set; }


        [Required(ErrorMessage = "پر نکنی رد نمیشی")]
        [Display(Name = "cvv2")]
        [StringLength(4, MinimumLength = 3, ErrorMessage = "کمه یا زیاده")]
   
        public string Cvv2 { get; set; }


        [Required(ErrorMessage = "پر نکنی رد نمیشی")]
        [Display(Name = "verifying cvv2")]
        [StringLength(4, MinimumLength = 3, ErrorMessage = "کمه یا زیاده")]
        [Compare("Cvv2", ErrorMessage ="درست وارد کن")]
        public string VerifyingCvv2 { get; set; }


        public SendMoneyVM()
        {
            ISendMoneyService services = new SendMoneyService();
            OutputRandomNumber = services.RandomNumber();
        }
    }
}
