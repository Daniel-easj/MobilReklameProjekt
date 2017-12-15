﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklameApp.SubClasses
{
    class Products
    {
        //Produkt___________________________________________________________________________________________________
        private string _mål;
        private string _antal;
        private string _lam;
        private string _medie;
        //private string _751c;
        private string _aluSand3mm;
        private string _pvc10mm;
        private string _leveringsAntal;
        private string _dtpKr;
        private string _opTil10;
        private string _fragtKr;
        private string _prisKr;


        public string Mål
        {
            get { return _mål; }
            set { _mål = value; }
        }

        public string Antal
        {
            get { return _antal; }
            set { _antal = value; }
        }

        public string Lam
        {
            get { return _lam; }
            set { _lam = value; }
        }

        public string Medie
        {
            get { return _medie; }
            set { _medie = value; }
        }

        //public string 751c
        //{
        //  get {
        //        return _751c;
        //    } 
        //}

        public string AluSand3mm
        {
            get { return _aluSand3mm; }
            set { _aluSand3mm = value; }
        }

        public string PVC10mm
        {
            get { return _pvc10mm; }
            set { _pvc10mm = value; }
        }

        public string LeveringsAntal
        {
            get { return _leveringsAntal; }
            set { _leveringsAntal = value; }
        }

        public string DTPKr
        {
            get { return _dtpKr; }
            set { _dtpKr = value; }
        }

        public string OpTil10Procent
        {
            get { return _opTil10; }
            set { _opTil10 = value; }
        }

        public string FragtKr
        {
            get { return _fragtKr; }
            set { _fragtKr = value; }
        }

        public string PrisKr
        {
            get { return _prisKr; }
            set { _prisKr = value; }
        }
        //Produkt___________________________________________________________________________________________________

        public Products(string mål, string antal, string lam, string medie, string aluSand3Mm, string pvc10Mm,
            string leveringsAntal, string dtpKr, string opTil10, string fragtKr, string prisKr)
        {
            _mål = mål;
            _antal = antal;
            _lam = lam;
            _medie = medie;
            _aluSand3mm = aluSand3Mm;
            _pvc10mm = pvc10Mm;
            _leveringsAntal = leveringsAntal;
            _dtpKr = dtpKr;
            _opTil10 = opTil10;
            _fragtKr = fragtKr;
            _prisKr = prisKr;
        }















    }
}