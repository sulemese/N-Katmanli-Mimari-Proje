﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityPersonel
    {
        private int id; // CTRL + R + E YAPARSAN PROPERTYSİ GELİYOR 
        private string ad;
        private string soyad;
        private string sehir;
        private string gorev;
        private short maaş;

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        public string Gorev { get => gorev; set => gorev = value; }
        public short Maaş { get => maaş; set => maaş = value; }
    }
}
