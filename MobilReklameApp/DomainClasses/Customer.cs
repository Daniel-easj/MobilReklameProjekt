﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Core;
using MobilReklameApp.BaseClasses;

namespace MobilReklameApp.DomainClasses
{
    class Customer : DomainClassBase
    {

        private string _adresse;
        private int _tlf;
        private string _mail;


        public Customer(string Adresse, int Telefon, string Mail)
        {
            _adresse = Adresse;
            _tlf = Telefon;
            _mail = Mail;
            Id = _tlf;
        }

        public string Adresse
        {
            get { return _adresse; }
        }

        public int Telefon
        {
            get { return _tlf; }
        }

        public string Mail
        {
            get { return _mail; }
        }

        public override int Id { get; set; }
    }
}