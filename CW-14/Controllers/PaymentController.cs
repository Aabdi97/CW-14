﻿using AppCore.Contract;
using AppCore.Entity;
using AppService;
using CW_14.Models;
using Microsoft.AspNetCore.Mvc;

namespace CW_14.Controllers
{
    public class PaymentController : Controller
    {
        private ISendMoneyService services;
        public PaymentController()
        {
            services = new SendMoneyService();
        }
        public void CompleteOrder()
        {

        }
        [HttpGet]
        public IActionResult SendMoneyForm()
        {
            SendMoneyVM model = new SendMoneyVM();
            return View(model);
        }
        [HttpPost]
        public IActionResult SendMoneyForm(SendMoneyVM send)
        {

            SendMoney sendMoney = new SendMoney()
            {
                CardNumber = send.CardNumber,
                Money = send.Money
            };
            if (ModelState.IsValid)
            {
                if (send.Cvv2 != send.VerifyingCvv2)
                {
                    ModelState.AddModelError(string.Empty, "برابر نیست");
                }
                if (send.InputRandomNumber == send.OutputRandomNumber)
                {
                    services.AddToDb(sendMoney, send.InputRandomNumber, send.OutputRandomNumber);
                    var HttpVerb = HttpContext.Request.Method;
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "برو روبات");
                }
            }
            return View(send);
        }
        //public IActionResult ShowRequestDetails(string? httpContext)
        //{
        //    var IpAddress = HttpContext.Connection.RemoteIpAddress.ToString();
        //    var HttpVerb = httpContext;
        //    ViewBag.Ip = IpAddress;
        //    ViewBag.HttpVerb = HttpVerb;
        //    return View();
        //}
        public bool check(string CardNumber)
        {
           return services.CheckCardNumber(CardNumber);
        }

    }
}
