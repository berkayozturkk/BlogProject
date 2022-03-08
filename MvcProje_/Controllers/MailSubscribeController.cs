using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje_.Controllers
{
    public class MailSubscribeController : Controller
    {
        SubscribeMailManager _subscribeMailManager = new SubscribeMailManager();

        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult AddMail(SubscribeMail subscribe)
        {
            _subscribeMailManager.BLAdd(subscribe);
            return PartialView();
        }
    }
}