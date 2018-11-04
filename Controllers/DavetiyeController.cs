using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BirthdayApp.Controllers
{
    public class DavetiyeController : ApiController
    {

        public IEnumerable<Davetiye> GetKatilanlar()
        {
            return Veritabani.Liste.Where(i => i.KatilmaDurumu == true);
        }

        public IEnumerable<Davetiye> GetKatilmayanlar()
        {
            return Veritabani.Liste.Where(i => i.KatilmaDurumu == false);
        }

        public void Ekle(Davetiye model)
        {
            if (ModelState.IsValid)
            {
                Veritabani.Add(model);
            }
        }
    }
}
