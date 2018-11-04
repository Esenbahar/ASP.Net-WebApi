using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp.Models
{
    public static class Veritabani
    {
        private static Dictionary<string, Davetiye> _liste;

        static Veritabani()
        {
            _liste = new Dictionary<string, Davetiye>();

            _liste.Add("Hasan", new Davetiye
            {
                Ad = "Hasan",
                Eposta = "hasan@gmail.com",
                KatilmaDurumu = true
            });

            _liste.Add("Mehmet", new Davetiye
            {
                Ad = "Mehmet",
                Eposta = "mehmet@gmail.com",
                KatilmaDurumu = false
            });

            _liste.Add("Berrin", new Davetiye
            {
                Ad = "Berrin",
                Eposta = "berrin@gmail.com",
                KatilmaDurumu = true
            });

        }

        public static void Add(Davetiye model)
        {
            string key = model.Ad.ToLower();
            if (_liste.ContainsKey(key))
            {
                _liste[key] = model;
            }
            else
            {
                _liste.Add(key, model);
            }
        }

        public static IEnumerable<Davetiye> Liste
        {
            get { return _liste.Values; }
        }
    }
}

    
