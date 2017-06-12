using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDeseni
{
    class GoldPc:IBilgisayarToplayicisi
    {
        private Bilgisayar bilgisayar;

        public Bilgisayar Bilgisayar
        {
            get { return bilgisayar; }
        }

        public GoldPc() {
            bilgisayar = new Bilgisayar("Gold Pc");
        }

        public void CdRom_Olustur()
        {
            bilgisayar["cdRom"] = "52x GoldStar";
        }

        public void Hdd_Olustur()
        {
            bilgisayar["hdd"] = "60gb Segate";
        }

        public void Monitor_Olustur()
        {
            bilgisayar["monitor"] = "17' Hyundai";
        }

        public void Ram_Olustur()
        {
            bilgisayar["ram"] = "512mb DDR2 Kingston";
        }
    }
}
